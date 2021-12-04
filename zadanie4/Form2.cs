using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataView ПоставщикиDataView;

        private void button1_Click(object sender, EventArgs e)
        {
            //oleDbDataAdapter1.Fill(dataSet11.Поставщики);
            // Загрузка таблицы данными:
            поставщикиTableAdapter1.Fill(rBProductDataSet.Поставщики);
            // Настройка объекта DataView
            ПоставщикиDataView = new DataView(rBProductDataSet.Поставщики);
            // Настройка dataGridView для отображения данных
            dataGridView1.DataSource = ПоставщикиDataView;
            // Присвоения исходного порядка сортировки
            ПоставщикиDataView.Sort = "Поставщик";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ПоставщикиDataView.Sort = SortTextBox.Text;
            ПоставщикиDataView.RowFilter = FilterTextBox.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Exercise3 = new Form3();
            Exercise3.Show();
        }
    }
}
