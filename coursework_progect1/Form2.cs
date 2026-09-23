using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coursework_progect1
{

    

    public partial class Регистриция : Form
    {
        public bool IsAuthorized { get; private set; } = false;
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TestDB.mdb;";
        private OleDbConnection myConnection;
        public Регистриция()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT SubjectName FROM Subjects WHERE SubjectID = 1";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteScalar();
            radioButton1.Text = command.ExecuteScalar().ToString();

            OleDbCommand cmd2 = new OleDbCommand("SELECT SubjectName FROM Subjects WHERE SubjectID = 2", myConnection);
            radioButton2.Text = cmd2.ExecuteScalar().ToString();

            OleDbCommand cmd3 = new OleDbCommand("SELECT SubjectName FROM Subjects WHERE SubjectID = 3", myConnection);
            radioButton3.Text = cmd3.ExecuteScalar().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (radioButton1.Checked)
            {
                Globali.i = 1;
                a = 1;
            }
            else if (radioButton2.Checked)
            {
                Globali.i = 2;
                a = 2;
            }
            else if (radioButton3.Checked)
            {
                Globali.i = 3;
                a = 3;
            }
            else MessageBox.Show("Выберите предмет!", "Ошибка");

            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните Имя и Фамилию", "Ошибка");
            }
            else
            {
                if (a > 0)
                {
                    IsAuthorized = true;
                    this.Close();
                }
                else MessageBox.Show("Заполните все поля", "Ошибка");

            }
        }
    }
}
