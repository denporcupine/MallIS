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
    public partial class FormRegistration : FormBasic
    {
        readonly ModelDBMall db = new ModelDBMall();

        Employee empl = new Employee();

        public FormRegistration()
        {
            InitializeComponent();

            formTitle = "Регистрация";
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            if ((textBoxFIO.Text == "") ||
                (textBoxLogin.Text == "") ||
                (textBoxPassword.Text == "") ||
                (textBoxRole.Text == "") ||
                (maskedTextBoxPhoneNumber.Text == "") ||
                (textBoxGender.Text == ""))
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            else if ((textBoxRole.Text.Trim() != "Администратор") && (textBoxRole.Text.Trim() != "Менеджер С") && (textBoxRole.Text.Trim() != "Менеджер А"))
            {
                MessageBox.Show("Задана неверная роль");
            }
            else
            {
                Employee empl = new Employee
                {
                    FIO = textBoxFIO.Text.Trim(),
                    Login = textBoxLogin.Text.Trim(),
                    Password = textBoxPassword.Text.Trim(),
                    Role = textBoxRole.Text.Trim(),
                    Phone = maskedTextBoxPhoneNumber.Text.Trim(),
                    Gender = textBoxGender.Text.Trim()
                };
                try
                {
                    db.Employees.Add(empl);
                    db.SaveChanges();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.InnerException.Message);
                    return;
                }
                MessageBox.Show($"Пользователь {textBoxFIO.Text} {textBoxRole.Text} был создан");
            }

        }
    }
}
