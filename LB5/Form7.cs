using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void ремонтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workshopDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.Цех". При необходимости она может быть перемещена или удалена.
            this.цехTableAdapter.Fill(this.workshopDataSet.Цех);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.workshopDataSet.Ремонт);

        }

        private void цехDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm4 = new Form3();
            frm4.Show();
            this.Hide();
        }
    }
}
