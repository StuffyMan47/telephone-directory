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
    public partial class Form2 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }
    
        private void button1_Click(object sender, EventArgs e)
        {

            int kod = Convert.ToInt32(this.textBox1.Text);
            string Sruname = textBox2.Text;
            string Name = textBox3.Text;
            string Othcestvo = textBox4.Text;
            string Position = textBox5.Text;
            string Namber = textBox6.Text;
            string Mail = textBox7.Text;
            if (Sruname !="" && Name != "" && Othcestvo != "" && Position != "" && Namber != "" && Mail != "")
            {
                string query = "INSERT INTO table_name ([Код сотрудника], Фамилия, Имя, Отчество, Должность, ВН, ГорН) VALUES (" + kod + ",'" + Sruname + "','" + Name + "','" + Othcestvo + "','" + Position + "','" + Namber + "','" + Mail + "' )";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Контакт добавлен!", "Внимание!");
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание!");
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch !=8)
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
