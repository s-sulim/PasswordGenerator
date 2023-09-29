namespace PasswordGenerator
{
    partial class frmMain
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
            this.lbdPasswordDifficulty = new System.Windows.Forms.Label();
            this.cbPasswordDifficulty = new System.Windows.Forms.ComboBox();
            this.nudCharacters = new System.Windows.Forms.NumericUpDown();
            this.lbdCharactersAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGeneratedPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacters)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdPasswordDifficulty
            // 
            this.lbdPasswordDifficulty.AutoSize = true;
            this.lbdPasswordDifficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbdPasswordDifficulty.Location = new System.Drawing.Point(4, 0);
            this.lbdPasswordDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdPasswordDifficulty.Name = "lbdPasswordDifficulty";
            this.lbdPasswordDifficulty.Size = new System.Drawing.Size(199, 42);
            this.lbdPasswordDifficulty.TabIndex = 0;
            this.lbdPasswordDifficulty.Text = "Password difficulty:";
            this.lbdPasswordDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPasswordDifficulty
            // 
            this.cbPasswordDifficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPasswordDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasswordDifficulty.FormattingEnabled = true;
            this.cbPasswordDifficulty.Items.AddRange(new object[] {
            "Easy ",
            "Middle ",
            "Hard "});
            this.cbPasswordDifficulty.Location = new System.Drawing.Point(211, 4);
            this.cbPasswordDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.cbPasswordDifficulty.Name = "cbPasswordDifficulty";
            this.cbPasswordDifficulty.Size = new System.Drawing.Size(239, 36);
            this.cbPasswordDifficulty.TabIndex = 1;
            this.cbPasswordDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbPasswordDifficulty_SelectedIndexChanged);
            // 
            // nudCharacters
            // 
            this.nudCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCharacters.Location = new System.Drawing.Point(210, 65);
            this.nudCharacters.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudCharacters.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCharacters.Name = "nudCharacters";
            this.nudCharacters.Size = new System.Drawing.Size(241, 34);
            this.nudCharacters.TabIndex = 2;
            this.nudCharacters.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lbdCharactersAmount
            // 
            this.lbdCharactersAmount.AutoSize = true;
            this.lbdCharactersAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbdCharactersAmount.Location = new System.Drawing.Point(3, 62);
            this.lbdCharactersAmount.Name = "lbdCharactersAmount";
            this.lbdCharactersAmount.Size = new System.Drawing.Size(201, 42);
            this.lbdCharactersAmount.TabIndex = 3;
            this.lbdCharactersAmount.Text = "Characters:";
            this.lbdCharactersAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbGeneratedPassword
            // 
            this.tbGeneratedPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGeneratedPassword.Location = new System.Drawing.Point(210, 127);
            this.tbGeneratedPassword.Name = "tbGeneratedPassword";
            this.tbGeneratedPassword.ReadOnly = true;
            this.tbGeneratedPassword.Size = new System.Drawing.Size(241, 34);
            this.tbGeneratedPassword.TabIndex = 5;
            this.tbGeneratedPassword.TextChanged += new System.EventHandler(this.tbGeneratedPassword_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.59472F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.40528F));
            this.tableLayoutPanel1.Controls.Add(this.lbdPasswordDifficulty, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPasswordDifficulty, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudCharacters, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbGeneratedPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbdCharactersAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerate, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 230);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.Location = new System.Drawing.Point(210, 189);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(241, 38);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 329);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(568, 329);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacters)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbdPasswordDifficulty;
        private System.Windows.Forms.ComboBox cbPasswordDifficulty;
        private System.Windows.Forms.NumericUpDown nudCharacters;
        private System.Windows.Forms.Label lbdCharactersAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGeneratedPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGenerate;
    }
}

