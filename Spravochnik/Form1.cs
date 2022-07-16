using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Spravochnik
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb";
        public int authorizationValue;
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.table_name". При необходимости она может быть перемещена или удалена.
            this.table_nameTableAdapter.Fill(this.databaseDataSet.table_name);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorizationValue = 1;
            Form5 form5 = new Form5();
            form5.Owner = this;
            form5.Show();
            form5.authorizationValue = authorizationValue;
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorizationValue = 2;
            Form5 form5 = new Form5();
            form5.Owner = this;
            form5.Show();
            form5.authorizationValue = authorizationValue;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorizationValue = 3;
            Form5 form5 = new Form5();
            form5.Owner = this;
            form5.Show();
            form5.authorizationValue = authorizationValue;
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Телефонный справочник МСАЖКХ РТ", "Внимание!");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.table_nameTableAdapter.Fill(this.databaseDataSet.table_name);
            MessageBox.Show("Телефонный справочник МСАЖКХ РТ обновлен", "Внимание!");
        }

        private void поискПоДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Owner = this;
            form8.Show();
        }

        public void AuthorizationValue()
        {
            int authorizationValue1 = authorizationValue;
        }
    }
}