namespace ProjectEvaluation
{
    partial class Demographics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demographics));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxYearLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.questionLabel2 = new System.Windows.Forms.Label();
            this.questionLabel1 = new System.Windows.Forms.Label();
            this.cbOptionYearLevel1 = new System.Windows.Forms.ComboBox();
            this.cbOptionYearLevel2 = new System.Windows.Forms.ComboBox();
            this.cbOptionYearLevel3 = new System.Windows.Forms.ComboBox();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbIrregular = new System.Windows.Forms.RadioButton();
            this.comboBoxWorkOption = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 34);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(372, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(81, 43);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(306, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(81, 74);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(306, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(46, 108);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAge.TabIndex = 6;
            this.comboBoxAge.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxAge_DrawItem);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(202, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Year Level";
            // 
            // comboBoxYearLevel
            // 
            this.comboBoxYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxYearLevel.FormattingEnabled = true;
            this.comboBoxYearLevel.Location = new System.Drawing.Point(267, 108);
            this.comboBoxYearLevel.Name = "comboBoxYearLevel";
            this.comboBoxYearLevel.Size = new System.Drawing.Size(120, 21);
            this.comboBoxYearLevel.TabIndex = 8;
            this.comboBoxYearLevel.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxYearLevel_DrawItem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Are you a regular or irregular student?";
            // 
            // questionLabel2
            // 
            this.questionLabel2.AutoSize = true;
            this.questionLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.questionLabel2.Location = new System.Drawing.Point(12, 217);
            this.questionLabel2.Name = "questionLabel2";
            this.questionLabel2.Size = new System.Drawing.Size(236, 13);
            this.questionLabel2.TabIndex = 10;
            this.questionLabel2.Text = "Are you a working or non-working student?";
            // 
            // questionLabel1
            // 
            this.questionLabel1.AutoSize = true;
            this.questionLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel1.Location = new System.Drawing.Point(12, 163);
            this.questionLabel1.Name = "questionLabel1";
            this.questionLabel1.Size = new System.Drawing.Size(337, 13);
            this.questionLabel1.TabIndex = 15;
            this.questionLabel1.Text = "Select Year Level if other subjects are taken in different Year Level";
            // 
            // cbOptionYearLevel1
            // 
            this.cbOptionYearLevel1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOptionYearLevel1.FormattingEnabled = true;
            this.cbOptionYearLevel1.Location = new System.Drawing.Point(15, 179);
            this.cbOptionYearLevel1.Name = "cbOptionYearLevel1";
            this.cbOptionYearLevel1.Size = new System.Drawing.Size(120, 21);
            this.cbOptionYearLevel1.TabIndex = 16;
            this.cbOptionYearLevel1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbOptionYearLevel1_DrawItem);
            // 
            // cbOptionYearLevel2
            // 
            this.cbOptionYearLevel2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOptionYearLevel2.FormattingEnabled = true;
            this.cbOptionYearLevel2.Location = new System.Drawing.Point(141, 179);
            this.cbOptionYearLevel2.Name = "cbOptionYearLevel2";
            this.cbOptionYearLevel2.Size = new System.Drawing.Size(120, 21);
            this.cbOptionYearLevel2.TabIndex = 17;
            this.cbOptionYearLevel2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbOptionYearLevel2_DrawItem);
            // 
            // cbOptionYearLevel3
            // 
            this.cbOptionYearLevel3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOptionYearLevel3.FormattingEnabled = true;
            this.cbOptionYearLevel3.Location = new System.Drawing.Point(267, 179);
            this.cbOptionYearLevel3.Name = "cbOptionYearLevel3";
            this.cbOptionYearLevel3.Size = new System.Drawing.Size(120, 21);
            this.cbOptionYearLevel3.TabIndex = 18;
            this.cbOptionYearLevel3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbOptionYearLevel3_DrawItem);
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(224, 143);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 19;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            this.rbRegular.CheckedChanged += new System.EventHandler(this.rbRegular_CheckedChanged);
            // 
            // rbIrregular
            // 
            this.rbIrregular.AutoSize = true;
            this.rbIrregular.Location = new System.Drawing.Point(292, 143);
            this.rbIrregular.Name = "rbIrregular";
            this.rbIrregular.Size = new System.Drawing.Size(63, 17);
            this.rbIrregular.TabIndex = 20;
            this.rbIrregular.TabStop = true;
            this.rbIrregular.Text = "Irregular";
            this.rbIrregular.UseVisualStyleBackColor = true;
            this.rbIrregular.CheckedChanged += new System.EventHandler(this.rbIrregular_CheckedChanged);
            // 
            // comboBoxWorkOption
            // 
            this.comboBoxWorkOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxWorkOption.FormattingEnabled = true;
            this.comboBoxWorkOption.Location = new System.Drawing.Point(254, 212);
            this.comboBoxWorkOption.Name = "comboBoxWorkOption";
            this.comboBoxWorkOption.Size = new System.Drawing.Size(133, 21);
            this.comboBoxWorkOption.TabIndex = 21;
            this.comboBoxWorkOption.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxWorkOption_DrawItem);
            // 
            // Demographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 306);
            this.Controls.Add(this.comboBoxWorkOption);
            this.Controls.Add(this.rbIrregular);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.questionLabel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbOptionYearLevel3);
            this.Controls.Add(this.cbOptionYearLevel2);
            this.Controls.Add(this.cbOptionYearLevel1);
            this.Controls.Add(this.questionLabel1);
            this.Controls.Add(this.comboBoxYearLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Demographics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxYearLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label questionLabel2;
        private System.Windows.Forms.Label questionLabel1;
        private System.Windows.Forms.ComboBox cbOptionYearLevel1;
        private System.Windows.Forms.ComboBox cbOptionYearLevel2;
        private System.Windows.Forms.ComboBox cbOptionYearLevel3;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.RadioButton rbIrregular;
        private System.Windows.Forms.ComboBox comboBoxWorkOption;
    }
}