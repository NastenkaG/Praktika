using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie4._5
{
    public partial class WinDataSourcesWizard : Form
    {
        public WinDataSourcesWizard()
        {
            InitializeComponent();
        }

        private void WinDataSourcesWizard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rBProductDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.rBProductDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rBProductDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.rBProductDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rBProductDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.rBProductDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rBProductDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.rBProductDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rBProductDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.rBProductDataSet.Поставщики);

        }
    }
}
