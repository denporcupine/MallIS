
namespace MallIS
{
    partial class FormAuthorization
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxButtonShowPassword = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.buttonUpdateCaptcha = new System.Windows.Forms.Button();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelForm
            // 
            this.LabelForm.Location = new System.Drawing.Point(492, 29);
            this.LabelForm.Size = new System.Drawing.Size(0, 25);
            this.LabelForm.Text = "";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(417, 253);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(417, 307);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(332, 255);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 18);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(319, 309);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 18);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // pictureBoxButtonShowPassword
            // 
            this.pictureBoxButtonShowPassword.Image = global::MallIS.Properties.Resources.eye_solid;
            this.pictureBoxButtonShowPassword.Location = new System.Drawing.Point(577, 307);
            this.pictureBoxButtonShowPassword.Name = "pictureBoxButtonShowPassword";
            this.pictureBoxButtonShowPassword.Size = new System.Drawing.Size(28, 20);
            this.pictureBoxButtonShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxButtonShowPassword.TabIndex = 6;
            this.pictureBoxButtonShowPassword.TabStop = false;
            this.pictureBoxButtonShowPassword.Click += new System.EventHandler(this.PictureBoxButtonShowPassword_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.Location = new System.Drawing.Point(432, 364);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(120, 30);
            this.ButtonLogin.TabIndex = 7;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(417, 87);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(154, 97);
            this.pictureBoxCaptcha.TabIndex = 8;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // buttonUpdateCaptcha
            // 
            this.buttonUpdateCaptcha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateCaptcha.Location = new System.Drawing.Point(577, 154);
            this.buttonUpdateCaptcha.Name = "buttonUpdateCaptcha";
            this.buttonUpdateCaptcha.Size = new System.Drawing.Size(96, 30);
            this.buttonUpdateCaptcha.TabIndex = 9;
            this.buttonUpdateCaptcha.Text = "Обновить";
            this.buttonUpdateCaptcha.UseVisualStyleBackColor = true;
            this.buttonUpdateCaptcha.Click += new System.EventHandler(this.ButtonUpdateCaptcha_Click);
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(417, 190);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(154, 20);
            this.textBoxCaptcha.TabIndex = 10;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.buttonUpdateCaptcha);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.pictureBoxButtonShowPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormAuthorization";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            this.Controls.SetChildIndex(this.textBoxLogin, 0);
            this.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.Controls.SetChildIndex(this.labelLogin, 0);
            this.Controls.SetChildIndex(this.labelPassword, 0);
            this.Controls.SetChildIndex(this.pictureBoxButtonShowPassword, 0);
            this.Controls.SetChildIndex(this.ButtonLogin, 0);
            this.Controls.SetChildIndex(this.pictureBoxCaptcha, 0);
            this.Controls.SetChildIndex(this.buttonUpdateCaptcha, 0);
            this.Controls.SetChildIndex(this.textBoxCaptcha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxButtonShowPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.Button buttonUpdateCaptcha;
        private System.Windows.Forms.TextBox textBoxCaptcha;
    }
}