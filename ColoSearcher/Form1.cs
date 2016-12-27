using System;
using System.Windows.Forms;

namespace ColoSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            natureType.SelectedIndex = 0;
            abilityType.SelectedIndex = 0;
            genderType.SelectedIndex = 0;
            hiddenpower.SelectedIndex = 0;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (HPLow.Value > HPHigh.Value)
                MessageBox.Show("HP: Lower limit > Upper limit");
            else if (AtkLow.Value > AtkLow.Value)
                MessageBox.Show("Atk: Lower limit > Upper limit");
            else if (DefLow.Value > DefLow.Value)
                MessageBox.Show("Def: Lower limit > Upper limit");
            else if (SpALow.Value > SpALow.Value)
                MessageBox.Show("SpA: Lower limit > Upper limit");
            else if (SpDLow.Value > SpDLow.Value)
                MessageBox.Show("SpD: Lower limit > Upper limit");
            else if (SpeLow.Value > SpeLow.Value)
                MessageBox.Show("Spe: Lower limit > Upper limit");
            else
                search();
        }

        private void search()
        {
            for()
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

        private uint originSeed(uint pid)
        {
            uint pidl = pid & 0xFFFF;
            uint pidh = pid >> 16;

            uint test = pidl * 0x10000;
            uint x = 0;
            while(x < 65536)
            {
                uint testseed = test + x;
                uint prevseed = reverse(testseed);
                uint temp = prevseed >> 16;
                if (temp == pidh)
                    return reverse(prevseed);
            }
            return pid;
        }
    }
}
