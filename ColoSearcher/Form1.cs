using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ColoSearcher
{
    public partial class Form1 : Form
    {
        private readonly uint[] natures = { 100, 3, 2, 5, 20, 23, 11, 8, 13, 1, 16, 15, 14, 4, 17, 19, 7, 22, 10, 21, 9, 18, 6, 0, 24, 12 };
        private readonly String[] Natures = { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };
        private readonly String[] hiddenPowers = { "Fighting", "Flying", "Poison", "Ground", "Rock", "Bug", "Ghost", "Steel", "Fire", "Water", "Grass", "Electric", "Psychic", "Ice", "Dragon", "Dark" };
        private Thread searchThread;
        private bool refresh;
        private ThreadDelegate gridUpdate;
        private BindingSource binding = new BindingSource();
        private List<ColoList> coloList;
        private bool isSearching = false;
        private List<uint> slist = new List<uint>();
        private List<uint> rlist = new List<uint>();
        private uint shinyval;

        public Form1()
        {
            InitializeComponent();
            natureType.SelectedIndex = 0;
            abilityType.SelectedIndex = 0;
            genderType.SelectedIndex = 0;
            hiddenpower.SelectedIndex = 0;
            k_dataGridView.DataSource = binding;
            k_dataGridView.AutoGenerateColumns = true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            uint[] ivsLower = { (uint)HPLow.Value, (uint)AtkLow.Value, (uint)DefLow.Value, (uint)SpALow.Value, (uint)SpDLow.Value, (uint)SpeLow.Value };
            uint[] ivsUpper = { (uint)HPHigh.Value, (uint)AtkHigh.Value, (uint)DefHigh.Value, (uint)SpAHigh.Value, (uint)SpDHigh.Value, (uint)SpeHigh.Value };

            if (ivsLower[0] > ivsUpper[0])
                MessageBox.Show("HP: Lower limit > Upper limit");
            else if (ivsLower[1] > ivsUpper[1])
                MessageBox.Show("Atk: Lower limit > Upper limit");
            else if (ivsLower[2] > ivsUpper[2])
                MessageBox.Show("Def: Lower limit > Upper limit");
            else if (ivsLower[3] > ivsUpper[3])
                MessageBox.Show("SpA: Lower limit > Upper limit");
            else if (ivsLower[4] > ivsUpper[4])
                MessageBox.Show("SpD: Lower limit > Upper limit");
            else if (ivsLower[5] > ivsUpper[5])
                MessageBox.Show("Spe: Lower limit > Upper limit");
            else
            {
                if(isSearching)
                {
                    status.Text = "Previous search is still running";
                    return;
                }

                coloList = new List<ColoList>();
                binding = new BindingSource { DataSource = coloList };
                k_dataGridView.DataSource = binding;
                status.Text = "Searching";
                slist.Clear();
                rlist.Clear();
                shinyval = (uint.Parse(id.Text) ^ uint.Parse(sid.Text)) >> 4;

                searchThread =
                    new Thread(
                        () =>
                        getMethod(ivsLower, ivsUpper));
                searchThread.Start();

                var update = new Thread(updateGUI);
                update.Start();
            }
        }

        private void getMethod(uint[] ivsLower, uint[] ivsUpper)
        {
            uint method = 1;

            for(int x = 0; x < 6; x++)
            {
                uint temp = ivsUpper[x] - ivsLower[x] + 1;
                method *= temp;
            }

            if (method > 16384)
                generate2(ivsLower, ivsUpper, getNature());
            else
                generate(ivsLower, ivsUpper);
        }

        #region First search method
        private void generate(uint[] ivsLower, uint[] ivsUpper)
        {
            isSearching = true;
            uint nature = getNature();
            if (nature != 0)
            {
                nature = natures[nature];
            }
            uint ability = getAbility();
            uint gender = getGender();
            uint hp = getHP();
            //k_dataGridView.Rows.Clear();

            for (uint a = ivsLower[0]; a <= ivsUpper[0]; a++)
            {
                for (uint b = ivsLower[1]; b <= ivsUpper[1]; b++)
                {
                    for (uint c = ivsLower[2]; c <= ivsUpper[2]; c++)
                    {
                        for (uint d = ivsLower[3]; d <= ivsUpper[3]; d++)
                        {
                            for (uint e = ivsLower[4]; e <= ivsUpper[4]; e++)
                            {
                                for (uint f = ivsLower[5]; f <= ivsUpper[5]; f++)
                                {
                                    checkSeed(a, b, c, d, e, f, nature, ability, gender, hp);
                                }
                            }
                        }
                    }
                }
            }
            isSearching = false;
            status.Invoke((MethodInvoker)(() => status.Text = "Done. - Awaiting Command"));
        }

        //Credit to RNG Reporter for this
        private void checkSeed(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint nature, uint ability, uint gender, uint hP)
        {
            uint x8 = 0;
            uint x8_2 = 0;

            x8 = hp + (atk << 5) + (def << 10);
            x8_2 = x8 ^ 0x8000;

            for (uint cnt = 0; cnt <= 0x1FFFE; cnt++)
            {
                uint x_testXD = (cnt & 1) == 0 ? x8 : x8_2;
                uint seed = (x_testXD << 16) + (cnt % 0xFFFF);
                uint ColoSeed = reverse(seed);

                uint rng1XD = forward(seed);
                uint rng2XD = forward(rng1XD);
                uint rng3XD = forward(rng2XD);
                uint rng4XD = forward(rng3XD);
                rng1XD >>= 16;
                rng2XD >>= 16;
                rng3XD >>= 16;
                rng4XD >>= 16;

                if (Check(rng1XD, rng3XD, rng4XD, spe, spa, spd, nature))
                {
                    filterSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, hP, rng1XD, rng3XD, rng4XD, ColoSeed);
                }
            }
        }

        private static bool Check(uint iv, uint pid2, uint pid1, uint hp, uint atk, uint def, uint nature)
        {
            bool ret = false;

            uint test_hp = iv & 0x1f;
            uint test_atk = (iv & 0x3E0) >> 5;
            uint test_def = (iv & 0x7C00) >> 10;

            if (test_hp == hp && test_atk == atk && test_def == def)
            {

                if (nature == 0)
                {
                    ret = true;
                }
                else
                {
                    uint pid = (pid2 << 16) | pid1;
                    uint actualNature = pid % 25;
                    if (nature == actualNature)
                    {
                        ret = true;
                    }
                }
            }

            return ret;
        }

        private void filterSeed(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint nature, uint ability, uint gender, uint hP, uint rng1XD, uint rng3XD, uint rng4XD, uint seed)
        {
            uint pid = (rng3XD << 16) | rng4XD;
            nature = pid % 25;

            String shiny = "";
            if (Shiny_Check.Checked == true)
            {
                if (!isShiny(pid))
                {
                    return;
                }
                shiny = "!!!";
            }

            if (hP != 0)
            {
                uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
                if (actualHP != (hP - 1))
                {
                    return;
                }
            }

            if (ability != 0)
            {
                uint actualAbility = pid & 1;
                if (actualAbility != (ability - 1))
                {
                    return;
                }
            }
            ability = pid & 1;

            if (gender != 0)
            {
                if (gender == 1)
                {
                    if ((pid & 255) < 127)
                    {
                        return;
                    }
                }
                else if (gender == 2)
                {
                    if ((pid & 255) > 126)
                    {
                        return;
                    }
                }
                else if (gender == 3)
                {
                    if ((pid & 255) < 191)
                    {
                        return;
                    }
                }
                else if (gender == 4)
                {
                    if ((pid & 255) > 190)
                    {
                        return;
                    }
                }
                else if (gender == 5)
                {
                    if ((pid & 255) < 64)
                    {
                        return;
                    }
                }
                else if (gender == 6)
                {
                    if ((pid & 255) > 63)
                    {
                        return;
                    }
                }
                else if (gender == 7)
                {
                    if ((pid & 255) < 31)
                    {
                        return;
                    }
                }
                else if (gender == 8)
                {
                    if ((pid & 255) > 30)
                    {
                        return;
                    }
                }
            }

            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, hP, pid, shiny, seed);
        }
        #endregion

        #region Second search method
        //Credits to Zari for this
        private void generate2(uint[] ivsLower, uint[] ivsUpper, uint nature)
        {
            uint s = 0;
            uint srange = 1048576;
            isSearching = true;

            if (nature != 0)
                nature = natures[nature];

            uint ability = getAbility();
            uint gender = getGender();
            uint hiddenPower = getHP();

            for (uint z = 0; z < 32; z++)
            {
                for (uint h = 0; h < 64; h++)
                {
                    populate(s, srange);
                    for (uint n = 0; n < srange; n++)
                    {
                        uint[] ivs = calcIVs(ivsLower, ivsUpper, n);
                        if (ivs.Length != 1)
                        {
                            uint pid = pidChk(n, 0);
                            uint actualNature = pid % 25;
                            if (nature == 0 || nature == actualNature)
                                filterSeed2(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], actualNature, ability, gender, hiddenPower, slist[(int)n], pid);

                            pid = pidChk(n, 1);
                            actualNature = pid % 25;
                            if (nature == 0 || nature == actualNature)
                                filterSeed2(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], actualNature, ability, gender, hiddenPower, (slist[(int)n] ^ 0x80000000), pid);
                        }
                    }
                    s = slist[(int)srange];
                    slist.Clear();
                    rlist.Clear();
                }
            }
            isSearching = false;
        }

        private void filterSeed2(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint nature, uint ability, uint gender, uint hiddenPowerValue, uint seed, uint pid)
        {
            String shiny = "";
            if (Shiny_Check.Checked == true)
            {
                if (!isShiny(pid))
                {
                    return;
                }
                shiny = "!!!";
            }

            if (hiddenPowerValue != 0)
            {
                uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
                if (actualHP != (hiddenPowerValue - 1))
                {
                    return;
                }
            }

            if (ability != 0)
            {
                uint actualAbility = pid & 1;
                if (actualAbility != (ability - 1))
                {
                    return;
                }
            }
            ability = pid & 1;

            if (gender != 0)
            {
                if (gender == 1)
                {
                    if ((pid & 255) < 127)
                    {
                        return;
                    }
                }
                else if (gender == 2)
                {
                    if ((pid & 255) > 126)
                    {
                        return;
                    }
                }
                else if (gender == 3)
                {
                    if ((pid & 255) < 191)
                    {
                        return;
                    }
                }
                else if (gender == 4)
                {
                    if ((pid & 255) > 190)
                    {
                        return;
                    }
                }
                else if (gender == 5)
                {
                    if ((pid & 255) < 64)
                    {
                        return;
                    }
                }
                else if (gender == 6)
                {
                    if ((pid & 255) > 63)
                    {
                        return;
                    }
                }
                else if (gender == 7)
                {
                    if ((pid & 255) < 31)
                    {
                        return;
                    }
                }
                else if (gender == 8)
                {
                    if ((pid & 255) > 30)
                    {
                        return;
                    }
                }
            }
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, hiddenPowerValue, pid, shiny, seed);
        }

        private uint populateRNG(uint seed)
        {
            seed = (seed * 0x000343FD + 0x00269EC3) & 0xFFFFFFFF;
            slist.Add(seed);
            rlist.Add((seed >> 16));
            return seed;
        }

        private void populate(uint seed, uint srange)
        {
            uint s = seed;
            for (uint x = 0; x < (srange + 10); x++)
            {
                s = populateRNG(s);
            }
        }

        private uint[] calcIVs(uint[] ivsLower, uint[] ivsUpper, uint frame)
        {
            uint[] ivs;
            uint iv1 = rlist[(int)(frame + 1)];
            uint iv2 = rlist[(int)(frame + 2)];
            ivs = createIVs(iv1, iv2, ivsLower, ivsUpper);
            return ivs;
        }

        private uint[] createIVs(uint iv1, uint ivs2, uint[] ivsLower, uint[] ivsUpper)
        {
            uint[] ivs = new uint[6];

            for (int x = 0; x < 3; x++)
            {
                int q = x * 5;
                uint iv = (iv1 >> q) & 31;
                if (iv >= ivsLower[x] && iv <= ivsUpper[x])
                    ivs[x] = iv;
                else
                {
                    ivs = new uint[1];
                    return ivs;
                }
            }

            uint iV = (ivs2 >> 5) & 31;
            if (iV >= ivsLower[3] && iV <= ivsUpper[3])
                ivs[3] = iV;
            else
            {
                ivs = new uint[1];
                return ivs;
            }

            iV = (ivs2 >> 10) & 31;
            if (iV >= ivsLower[4] && iV <= ivsUpper[4])
                ivs[4] = iV;
            else
            {
                ivs = new uint[1];
                return ivs;
            }

            iV = ivs2 & 31;
            if (iV >= ivsLower[5] && iV <= ivsUpper[5])
                ivs[5] = iV;
            else
            {
                ivs = new uint[1];
                return ivs;
            }

            return ivs;
        }

        private uint pidChk(uint frame, uint xor_val)
        {
            uint pid = (rlist[(int)(frame + 4)] << 16) + rlist[(int)(frame + 5)];
            if (xor_val == 1)
                pid = pid ^ 0x80008000;

            return pid;
        }
        #endregion

        #region Helper methods
        private uint getNature()
        {
            if (natureType.InvokeRequired)
                return (uint)natureType.Invoke(new Func<uint>(getNature));
            else
                return (uint)natureType.SelectedIndex;
        }

        private uint getAbility()
        {
            if (abilityType.InvokeRequired)
                return (uint)abilityType.Invoke(new Func<uint>(getAbility));
            else
                return (uint)abilityType.SelectedIndex;
        }

        private uint getGender()
        {
            if (genderType.InvokeRequired)
                return (uint)genderType.Invoke(new Func<uint>(getGender));
            else
                return (uint)genderType.SelectedIndex;
        }

        private uint getHP()
        {
            if (hiddenpower.InvokeRequired)
                return (uint)hiddenpower.Invoke(new Func<uint>(getHP));
            else
                return (uint)hiddenpower.SelectedIndex;
        }

        private uint forward(uint seed)
        {
            seed *= 0x343FD;
            seed += 0x269EC3;
            seed &= 0xFFFFFFFF;
            return seed;
        }

        private uint reverse(uint seed)
        {
            seed *= 0xB9B33155;
            seed += 0xA170F641;
            seed &= 0xFFFFFFFF;
            return seed;
        }

        private int calcHPPower(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            int ret = 0;

            uint hpMod = hp & 3;
            if (hpMod == 2 || hpMod == 3)
                hpMod = 1;
            else
                hpMod = 0;
            uint atkMod = atk & 3;
            if (atkMod == 2 || atkMod == 3)
                atkMod = 1;
            else
                atkMod = 0;
            uint defMod = def & 3;
            if (defMod == 2 || defMod == 3)
                defMod = 1;
            else
                defMod = 0;
            uint spaMod = spa & 3;
            if (spaMod == 2 || spaMod == 3)
                spaMod = 1;
            else
                spaMod = 0;
            uint spdMod = spd & 3;
            if (spdMod == 2 || spdMod == 3)
                spdMod = 1;
            else
                spdMod = 0;
            uint speMod = spe & 3;
            if (speMod == 2 || speMod == 3)
                speMod = 1;
            else
                speMod = 0;

            uint test = hpMod + atkMod*2 + defMod*4 + speMod*8 + spaMod*16 + spdMod*32;
            test *= 40;
            test /= 63;
            test += 30;

            ret = (int)test;

            return ret;
        }

        private bool isShiny(uint PID)
        {
            uint test = ((PID >> 16) ^ (PID & 0xffff)) >> 4;
            return test == shinyval;
        }

        private uint calcHP(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            uint ret = 0;

            ret = ((((hp & 1) + 2*(atk & 1) + 4*(def & 1) + 8*(spe & 1) + 16*(spa & 1) + 32*(spd & 1)) * 15) / 63);

            return ret;
        }
        #endregion

        private void addSeed(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint nature, uint ability, uint gender, uint hP, uint pid, String shiny, uint seed)
        {
            String stringNature = Natures[nature];
            String hPString = hiddenPowers[calcHP(hp, atk, def, spa, spd, spe)];
            int hpPower = calcHPPower(hp, atk, def, spa, spd, spe);
            gender = pid & 255;
            char gender1;
            char gender2;
            char gender3;
            char gender4;

            if (shiny == "")
            {
                if (isShiny(pid))
                {
                    shiny = "!!!";
                }
            }

            if (gender < 31)
                gender1 = 'F';
            else
                gender1 = 'M';

            if (gender < 64)
                gender2 = 'F';
            else
                gender2 = 'M';

            if (gender < 126)
                gender3 = 'F';
            else
                gender3 = 'M';

            if (gender < 191)
                gender4 = 'F';
            else
                gender4 = 'M';

            coloList.Add(new ColoList
            {
                Seed = seed.ToString("x").ToUpper(),
                PID = pid.ToString("x").ToUpper(),
                Shiny = shiny,
                Nature = stringNature,
                Ability = (int)ability,
                Hp = (int)hp,
                Atk = (int)atk,
                Def = (int)def,
                SpA = (int)spa,
                SpD = (int)spd,
                Spe = (int)spe,
                HP = hPString,
                Power = hpPower,
                Eighth = gender1,
                Quarter = gender2,
                Half = gender3,
                Three_Fourths = gender4
            });
        }

        #region GUI code
        private void updateGUI()
        {
            gridUpdate = dataGridUpdate;
            ThreadDelegate resizeGrid = k_dataGridView.AutoResizeColumns;
            try
            {
                bool alive = true;
                while (alive)
                {
                    if (refresh)
                    {
                        Invoke(gridUpdate);
                        refresh = false;
                    }
                    if (searchThread == null || !searchThread.IsAlive)
                    {
                        alive = false;
                    }

                    Thread.Sleep(500);
                }
            }
            finally
            {
                Invoke(gridUpdate);
                Invoke(resizeGrid);
            }
        }


        #region Nested type: ThreadDelegate

        private delegate void ThreadDelegate();

        #endregion

        private void dataGridUpdate()
        {
            binding.ResetBindings(false);
        }
        #endregion

        #region Quick search settings
        private void button1_Click(object sender, EventArgs e)
        {
            HPLow.Value = 31;
            HPHigh.Value = 31;
            AtkLow.Value = 31;
            AtkHigh.Value = 31;
            DefLow.Value = 31;
            DefHigh.Value = 31;
            SpALow.Value = 0;
            SpAHigh.Value = 31;
            SpDLow.Value = 31;
            SpDHigh.Value = 31;
            SpeLow.Value = 31;
            SpeHigh.Value = 31;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HPLow.Value = 31;
            HPHigh.Value = 31;
            AtkLow.Value = 0;
            AtkHigh.Value = 31;
            DefLow.Value = 31;
            DefHigh.Value = 31;
            SpALow.Value = 31;
            SpAHigh.Value = 31;
            SpDLow.Value = 31;
            SpDHigh.Value = 31;
            SpeLow.Value = 31;
            SpeHigh.Value = 31;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HPLow.Value = 31;
            HPHigh.Value = 31;
            AtkLow.Value = 31;
            AtkHigh.Value = 31;
            DefLow.Value = 31;
            DefHigh.Value = 31;
            SpALow.Value = 31;
            SpAHigh.Value = 31;
            SpDLow.Value = 31;
            SpDHigh.Value = 31;
            SpeLow.Value = 31;
            SpeHigh.Value = 31;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HPLow.Value = 0;
            HPHigh.Value = 31;
            AtkLow.Value = 0;
            AtkHigh.Value = 31;
            DefLow.Value = 0;
            DefHigh.Value = 31;
            SpALow.Value = 0;
            SpAHigh.Value = 31;
            SpDLow.Value = 0;
            SpDHigh.Value = 31;
            SpeLow.Value = 0;
            SpeHigh.Value = 31;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                isSearching = false;
                status.Text = "Cancelled. - Awaiting Command";
                searchThread.Abort();
            }
        }
        #endregion
    }
}