namespace WJG
{
    partial class FormModifyPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txTextBoxOldpwd = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBoxNewpwd = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBoxCheckpwd = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "再来一次";
            // 
            // txTextBoxOldpwd
            // 
            this.txTextBoxOldpwd.BackColor = System.Drawing.Color.Transparent;
            this.txTextBoxOldpwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBoxOldpwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBoxOldpwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBoxOldpwd.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBoxOldpwd.Image = null;
            this.txTextBoxOldpwd.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBoxOldpwd.Location = new System.Drawing.Point(278, 120);
            this.txTextBoxOldpwd.Name = "txTextBoxOldpwd";
            this.txTextBoxOldpwd.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBoxOldpwd.PasswordChar = '\0';
            this.txTextBoxOldpwd.Required = false;
            this.txTextBoxOldpwd.Size = new System.Drawing.Size(180, 22);
            this.txTextBoxOldpwd.TabIndex = 3;
            // 
            // txTextBoxNewpwd
            // 
            this.txTextBoxNewpwd.BackColor = System.Drawing.Color.Transparent;
            this.txTextBoxNewpwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBoxNewpwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBoxNewpwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBoxNewpwd.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBoxNewpwd.Image = null;
            this.txTextBoxNewpwd.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBoxNewpwd.Location = new System.Drawing.Point(278, 186);
            this.txTextBoxNewpwd.Name = "txTextBoxNewpwd";
            this.txTextBoxNewpwd.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBoxNewpwd.PasswordChar = '\0';
            this.txTextBoxNewpwd.Required = false;
            this.txTextBoxNewpwd.Size = new System.Drawing.Size(180, 22);
            this.txTextBoxNewpwd.TabIndex = 4;
            // 
            // txTextBoxCheckpwd
            // 
            this.txTextBoxCheckpwd.BackColor = System.Drawing.Color.Transparent;
            this.txTextBoxCheckpwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBoxCheckpwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBoxCheckpwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBoxCheckpwd.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBoxCheckpwd.Image = null;
            this.txTextBoxCheckpwd.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBoxCheckpwd.Location = new System.Drawing.Point(278, 251);
            this.txTextBoxCheckpwd.Name = "txTextBoxCheckpwd";
            this.txTextBoxCheckpwd.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBoxCheckpwd.PasswordChar = '\0';
            this.txTextBoxCheckpwd.Required = false;
            this.txTextBoxCheckpwd.Size = new System.Drawing.Size(180, 22);
            this.txTextBoxCheckpwd.TabIndex = 5;
            // 
            // FormModeifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txTextBoxCheckpwd);
            this.Controls.Add(this.txTextBoxNewpwd);
            this.Controls.Add(this.txTextBoxOldpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormModeifyPwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBoxOldpwd;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBoxNewpwd;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBoxCheckpwd;
    }
}