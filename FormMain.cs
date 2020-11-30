using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MallIS
{
    public partial class FormMain : FormBasic
    {
        public FormMain()
        {
            InitializeComponent();
            // Название формы
            formTitle = "Главное меню";

            // Вычисление положения кнопок регистрации и авторизации
            ButtonAuthorization.Left = (this.Width - ButtonAuthorization.Width) / 2;
            ButtonAuthorization.Top = (this.Height - ButtonAuthorization.Height) / 2;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Удаление кнопки "Назад", так как с главной формы некуда вернуться
            ButtonBack.Dispose();
        }

        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {
            FormAuthorization frmAuth = new FormAuthorization();
            frmAuth.Show();
            Program.PreviousForm = this;
            this.Hide();
        }
    }
}
