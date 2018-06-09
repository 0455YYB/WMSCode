namespace WMS.Login
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userName = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.But_login = new System.Windows.Forms.Button();
            this.But_cancel = new System.Windows.Forms.Button();
            this.Chb_remember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(64, 47);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(60, 16);
            this.userName.TabIndex = 0;
            this.userName.Text = "账 号:";
            // 
            // passWord
            // 
            this.passWord.AutoSize = true;
            this.passWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passWord.Location = new System.Drawing.Point(64, 89);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(60, 16);
            this.passWord.TabIndex = 1;
            this.passWord.Text = "密 码:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // But_login
            // 
            this.But_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_login.Location = new System.Drawing.Point(58, 153);
            this.But_login.Name = "But_login";
            this.But_login.Size = new System.Drawing.Size(75, 32);
            this.But_login.TabIndex = 4;
            this.But_login.Text = "登 录";
            this.But_login.UseVisualStyleBackColor = true;
            // 
            // But_cancel
            // 
            this.But_cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_cancel.Location = new System.Drawing.Point(178, 153);
            this.But_cancel.Name = "But_cancel";
            this.But_cancel.Size = new System.Drawing.Size(75, 32);
            this.But_cancel.TabIndex = 5;
            this.But_cancel.Text = "取 消";
            this.But_cancel.UseVisualStyleBackColor = true;
            // 
            // Chb_remember
            // 
            this.Chb_remember.AutoSize = true;
            this.Chb_remember.Location = new System.Drawing.Point(67, 124);
            this.Chb_remember.Name = "Chb_remember";
            this.Chb_remember.Size = new System.Drawing.Size(96, 16);
            this.Chb_remember.TabIndex = 6;
            this.Chb_remember.Text = "记住账号密码";
            this.Chb_remember.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 232);
            this.Controls.Add(this.Chb_remember);
            this.Controls.Add(this.But_cancel);
            this.Controls.Add(this.But_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label passWord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button But_login;
        private System.Windows.Forms.Button But_cancel;
        private System.Windows.Forms.CheckBox Chb_remember;
    }
}

