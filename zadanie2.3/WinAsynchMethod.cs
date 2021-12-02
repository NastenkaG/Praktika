using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2._3
{
    public partial class WinAsynchMethod : Form
    {
        public WinAsynchMethod()
        {
            InitializeComponent();
        }

        private delegate int AsyncSumm (int a, int b);
        private int Summ (int a, int b)
        {
            System.Threading.Thread.Sleep (9000);
            return a + b;
        }
        private void CallBackMethod (IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                //преобразование типов данных
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summedelegate = new AsyncSumm (Summ);
            AsyncCallback cb = new AsyncCallback (CallBackMethod);
            summedelegate.BeginInvoke(a, b, cb, summedelegate);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
