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
    public partial class FormBasic : Form
    {
        // Переменная истории переходов
        
        public static Form PreviousForm = null;
        // Переменная названия форм. В неё будут передаваться названия дочерних форм
        protected string formTitle;

        public FormBasic()
        {
            InitializeComponent();
        }

        private void FormBasic_Load(object sender, EventArgs e)
        {
            // Переменная для названия форм
            LabelForm.Text = formTitle;

            // Указание координат для отрисовки названия форм
            LabelForm.Left = (this.PanelHeader.Width - LabelForm.Width) / 2;
            LabelForm.Top = (this.PanelHeader.Height - LabelForm.Height) / 2;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            // Сохранение формы в иторию переходов
            Form previousForm = Program.PreviousForm;
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            // Диалоговое окно подтверждения выхода
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
