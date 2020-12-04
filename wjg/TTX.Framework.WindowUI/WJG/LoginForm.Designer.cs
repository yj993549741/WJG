namespace WJG
{
    partial class LoginForm
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
            this.skcclocksystemDataSet1 = new WJG.skcclocksystemDataSet();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.txTextBox2 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBox1 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSet1)).BeginInit();
            this.txGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skcclocksystemDataSet1
            // 
            this.skcclocksystemDataSet1.DataSetName = "skcclocksystemDataSet";
            this.skcclocksystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.txTextBox2);
            this.txGroupBox1.Controls.Add(this.txTextBox1);
            this.txGroupBox1.Controls.Add(this.label2);
            this.txGroupBox1.Controls.Add(this.label1);
            this.txGroupBox1.Controls.Add(this.txButton2);
            this.txGroupBox1.Controls.Add(this.txButton1);
            this.txGroupBox1.Location = new System.Drawing.Point(130, 69);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(550, 287);
            this.txGroupBox1.TabIndex = 12;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "欢迎登录";
            this.txGroupBox1.TextMargin = 6;
            // 
            // txTextBox2
            // 
            this.txTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox2.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox2.Image = null;
            this.txTextBox2.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox2.Location = new System.Drawing.Point(235, 143);
            this.txTextBox2.Name = "txTextBox2";
            this.txTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox2.PasswordChar = '*';
            this.txTextBox2.Required = false;
            this.txTextBox2.Size = new System.Drawing.Size(180, 22);
            this.txTextBox2.TabIndex = 2;
            // 
            // txTextBox1
            // 
            this.txTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox1.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox1.Image = null;
            this.txTextBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox1.Location = new System.Drawing.Point(235, 60);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox1.PasswordChar = '\0';
            this.txTextBox1.Required = false;
            this.txTextBox1.Size = new System.Drawing.Size(180, 22);
            this.txTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(172, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(172, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "用户名";
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(330, 198);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(100, 28);
            this.txButton2.TabIndex = 4;
            this.txButton2.Text = "退出";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.txButton2_Click);
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(121, 198);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 3;
            this.txButton1.Text = "登录";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txGroupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LoginForm";
            this.Text = "外加工人员管理系统";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skcclocksystemDataSet1)).EndInit();
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private skcclocksystemDataSet skcclocksystemDataSet1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox2;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
    }
}