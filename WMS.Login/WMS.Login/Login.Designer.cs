namespace WMS.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.userName = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.Label();
            this.Tex_name = new System.Windows.Forms.TextBox();
            this.Tex_password = new System.Windows.Forms.TextBox();
            this.But_login = new System.Windows.Forms.Button();
            this.But_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
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
            this.passWord.BackColor = System.Drawing.Color.Transparent;
            this.passWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passWord.Location = new System.Drawing.Point(64, 89);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(60, 16);
            this.passWord.TabIndex = 1;
            this.passWord.Text = "密 码:";
            // 
            // Tex_name
            // 
            this.Tex_name.Location = new System.Drawing.Point(133, 46);
            this.Tex_name.Name = "Tex_name";
            this.Tex_name.Size = new System.Drawing.Size(100, 21);
            this.Tex_name.TabIndex = 2;
            // 
            // Tex_password
            // 
            this.Tex_password.Location = new System.Drawing.Point(133, 87);
            this.Tex_password.Name = "Tex_password";
            this.Tex_password.Size = new System.Drawing.Size(100, 21);
            this.Tex_password.TabIndex = 3;
            // 
            // But_login
            // 
            this.But_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_login.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.But_login.Location = new System.Drawing.Point(63, 130);
            this.But_login.Name = "But_login";
            this.But_login.Size = new System.Drawing.Size(75, 32);
            this.But_login.TabIndex = 4;
            this.But_login.Text = "登 录";
            this.But_login.UseVisualStyleBackColor = true;
            // 
            // But_cancel
            // 
            this.But_cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_cancel.Location = new System.Drawing.Point(163, 130);
            this.But_cancel.Name = "But_cancel";
            this.But_cancel.Size = new System.Drawing.Size(75, 32);
            this.But_cancel.TabIndex = 5;
            this.But_cancel.Text = "取 消";
            this.But_cancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WMS.Login.Properties.Resources.企业进销存登录窗体;
            this.ClientSize = new System.Drawing.Size(313, 188);
            this.Controls.Add(this.But_cancel);
            this.Controls.Add(this.But_login);
            this.Controls.Add(this.Tex_password);
            this.Controls.Add(this.Tex_name);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label passWord;
        private System.Windows.Forms.TextBox Tex_name;
        private System.Windows.Forms.TextBox Tex_password;
        private System.Windows.Forms.Button But_login;
        private System.Windows.Forms.Button But_cancel;
    }
}

