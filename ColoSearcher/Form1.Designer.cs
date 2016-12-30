namespace ColoSearcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.k_dataGridView = new System.Windows.Forms.DataGridView();
            this.Shiny_Check = new System.Windows.Forms.CheckBox();
            this.L_ball = new System.Windows.Forms.Label();
            this.hiddenpower = new System.Windows.Forms.ComboBox();
            this.genderType = new System.Windows.Forms.ComboBox();
            this.L_sex = new System.Windows.Forms.Label();
            this.L_ability = new System.Windows.Forms.Label();
            this.L_search_S = new System.Windows.Forms.Label();
            this.L_search_D = new System.Windows.Forms.Label();
            this.L_search_C = new System.Windows.Forms.Label();
            this.L_search_B = new System.Windows.Forms.Label();
            this.L_search_A = new System.Windows.Forms.Label();
            this.L_search_H = new System.Windows.Forms.Label();
            this.SpeHigh = new System.Windows.Forms.NumericUpDown();
            this.HPLow = new System.Windows.Forms.NumericUpDown();
            this.label109 = new System.Windows.Forms.Label();
            this.AtkLow = new System.Windows.Forms.NumericUpDown();
            this.DefLow = new System.Windows.Forms.NumericUpDown();
            this.SpDHigh = new System.Windows.Forms.NumericUpDown();
            this.SpALow = new System.Windows.Forms.NumericUpDown();
            this.label110 = new System.Windows.Forms.Label();
            this.SpDLow = new System.Windows.Forms.NumericUpDown();
            this.SpeLow = new System.Windows.Forms.NumericUpDown();
            this.SpAHigh = new System.Windows.Forms.NumericUpDown();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.HPHigh = new System.Windows.Forms.NumericUpDown();
            this.DefHigh = new System.Windows.Forms.NumericUpDown();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.AtkHigh = new System.Windows.Forms.NumericUpDown();
            this.abilityType = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.L_mezapa = new System.Windows.Forms.Label();
            this.natureType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.MaskedTextBox();
            this.sid = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.k_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtkLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpDHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpALow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpDLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpAHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtkHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // k_dataGridView
            // 
            this.k_dataGridView.AllowUserToAddRows = false;
            this.k_dataGridView.AllowUserToResizeColumns = false;
            this.k_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.k_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.k_dataGridView.Location = new System.Drawing.Point(12, 379);
            this.k_dataGridView.Name = "k_dataGridView";
            this.k_dataGridView.RowTemplate.Height = 21;
            this.k_dataGridView.Size = new System.Drawing.Size(988, 231);
            this.k_dataGridView.TabIndex = 178;
            // 
            // Shiny_Check
            // 
            this.Shiny_Check.AutoSize = true;
            this.Shiny_Check.Location = new System.Drawing.Point(221, 250);
            this.Shiny_Check.Name = "Shiny_Check";
            this.Shiny_Check.Size = new System.Drawing.Size(76, 17);
            this.Shiny_Check.TabIndex = 253;
            this.Shiny_Check.Text = "Shiny Only";
            this.Shiny_Check.UseVisualStyleBackColor = true;
            // 
            // L_ball
            // 
            this.L_ball.Location = new System.Drawing.Point(190, 179);
            this.L_ball.Name = "L_ball";
            this.L_ball.Size = new System.Drawing.Size(57, 20);
            this.L_ball.TabIndex = 252;
            this.L_ball.Text = "HP";
            this.L_ball.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hiddenpower
            // 
            this.hiddenpower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hiddenpower.FormattingEnabled = true;
            this.hiddenpower.Items.AddRange(new object[] {
            "Any",
            "Fighting",
            "Flying",
            "Poison",
            "Ground",
            "Rock",
            "Bug",
            "Ghost",
            "Steel",
            "Fire",
            "Water",
            "Grass",
            "Electric",
            "Psychic",
            "Ice",
            "Dragon",
            "Dark"});
            this.hiddenpower.Location = new System.Drawing.Point(249, 178);
            this.hiddenpower.Name = "hiddenpower";
            this.hiddenpower.Size = new System.Drawing.Size(113, 21);
            this.hiddenpower.TabIndex = 238;
            // 
            // genderType
            // 
            this.genderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderType.FormattingEnabled = true;
            this.genderType.Items.AddRange(new object[] {
            "Don\'t Care / Genderless",
            "Male (50% Male / 50% Female)",
            "Female (50% Male / 50% Female)",
            "Male (25% Male / 75% Female)",
            "Female (25% Male / 75% Female)",
            "Male (75% Male / 25% Female)",
            "Female (75% Male / 25% Female)",
            "Male (87.5% Male / 12.5% Female)",
            "Female (87.5% Male / 12.5% Female)",
            "Male (100% Male)",
            "Female (100% Female)"});
            this.genderType.Location = new System.Drawing.Point(249, 109);
            this.genderType.Name = "genderType";
            this.genderType.Size = new System.Drawing.Size(113, 21);
            this.genderType.TabIndex = 235;
            // 
            // L_sex
            // 
            this.L_sex.Location = new System.Drawing.Point(190, 109);
            this.L_sex.Name = "L_sex";
            this.L_sex.Size = new System.Drawing.Size(57, 20);
            this.L_sex.TabIndex = 251;
            this.L_sex.Text = "Gender";
            this.L_sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_ability
            // 
            this.L_ability.Location = new System.Drawing.Point(190, 145);
            this.L_ability.Name = "L_ability";
            this.L_ability.Size = new System.Drawing.Size(57, 20);
            this.L_ability.TabIndex = 249;
            this.L_ability.Text = "Ability";
            this.L_ability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_search_S
            // 
            this.L_search_S.Location = new System.Drawing.Point(28, 244);
            this.L_search_S.Name = "L_search_S";
            this.L_search_S.Size = new System.Drawing.Size(40, 20);
            this.L_search_S.TabIndex = 242;
            this.L_search_S.Text = "Spe";
            this.L_search_S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_search_D
            // 
            this.L_search_D.Location = new System.Drawing.Point(28, 209);
            this.L_search_D.Name = "L_search_D";
            this.L_search_D.Size = new System.Drawing.Size(40, 20);
            this.L_search_D.TabIndex = 241;
            this.L_search_D.Text = "SpD";
            this.L_search_D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_search_C
            // 
            this.L_search_C.Location = new System.Drawing.Point(28, 175);
            this.L_search_C.Name = "L_search_C";
            this.L_search_C.Size = new System.Drawing.Size(40, 20);
            this.L_search_C.TabIndex = 240;
            this.L_search_C.Text = "SpA";
            this.L_search_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_search_B
            // 
            this.L_search_B.Location = new System.Drawing.Point(28, 140);
            this.L_search_B.Name = "L_search_B";
            this.L_search_B.Size = new System.Drawing.Size(40, 20);
            this.L_search_B.TabIndex = 239;
            this.L_search_B.Text = "Def";
            this.L_search_B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_search_A
            // 
            this.L_search_A.Location = new System.Drawing.Point(28, 105);
            this.L_search_A.Name = "L_search_A";
            this.L_search_A.Size = new System.Drawing.Size(40, 20);
            this.L_search_A.TabIndex = 237;
            this.L_search_A.Text = "Atk";
            this.L_search_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_search_H
            // 
            this.L_search_H.Location = new System.Drawing.Point(28, 71);
            this.L_search_H.Name = "L_search_H";
            this.L_search_H.Size = new System.Drawing.Size(40, 20);
            this.L_search_H.TabIndex = 234;
            this.L_search_H.Text = "HP";
            this.L_search_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpeHigh
            // 
            this.SpeHigh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeHigh.Location = new System.Drawing.Point(139, 245);
            this.SpeHigh.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.SpeHigh.Name = "SpeHigh";
            this.SpeHigh.Size = new System.Drawing.Size(45, 22);
            this.SpeHigh.TabIndex = 232;
            this.SpeHigh.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // HPLow
            // 
            this.HPLow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPLow.Location = new System.Drawing.Point(72, 72);
            this.HPLow.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.HPLow.Name = "HPLow";
            this.HPLow.Size = new System.Drawing.Size(45, 22);
            this.HPLow.TabIndex = 221;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(119, 251);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(19, 13);
            this.label109.TabIndex = 248;
            this.label109.Text = "～";
            // 
            // AtkLow
            // 
            this.AtkLow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtkLow.Location = new System.Drawing.Point(72, 107);
            this.AtkLow.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.AtkLow.Name = "AtkLow";
            this.AtkLow.Size = new System.Drawing.Size(45, 22);
            this.AtkLow.TabIndex = 223;
            // 
            // DefLow
            // 
            this.DefLow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefLow.Location = new System.Drawing.Point(72, 141);
            this.DefLow.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DefLow.Name = "DefLow";
            this.DefLow.Size = new System.Drawing.Size(45, 22);
            this.DefLow.TabIndex = 225;
            // 
            // SpDHigh
            // 
            this.SpDHigh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpDHigh.Location = new System.Drawing.Point(139, 211);
            this.SpDHigh.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.SpDHigh.Name = "SpDHigh";
            this.SpDHigh.Size = new System.Drawing.Size(45, 22);
            this.SpDHigh.TabIndex = 230;
            this.SpDHigh.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // SpALow
            // 
            this.SpALow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpALow.Location = new System.Drawing.Point(72, 176);
            this.SpALow.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.SpALow.Name = "SpALow";
            this.SpALow.Size = new System.Drawing.Size(45, 22);
            this.SpALow.TabIndex = 227;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(119, 216);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(19, 13);
            this.label110.TabIndex = 247;
            this.label110.Text = "～";
            // 
            // SpDLow
            // 
            this.SpDLow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpDLow.Location = new System.Drawing.Point(72, 211);
            this.SpDLow.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.SpDLow.Name = "SpDLow";
            this.SpDLow.Size = new System.Drawing.Size(45, 22);
            this.SpDLow.TabIndex = 229;
            // 
            // SpeLow
            // 
            this.SpeLow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeLow.Location = new System.Drawing.Point(72, 245);
            this.SpeLow.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.SpeLow.Name = "SpeLow";
            this.SpeLow.Size = new System.Drawing.Size(45, 22);
            this.SpeLow.TabIndex = 231;
            // 
            // SpAHigh
            // 
            this.SpAHigh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpAHigh.Location = new System.Drawing.Point(139, 176);
            this.SpAHigh.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.SpAHigh.Name = "SpAHigh";
            this.SpAHigh.Size = new System.Drawing.Size(45, 22);
            this.SpAHigh.TabIndex = 228;
            this.SpAHigh.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(119, 78);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(19, 13);
            this.label112.TabIndex = 243;
            this.label112.Text = "～";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(119, 182);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(19, 13);
            this.label113.TabIndex = 246;
            this.label113.Text = "～";
            // 
            // HPHigh
            // 
            this.HPHigh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPHigh.Location = new System.Drawing.Point(139, 72);
            this.HPHigh.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.HPHigh.Name = "HPHigh";
            this.HPHigh.Size = new System.Drawing.Size(45, 22);
            this.HPHigh.TabIndex = 222;
            this.HPHigh.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // DefHigh
            // 
            this.DefHigh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefHigh.Location = new System.Drawing.Point(139, 141);
            this.DefHigh.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DefHigh.Name = "DefHigh";
            this.DefHigh.Size = new System.Drawing.Size(45, 22);
            this.DefHigh.TabIndex = 226;
            this.DefHigh.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(119, 112);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(19, 13);
            this.label114.TabIndex = 244;
            this.label114.Text = "～";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(119, 147);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(19, 13);
            this.label115.TabIndex = 245;
            this.label115.Text = "～";
            // 
            // AtkHigh
            // 
            this.AtkHigh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtkHigh.Location = new System.Drawing.Point(139, 107);
            this.AtkHigh.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.AtkHigh.Name = "AtkHigh";
            this.AtkHigh.Size = new System.Drawing.Size(45, 22);
            this.AtkHigh.TabIndex = 224;
            this.AtkHigh.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // abilityType
            // 
            this.abilityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityType.FormattingEnabled = true;
            this.abilityType.Items.AddRange(new object[] {
            "Any",
            "Ability 0",
            "Ability 1"});
            this.abilityType.Location = new System.Drawing.Point(249, 144);
            this.abilityType.Name = "abilityType";
            this.abilityType.Size = new System.Drawing.Size(113, 21);
            this.abilityType.TabIndex = 233;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(925, 348);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 25);
            this.search.TabIndex = 220;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // L_mezapa
            // 
            this.L_mezapa.Location = new System.Drawing.Point(190, 75);
            this.L_mezapa.Name = "L_mezapa";
            this.L_mezapa.Size = new System.Drawing.Size(57, 20);
            this.L_mezapa.TabIndex = 255;
            this.L_mezapa.Text = "Nature";
            this.L_mezapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // natureType
            // 
            this.natureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.natureType.FormattingEnabled = true;
            this.natureType.Items.AddRange(new object[] {
            "Any",
            "Adamant",
            "Brave",
            "Bold",
            "Calm",
            "Careful",
            "Hasty",
            "Impish",
            "Jolly",
            "Lonely",
            "Mild",
            "Modest",
            "Naive",
            "Naughty",
            "Quiet",
            "Rash",
            "Relaxed",
            "Sassy",
            "Timid",
            "Gentle",
            "Lax",
            "Bashful",
            "Docile",
            "Hardy",
            "Quirky",
            "Serious"});
            this.natureType.Location = new System.Drawing.Point(249, 75);
            this.natureType.Name = "natureType";
            this.natureType.Size = new System.Drawing.Size(113, 21);
            this.natureType.TabIndex = 254;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(207, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 257;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(278, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 259;
            this.label2.Text = "SID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(233, 225);
            this.id.Mask = "00000";
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(39, 20);
            this.id.TabIndex = 260;
            this.id.Text = "0";
            this.id.ValidatingType = typeof(int);
            // 
            // sid
            // 
            this.sid.Location = new System.Drawing.Point(323, 225);
            this.sid.Mask = "00000";
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(39, 20);
            this.sid.TabIndex = 261;
            this.sid.Text = "0";
            this.sid.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 262;
            this.button1.Text = "Physical";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 263;
            this.button2.Text = "Special";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 264;
            this.button3.Text = "6 IV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 265;
            this.button4.Text = "Default";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 622);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_mezapa);
            this.Controls.Add(this.natureType);
            this.Controls.Add(this.Shiny_Check);
            this.Controls.Add(this.L_ball);
            this.Controls.Add(this.hiddenpower);
            this.Controls.Add(this.genderType);
            this.Controls.Add(this.L_sex);
            this.Controls.Add(this.L_ability);
            this.Controls.Add(this.L_search_S);
            this.Controls.Add(this.L_search_D);
            this.Controls.Add(this.L_search_C);
            this.Controls.Add(this.L_search_B);
            this.Controls.Add(this.L_search_A);
            this.Controls.Add(this.L_search_H);
            this.Controls.Add(this.SpeHigh);
            this.Controls.Add(this.HPLow);
            this.Controls.Add(this.label109);
            this.Controls.Add(this.AtkLow);
            this.Controls.Add(this.DefLow);
            this.Controls.Add(this.SpDHigh);
            this.Controls.Add(this.SpALow);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.SpDLow);
            this.Controls.Add(this.SpeLow);
            this.Controls.Add(this.SpAHigh);
            this.Controls.Add(this.label112);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.HPHigh);
            this.Controls.Add(this.DefHigh);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.AtkHigh);
            this.Controls.Add(this.abilityType);
            this.Controls.Add(this.search);
            this.Controls.Add(this.k_dataGridView);
            this.Name = "Form1";
            this.Text = "Colo Searcher";
            ((System.ComponentModel.ISupportInitialize)(this.k_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtkLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpDHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpALow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpDLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpAHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtkHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView k_dataGridView;
        private System.Windows.Forms.CheckBox Shiny_Check;
        private System.Windows.Forms.Label L_ball;
        private System.Windows.Forms.ComboBox hiddenpower;
        private System.Windows.Forms.ComboBox genderType;
        private System.Windows.Forms.Label L_sex;
        private System.Windows.Forms.Label L_ability;
        private System.Windows.Forms.Label L_search_S;
        private System.Windows.Forms.Label L_search_D;
        private System.Windows.Forms.Label L_search_C;
        private System.Windows.Forms.Label L_search_B;
        private System.Windows.Forms.Label L_search_A;
        private System.Windows.Forms.Label L_search_H;
        private System.Windows.Forms.NumericUpDown SpeHigh;
        private System.Windows.Forms.NumericUpDown HPLow;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.NumericUpDown AtkLow;
        private System.Windows.Forms.NumericUpDown DefLow;
        private System.Windows.Forms.NumericUpDown SpDHigh;
        private System.Windows.Forms.NumericUpDown SpALow;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.NumericUpDown SpDLow;
        private System.Windows.Forms.NumericUpDown SpeLow;
        private System.Windows.Forms.NumericUpDown SpAHigh;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.NumericUpDown HPHigh;
        private System.Windows.Forms.NumericUpDown DefHigh;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.NumericUpDown AtkHigh;
        private System.Windows.Forms.ComboBox abilityType;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label L_mezapa;
        private System.Windows.Forms.ComboBox natureType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox id;
        private System.Windows.Forms.MaskedTextBox sid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

