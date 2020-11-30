
namespace MallIS
{
    partial class FormMain
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
            this.ButtonAuthorization = new System.Windows.Forms.Button();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelForm
            // 
            this.LabelForm.Location = new System.Drawing.Point(492, 29);
            this.LabelForm.Size = new System.Drawing.Size(0, 25);
            this.LabelForm.Text = "";
            // 
            // ButtonAuthorization
            // 
            this.ButtonAuthorization.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuthorization.Location = new System.Drawing.Point(279, 293);
            this.ButtonAuthorization.Name = "ButtonAuthorization";
            this.ButtonAuthorization.Size = new System.Drawing.Size(180, 30);
            this.ButtonAuthorization.TabIndex = 2;
            this.ButtonAuthorization.Text = "Войти";
            this.ButtonAuthorization.UseVisualStyleBackColor = true;
            this.ButtonAuthorization.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegistration.Location = new System.Drawing.Point(526, 293);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(180, 30);
            this.ButtonRegistration.TabIndex = 3;
            this.ButtonRegistration.Text = "Зарегистрироваться";
            this.ButtonRegistration.UseVisualStyleBackColor = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.ButtonAuthorization);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.ButtonAuthorization, 0);
            this.Controls.SetChildIndex(this.ButtonRegistration, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAuthorization;
        private System.Windows.Forms.Button ButtonRegistration;
    }
}

