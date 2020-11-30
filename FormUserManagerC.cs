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
    public partial class FormUserManagerC : FormBasic
    {
        readonly ModelDBMall db = new ModelDBMall();

        public FormUserManagerC()
        {
            InitializeComponent();

            formTitle = "Меню менеджера 'C'";
        }

        private void FormUserManagerC_Load(object sender, EventArgs e)
        {
            dataGridViewMalls.DataSource = db.Malls.ToList();
        }

        private void TextBoxFilterStatus_TextChanged(object sender, EventArgs e)
        {
            string n = (string)textBoxFilterStatus.Text;
            int nLenght = n.Length;
            var colProd = db.Malls.Where(x => x.Status.Substring(0, nLenght) == n);
            dataGridViewMalls.DataSource = colProd.ToList();
        }

        private void TextBoxFilterCity_TextChanged(object sender, EventArgs e)
        {
            string n = (string)textBoxFilterCity.Text;
            int nLenght = n.Length;
            var colProd = db.Malls.Where(x => x.City.Substring(0, nLenght) == n);
            dataGridViewMalls.DataSource = colProd.ToList();
        }

        private void ButtonDeleteSelectedRow_Click(object sender, EventArgs e)
        {
            Mall selectedMall = (Mall)mallBindingSource.Current;

            string str = $"Вы действительно ходите удалить - {selectedMall.Mall_name}";

            DialogResult dr = MessageBox.Show(str, "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                db.Malls.Remove(selectedMall);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show($"ТЦ - {selectedMall.Mall_name} успешно удален!");
                    dataGridViewMalls.Update();
                    dataGridViewMalls.Refresh();
                    mallBindingSource.DataSource = null;
                    mallBindingSource.DataSource = db.Malls.ToList<Mall>();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка - " + ex.Message);
                }
            }
        }

        private void ButtonSortByCity_Click(object sender, EventArgs e)
        {
            int CitySort(Mall city1, Mall city2)
            {
                return String.Compare(city1.City, city2.City);
            }

            List<Mall> prod = (List<Mall>)mallBindingSource.List;
            prod.Sort(CitySort);
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = prod;
        }

        private void ButtonSortByStatus_Click(object sender, EventArgs e)
        {
            int StatusSort(Mall status1, Mall status2)
            {
                return String.Compare(status1.Status, status2.Status);
            }

            List<Mall> prod = (List<Mall>)mallBindingSource.List;
            prod.Sort(StatusSort);
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = prod;
        }

        private void ButtonShowInterfaceMall_Click(object sender, EventArgs e)
        {
            FormMallInterface formMI = new FormMallInterface();
            formMI.Show();
            Program.PreviousForm = this;
            this.Hide();
        }
    }
}
