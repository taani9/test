using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test2DataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter1.Fill(this.test2DataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.testDataSet.Material);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FEA9AB");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (dataGridView1[1, i].Value.ToString() != textBox1.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;

                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (dataGridView1[1, i].Value.ToString() != textBox1.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;

                }
        }
    }
}
