﻿namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPwG = new Label();
            chkLowerCase = new CheckBox();
            chkUpperCase = new CheckBox();
            chkNumbers = new CheckBox();
            chkSymbols = new CheckBox();
            lblCharacters = new Label();
            numCharacters = new NumericUpDown();
            btnGenerate = new Button();
            txtGeneratedPwd = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCharacters).BeginInit();
            SuspendLayout();
            // 
            // lblPwG
            // 
            lblPwG.AutoSize = true;
            lblPwG.Font = new Font("Colonna MT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPwG.Location = new Point(22, 40);
            lblPwG.Name = "lblPwG";
            lblPwG.Size = new Size(551, 51);
            lblPwG.TabIndex = 0;
            lblPwG.Text = "PASSWORD GENERATOR";
            // 
            // chkLowerCase
            // 
            chkLowerCase.AutoSize = true;
            chkLowerCase.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLowerCase.Location = new Point(90, 204);
            chkLowerCase.Name = "chkLowerCase";
            chkLowerCase.Size = new Size(171, 41);
            chkLowerCase.TabIndex = 1;
            chkLowerCase.Text = "Lower Case";
            chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            chkUpperCase.AutoSize = true;
            chkUpperCase.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkUpperCase.Location = new Point(90, 260);
            chkUpperCase.Name = "chkUpperCase";
            chkUpperCase.Size = new Size(173, 41);
            chkUpperCase.TabIndex = 2;
            chkUpperCase.Text = "Upper Case";
            chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Font = new Font("Segoe UI", 20F);
            chkNumbers.Location = new Point(335, 260);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(144, 41);
            chkNumbers.TabIndex = 4;
            chkNumbers.Text = "Numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            chkSymbols.AutoSize = true;
            chkSymbols.Font = new Font("Segoe UI", 20F);
            chkSymbols.Location = new Point(335, 204);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(135, 41);
            chkSymbols.TabIndex = 3;
            chkSymbols.Text = "Symbols";
            chkSymbols.UseVisualStyleBackColor = true;
            // 
            // lblCharacters
            // 
            lblCharacters.AutoSize = true;
            lblCharacters.Font = new Font("Segoe UI", 20F);
            lblCharacters.Location = new Point(90, 131);
            lblCharacters.Name = "lblCharacters";
            lblCharacters.Size = new Size(282, 37);
            lblCharacters.TabIndex = 5;
            lblCharacters.Text = "Number of Characters:";
            // 
            // numCharacters
            // 
            numCharacters.Font = new Font("Segoe UI", 20F);
            numCharacters.Location = new Point(393, 131);
            numCharacters.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            numCharacters.Name = "numCharacters";
            numCharacters.Size = new Size(70, 43);
            numCharacters.TabIndex = 6;
            numCharacters.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 20F);
            btnGenerate.Location = new Point(168, 333);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(234, 56);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "GENERATE";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtGeneratedPwd
            // 
            txtGeneratedPwd.Font = new Font("Segoe UI", 20F);
            txtGeneratedPwd.Location = new Point(68, 452);
            txtGeneratedPwd.Name = "txtGeneratedPwd";
            txtGeneratedPwd.Size = new Size(446, 43);
            txtGeneratedPwd.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(194, 412);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 9;
            label1.Text = "Your password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(591, 537);
            Controls.Add(label1);
            Controls.Add(txtGeneratedPwd);
            Controls.Add(btnGenerate);
            Controls.Add(numCharacters);
            Controls.Add(lblCharacters);
            Controls.Add(chkNumbers);
            Controls.Add(chkSymbols);
            Controls.Add(chkUpperCase);
            Controls.Add(chkLowerCase);
            Controls.Add(lblPwG);
            Name = "Form1";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)numCharacters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPwG;
        private CheckBox chkLowerCase;
        private CheckBox chkUpperCase;
        private CheckBox chkNumbers;
        private CheckBox chkSymbols;
        private Label lblCharacters;
        private NumericUpDown numCharacters;
        private Button btnGenerate;
        private TextBox txtGeneratedPwd;
        private Label label1;
    }
}
