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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE table_name SET Фамилия = '" + textBox2.Text + "',Имя = '" + textBox3.Text + "',Отчество = '" + textBox4.Text + ",Должность = '" + textBox5.Text + "',ВН = '" + textBox6.Text + "',ГорН = '" + textBox7.Text + "' WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!", "Внимание!");
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
