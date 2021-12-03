﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie4._1
{
    public partial class WinBD : Form
    {
        public WinBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader myReader;
            string CustomerString;
            oleDbConnection1.Open();
            myReader = oleDbCommand1.ExecuteReader();
            while (myReader.Read())
            {
                //Извлечь список имен и фамилий из таблицы
                //Заказчики и выполнить их контактенацию
                CustomerString = myReader[1].ToString() + " " +
                    myReader[2].ToString();
                //Добавить результат в список ListBox
                listBox1.Items.Add(CustomerString);
            }
            myReader.Close();
            oleDbConnection1.Close();
        }
    }
}
