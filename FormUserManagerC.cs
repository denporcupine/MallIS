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
        ModelDBMall db = new ModelDBMall();

        Mall mall = new Mall();

        public FormUserManagerC()
        {
            InitializeComponent();

            formTitle = "Меню менеджера 'C'";
        }

        private void FormUserManagerC_Load(object sender, EventArgs e)
        {
            dataGridViewMalls.DataSource = db.Malls.ToList();
        }

        private void textBoxFilterStatus_TextChanged(object sender, EventArgs e)
        {
            string n = (string)textBoxFilterStatus.Text;
            int nLenght = n.Length;
            var colProd = db.Malls.Where(x => x.Status.Substring(0, nLenght) == n);
            dataGridViewMalls.DataSource = colProd.ToList();
        }

        private void textBoxFilterCity_TextChanged(object sender, EventArgs e)
        {
            string n = (string)textBoxFilterCity.Text;
            int nLenght = n.Length;
            var colProd = db.Malls.Where(x => x.City.Substring(0, nLenght) == n);
            dataGridViewMalls.DataSource = colProd.ToList();
        }
    }
}
