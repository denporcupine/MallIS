
namespace MallIS
{
    partial class FormRegistration
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LabelForm
            // 
            this.LabelForm.Location = new System.Drawing.Point(492, 29);
            this.LabelForm.Size = new System.Drawing.Size(0, 25);
            this.LabelForm.Text = "";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(417, 151);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(154, 20);
            this.textBoxFIO.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(417, 196);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(417, 238);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(417, 280);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(154, 20);
            this.textBoxRole.TabIndex = 6;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(417, 370);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(154, 20);
            this.textBoxGender.TabIndex = 8;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(337, 153);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(43, 18);
            this.labelFIO.TabIndex = 9;
            this.labelFIO.Text = "ФИО";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(331, 196);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 18);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(318, 240);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 18);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Пароль";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(336, 282);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(44, 18);
            this.labelRole.TabIndex = 12;
            this.labelRole.Text = "Роль";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(309, 326);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(71, 18);
            this.labelPhoneNumber.TabIndex = 13;
            this.labelPhoneNumber.Text = "Телефон";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(344, 372);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(36, 18);
            this.labelGender.TabIndex = 14;
            this.labelGender.Text = "Пол";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateUser.Location = new System.Drawing.Point(417, 424);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(154, 45);
            this.buttonCreateUser.TabIndex = 15;
            this.buttonCreateUser.Text = "Создать пользователя";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(417, 327);
            this.maskedTextBoxPhoneNumber.Mask = "+7(99##)000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 16;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxFIO);
            this.Name = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.Controls.SetChildIndex(this.textBoxFIO, 0);
            this.Controls.SetChildIndex(this.textBoxLogin, 0);
            this.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.Controls.SetChildIndex(this.textBoxRole, 0);
            this.Controls.SetChildIndex(this.textBoxGender, 0);
            this.Controls.SetChildIndex(this.labelFIO, 0);
            this.Controls.SetChildIndex(this.labelLogin, 0);
            this.Controls.SetChildIndex(this.labelPassword, 0);
            this.Controls.SetChildIndex(this.labelRole, 0);
            this.Controls.SetChildIndex(this.labelPhoneNumber, 0);
            this.Controls.SetChildIndex(this.labelGender, 0);
            this.Controls.SetChildIndex(this.buttonCreateUser, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxPhoneNumber, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
    }
}