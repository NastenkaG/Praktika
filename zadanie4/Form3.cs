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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private BindingSource sotrBindingSourse;
        private void Form3_Load(object sender, EventArgs e)
        {
            
            // Загрузка таблицы данными:
            товарыTableAdapter1.Fill(rBProductDataSet11.Товары);
            // Создание BindingSource для таблицы Товары:
            sotrBindingSourse = new BindingSource(rBProductDataSet11, "Товары");
            // Настройка связывания для элементов TextBox:
            NametextBox.DataBindings.Add("Text", sotrBindingSourse, "Наименование");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSourse, "Цена"); 

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }
    }
}
