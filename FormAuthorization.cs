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
    public partial class FormAuthorization : FormBasic
    {
        public static Employee Employee { get; set; }
        ModelDBMall db = new ModelDBMall();

        public int failCounter = 1;
        public bool showCaptcha = false;
        private string text = String.Empty;

        public FormAuthorization()
        {
            InitializeComponent();

            formTitle = "Авторизация";
            pictureBoxCaptcha.Hide();
            buttonUpdateCaptcha.Hide();
            textBoxCaptcha.Hide();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = this.CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }

        private void PictureBoxButtonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                pictureBoxButtonShowPassword.Image = Properties.Resources.eye_slash_solid;
            }
            else if (!textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBoxButtonShowPassword.Image = Properties.Resources.eye_solid;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if ((textBoxLogin.Text == "") || (textBoxPassword.Text == ""))
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }

            Employee empl = db.Employees.FirstOrDefault(x => x.Login.ToLower() == textBoxLogin.Text.ToLower());

            if ((showCaptcha == false) || (showCaptcha == true))
            {
                if ((empl != null) && (empl.Password == textBoxPassword.Text))
                {
                    Employee = empl;

                    // Сохранение этой формы в историю переходов
                    Program.PreviousForm = this;

                    if (empl.Role != null)
                    {
                        if (empl.Role == "Администратор")
                        {
                            FormUserAdministrator f = new FormUserAdministrator();
                            f.Show();
                            this.Hide();
                        }
                        else if (empl.Role == "Менеджер А")
                        {
                            FormUserManagerA f = new FormUserManagerA();
                            f.Show();
                            this.Hide();
                        }
                        else if (empl.Role == "Менеджер С")
                        {
                            FormUserManagerC f = new FormUserManagerC();
                            f.Show();
                            this.Hide();
                        }
                        else if (empl.Role == "Удален")
                        {
                            MessageBox.Show("Данный пользователь был удален");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Роли {empl.Role} нет в системе");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с такими логином и паролем не зарегистрирован");
                    failCounter++;
                    if (failCounter == 4)
                    {
                        showCaptcha = true;
                        pictureBoxCaptcha.Show();
                        buttonUpdateCaptcha.Show();
                        textBoxCaptcha.Show();
                        return;
                    }
                    return;
                }
            }
            else if ((showCaptcha == true) && (textBoxCaptcha.Text == this.text))
            {
                MessageBox.Show("Верно!");
                pictureBoxCaptcha.Image = this.CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
            }
            else
            {
                MessageBox.Show("Ошибка!");
                pictureBoxCaptcha.Image = this.CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
            }
        }

        public void ClearForm()
        {
            showCaptcha = false;
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            // Генерация капчи
            Bitmap result = new Bitmap(Width, Height);

            int Xpos = 10;
            int Ypos = 10;

            Brush[] colors = {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green,
                Brushes.Yellow,
                Brushes.White,
                Brushes.Tomato,
                Brushes.Sienna,
                Brushes.Pink };

            Pen[] colorpens = {
                Pens.Black,
                Pens.Red,
                Pens.RoyalBlue,
                Pens.Green,
                Pens.Yellow,
                Pens.White,
                Pens.Tomato,
                Pens.Sienna,
                Pens.Pink };

            // Делаем случайный стиль текста
            FontStyle[] fontstyle = {
                FontStyle.Bold,
                FontStyle.Italic,
                FontStyle.Regular,
                FontStyle.Strikeout,
                FontStyle.Underline};

            // Добавление различных углов поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            // Укажем где рисовать
            Graphics placeFormCaptcha = Graphics.FromImage((Image)result);

            // Фон картинки
            placeFormCaptcha.Clear(Color.Gray);

            // Случайный угол поворота текста
            placeFormCaptcha.RotateTransform(rnd.Next(rotate.Length));

            // Генерация текста
            text = String.Empty;
            string ALF = "7890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            // Отрисовка сгенирируемый текст
            placeFormCaptcha.DrawString(text,
            new Font("Arial", 16, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            // Создание линий из углов
            placeFormCaptcha.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            placeFormCaptcha.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, Height - 1),
            new Point(Width - 1, 0));

            // Создание фона
            for (int i = 0; i < Width; ++i)
            {
                for (int j = 0; j < Height; ++j)
                {
                    if (rnd.Next() % 20 == 0)
                    {
                        result.SetPixel(i, j, Color.White);
                    }
                }
            }

            return result;
        }

        private void ButtonUpdateCaptcha_Click(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = this.CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }
    }
}
