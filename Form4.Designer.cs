
namespace vacc
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboGen = new System.Windows.Forms.ComboBox();
            this.Age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboDose = new System.Windows.Forms.ComboBox();
            this.regbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.resetbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gov = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.emailtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(332, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "VACCINATION CENTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(271, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "REGISTER FOR VACCINATION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Blue;
            this.name.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(12, 256);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(217, 46);
            this.name.TabIndex = 3;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "FULL NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(294, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "NATIONAL ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(313, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "HOW MANY DOSAGES TAKEN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(22, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "VACCINATED (YES/NO)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(544, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "PASSWORD";
            // 
            // passtxt
            // 
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passtxt.HintForeColor = System.Drawing.Color.Empty;
            this.passtxt.HintText = "";
            this.passtxt.isPassword = false;
            this.passtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.passtxt.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.passtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passtxt.LineThickness = 3;
            this.passtxt.Location = new System.Drawing.Point(549, 257);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(217, 46);
            this.passtxt.TabIndex = 18;
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passtxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.passtxt.Validating += new System.ComponentModel.CancelEventHandler(this.passtxt_Validating);
            // 
            // id
            // 
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.id.HintForeColor = System.Drawing.Color.Empty;
            this.id.HintText = "";
            this.id.isPassword = false;
            this.id.LineFocusedColor = System.Drawing.Color.Blue;
            this.id.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.id.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.id.LineThickness = 3;
            this.id.Location = new System.Drawing.Point(290, 256);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(217, 46);
            this.id.TabIndex = 19;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.OnValueChanged += new System.EventHandler(this.id_OnValueChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            this.id.Validating += new System.ComponentModel.CancelEventHandler(this.id_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(395, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "AGE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(22, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "GENDER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(689, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Governorate";
            // 
            // comboGen
            // 
            this.comboGen.BackColor = System.Drawing.Color.DarkBlue;
            this.comboGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboGen.FormattingEnabled = true;
            this.comboGen.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.comboGen.Location = new System.Drawing.Point(26, 394);
            this.comboGen.Name = "comboGen";
            this.comboGen.Size = new System.Drawing.Size(133, 28);
            this.comboGen.TabIndex = 24;
            // 
            // Age
            // 
            this.Age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Age.HintForeColor = System.Drawing.Color.Empty;
            this.Age.HintText = "";
            this.Age.isPassword = false;
            this.Age.LineFocusedColor = System.Drawing.Color.Blue;
            this.Age.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.Age.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Age.LineThickness = 3;
            this.Age.Location = new System.Drawing.Point(340, 372);
            this.Age.Margin = new System.Windows.Forms.Padding(4);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(217, 46);
            this.Age.TabIndex = 25;
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Age.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            this.Age.Validating += new System.ComponentModel.CancelEventHandler(this.Age_Validating);
            // 
            // comboDose
            // 
            this.comboDose.BackColor = System.Drawing.Color.DarkBlue;
            this.comboDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboDose.FormattingEnabled = true;
            this.comboDose.Items.AddRange(new object[] {
            "1 ",
            "2 "});
            this.comboDose.Location = new System.Drawing.Point(389, 562);
            this.comboDose.Name = "comboDose";
            this.comboDose.Size = new System.Drawing.Size(133, 28);
            this.comboDose.TabIndex = 29;
            // 
            // regbtn
            // 
            this.regbtn.ActiveBorderThickness = 1;
            this.regbtn.ActiveCornerRadius = 20;
            this.regbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.regbtn.ActiveForecolor = System.Drawing.Color.White;
            this.regbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.regbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.regbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regbtn.BackgroundImage")));
            this.regbtn.ButtonText = "Register";
            this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.regbtn.IdleBorderThickness = 1;
            this.regbtn.IdleCornerRadius = 20;
            this.regbtn.IdleFillColor = System.Drawing.Color.White;
            this.regbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.regbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.regbtn.Location = new System.Drawing.Point(182, 652);
            this.regbtn.Margin = new System.Windows.Forms.Padding(5);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(170, 54);
            this.regbtn.TabIndex = 32;
            this.regbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.ActiveBorderThickness = 1;
            this.backbtn.ActiveCornerRadius = 20;
            this.backbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.backbtn.ActiveForecolor = System.Drawing.Color.White;
            this.backbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.backbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.ButtonText = "Back";
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.backbtn.IdleBorderThickness = 1;
            this.backbtn.IdleCornerRadius = 20;
            this.backbtn.IdleFillColor = System.Drawing.Color.White;
            this.backbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.backbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.backbtn.Location = new System.Drawing.Point(689, 652);
            this.backbtn.Margin = new System.Windows.Forms.Padding(5);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(170, 54);
            this.backbtn.TabIndex = 33;
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.ActiveBorderThickness = 1;
            this.resetbtn.ActiveCornerRadius = 20;
            this.resetbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.resetbtn.ActiveForecolor = System.Drawing.Color.White;
            this.resetbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.resetbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.resetbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetbtn.BackgroundImage")));
            this.resetbtn.ButtonText = "Reset";
            this.resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.resetbtn.IdleBorderThickness = 1;
            this.resetbtn.IdleCornerRadius = 20;
            this.resetbtn.IdleFillColor = System.Drawing.Color.White;
            this.resetbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.resetbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.resetbtn.Location = new System.Drawing.Point(421, 652);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(5);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(170, 54);
            this.resetbtn.TabIndex = 34;
            this.resetbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // gov
            // 
            this.gov.BackColor = System.Drawing.Color.DarkBlue;
            this.gov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gov.FormattingEnabled = true;
            this.gov.Items.AddRange(new object[] {
            "Alexandria",
            "Aswan",
            "Asyut",
            "Beheira",
            "Beni Suef",
            "Cairo ",
            "Dakahlia",
            "Damietta",
            "Faiyum",
            "Gharbia",
            "Giza",
            "Ismailia ",
            "Kafr El Sheikh",
            "Luxor ",
            "Matruh",
            "Minya ",
            "Monufia ",
            "New Valley ",
            "North Sinai ",
            "Port Said ",
            "Qalyubia ",
            "Qena ",
            "Red Sea ",
            "Sharqia ",
            "Sohag ",
            "South Sinai ",
            "Suez"});
            this.gov.Location = new System.Drawing.Point(689, 389);
            this.gov.Name = "gov";
            this.gov.Size = new System.Drawing.Size(133, 28);
            this.gov.TabIndex = 35;
            this.gov.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(907, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.checkedListBox1.Location = new System.Drawing.Point(58, 543);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(127, 48);
            this.checkedListBox1.TabIndex = 39;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(684, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "CATEGORY";
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.DarkBlue;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Medical Sector",
            "Chronic Disease",
            "None"});
            this.comboCategory.Location = new System.Drawing.Point(687, 563);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(133, 28);
            this.comboCategory.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(802, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 42;
            this.label12.Text = "EMAIL";
            // 
            // emailtxt
            // 
            this.emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.emailtxt.HintForeColor = System.Drawing.Color.Empty;
            this.emailtxt.HintText = "";
            this.emailtxt.isPassword = false;
            this.emailtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailtxt.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.emailtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailtxt.LineThickness = 3;
            this.emailtxt.Location = new System.Drawing.Point(807, 257);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(217, 46);
            this.emailtxt.TabIndex = 43;
            this.emailtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailtxt.Validating += new System.ComponentModel.CancelEventHandler(this.emailtxt_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1057, 712);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gov);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.comboDose);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.comboGen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboGen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Age;
        private System.Windows.Forms.ComboBox comboDose;
        private Bunifu.Framework.UI.BunifuThinButton2 regbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 backbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 resetbtn;
        private System.Windows.Forms.ComboBox gov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailtxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}