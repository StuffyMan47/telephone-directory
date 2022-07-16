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
    public partial class Form8 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb";
        private OleDbConnection myConnection;
        public Form8()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string dolzhnost = textBox1.Text;
            string query = "Select Фамилия, Имя, Отчество, Должность, ВН, ГорН FROM table_name WHERE Должность LIKE '%" + dolzhnost + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }
    }
}
