namespace VigenèreCipher
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
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.EncryptTextLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyTextbox = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.RadioButton();
            this.DecryptBtn = new System.Windows.Forms.RadioButton();
            this.FunctionGroupbox = new System.Windows.Forms.GroupBox();
            this.RotGroupbox = new System.Windows.Forms.GroupBox();
            this.RotOneBtn = new System.Windows.Forms.RadioButton();
            this.RotZeroBtn = new System.Windows.Forms.RadioButton();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeTextbox = new System.Windows.Forms.TextBox();
            this.FunctionGroupbox.SuspendLayout();
            this.RotGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(97, 9);
            this.InputTextbox.MaxLength = 60;
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(420, 20);
            this.InputTextbox.TabIndex = 0;
            // 
            // EncryptTextLbl
            // 
            this.EncryptTextLbl.AutoSize = true;
            this.EncryptTextLbl.Location = new System.Drawing.Point(35, 12);
            this.EncryptTextLbl.Name = "EncryptTextLbl";
            this.EncryptTextLbl.Size = new System.Drawing.Size(55, 13);
            this.EncryptTextLbl.TabIndex = 1;
            this.EncryptTextLbl.Text = "Input Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encryption Key";
            // 
            // KeyTextbox
            // 
            this.KeyTextbox.Location = new System.Drawing.Point(97, 42);
            this.KeyTextbox.MaxLength = 10;
            this.KeyTextbox.Name = "KeyTextbox";
            this.KeyTextbox.Size = new System.Drawing.Size(420, 20);
            this.KeyTextbox.TabIndex = 3;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.AutoSize = true;
            this.EncryptBtn.Checked = true;
            this.EncryptBtn.Location = new System.Drawing.Point(6, 17);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(61, 17);
            this.EncryptBtn.TabIndex = 4;
            this.EncryptBtn.TabStop = true;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.CheckedChanged += new System.EventHandler(this.FunctionBtn_CheckedChanged);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.AutoSize = true;
            this.DecryptBtn.Location = new System.Drawing.Point(82, 17);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(62, 17);
            this.DecryptBtn.TabIndex = 5;
            this.DecryptBtn.TabStop = true;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.CheckedChanged += new System.EventHandler(this.FunctionBtn_CheckedChanged);
            // 
            // FunctionGroupbox
            // 
            this.FunctionGroupbox.Controls.Add(this.EncryptBtn);
            this.FunctionGroupbox.Controls.Add(this.DecryptBtn);
            this.FunctionGroupbox.Location = new System.Drawing.Point(523, 6);
            this.FunctionGroupbox.Name = "FunctionGroupbox";
            this.FunctionGroupbox.Size = new System.Drawing.Size(149, 44);
            this.FunctionGroupbox.TabIndex = 6;
            this.FunctionGroupbox.TabStop = false;
            this.FunctionGroupbox.Text = "Function";
            // 
            // RotGroupbox
            // 
            this.RotGroupbox.Controls.Add(this.RotOneBtn);
            this.RotGroupbox.Controls.Add(this.RotZeroBtn);
            this.RotGroupbox.Location = new System.Drawing.Point(523, 56);
            this.RotGroupbox.Name = "RotGroupbox";
            this.RotGroupbox.Size = new System.Drawing.Size(149, 44);
            this.RotGroupbox.TabIndex = 7;
            this.RotGroupbox.TabStop = false;
            this.RotGroupbox.Text = "Rotation";
            // 
            // RotOneBtn
            // 
            this.RotOneBtn.AutoSize = true;
            this.RotOneBtn.Location = new System.Drawing.Point(82, 18);
            this.RotOneBtn.Name = "RotOneBtn";
            this.RotOneBtn.Size = new System.Drawing.Size(54, 17);
            this.RotOneBtn.TabIndex = 1;
            this.RotOneBtn.TabStop = true;
            this.RotOneBtn.Text = "ROT1";
            this.RotOneBtn.UseVisualStyleBackColor = true;
            this.RotOneBtn.CheckedChanged += new System.EventHandler(this.RotationBtn_CheckChanged);
            // 
            // RotZeroBtn
            // 
            this.RotZeroBtn.AutoSize = true;
            this.RotZeroBtn.Checked = true;
            this.RotZeroBtn.Location = new System.Drawing.Point(8, 18);
            this.RotZeroBtn.Name = "RotZeroBtn";
            this.RotZeroBtn.Size = new System.Drawing.Size(54, 17);
            this.RotZeroBtn.TabIndex = 0;
            this.RotZeroBtn.TabStop = true;
            this.RotZeroBtn.Text = "ROT0";
            this.RotZeroBtn.UseVisualStyleBackColor = true;
            this.RotZeroBtn.CheckedChanged += new System.EventHandler(this.RotationBtn_CheckChanged);
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(97, 75);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(420, 20);
            this.OutputTextbox.TabIndex = 8;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(523, 106);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(149, 23);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time to Process";
            // 
            // TimeTextbox
            // 
            this.TimeTextbox.Location = new System.Drawing.Point(96, 108);
            this.TimeTextbox.Name = "TimeTextbox";
            this.TimeTextbox.Size = new System.Drawing.Size(420, 20);
            this.TimeTextbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 139);
            this.Controls.Add(this.TimeTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.RotGroupbox);
            this.Controls.Add(this.FunctionGroupbox);
            this.Controls.Add(this.KeyTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptTextLbl);
            this.Controls.Add(this.InputTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vigenère Engineer";
            this.FunctionGroupbox.ResumeLayout(false);
            this.FunctionGroupbox.PerformLayout();
            this.RotGroupbox.ResumeLayout(false);
            this.RotGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Label EncryptTextLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyTextbox;
        private System.Windows.Forms.RadioButton EncryptBtn;
        private System.Windows.Forms.RadioButton DecryptBtn;
        private System.Windows.Forms.GroupBox FunctionGroupbox;
        private System.Windows.Forms.GroupBox RotGroupbox;
        private System.Windows.Forms.RadioButton RotOneBtn;
        private System.Windows.Forms.RadioButton RotZeroBtn;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeTextbox;
    }
}

