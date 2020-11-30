
namespace MallIS
{
    partial class FormUserAdministrator
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
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelForm
            // 
            this.LabelForm.Location = new System.Drawing.Point(492, 29);
            this.LabelForm.Size = new System.Drawing.Size(0, 25);
            this.LabelForm.Text = "";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateUser.Location = new System.Drawing.Point(12, 318);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(120, 45);
            this.buttonCreateUser.TabIndex = 2;
            this.buttonCreateUser.Text = "Создать пользователя";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // FormUserAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonCreateUser);
            this.Name = "FormUserAdministrator";
            this.Text = "FormAdministrator";
            this.Controls.SetChildIndex(this.buttonCreateUser, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateUser;
    }
}