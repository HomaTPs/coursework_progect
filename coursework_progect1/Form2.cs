using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace coursework_progect1
{



    public partial class Регистриция : Form
    {
        private void ToggleTheme()
        {
            if (Global.isFirstImage)
            {
                pictureBox1.Image = Properties.Resources.icons8_sun_50;
                this.BackColor = Color.FromArgb(36, 37, 38);
                button1.BackColor = Color.FromArgb(188, 152, 234);
                label1.ForeColor = Color.White; label2.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White; radioButton2.ForeColor = Color.White; radioButton3.ForeColor = Color.White;
                textBox1.BackColor = Color.Black; textBox1.ForeColor = Color.White;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.icons8_sun_50__1_;
                this.BackColor = Color.FromArgb(255, 255, 255);
                button1.BackColor = Color.FromArgb(135, 206, 250);
                label1.ForeColor = Color.Black; label2.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black; radioButton2.ForeColor = Color.Black; radioButton3.ForeColor = Color.Black;
                textBox1.BackColor = Color.White; textBox1.ForeColor = Color.Black;
            }
            Global.isFirstImage = !Global.isFirstImage;
        }

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
                Global_UserName.UserName = textBox1.Text;
                if (a > 0)
                {
                    IsAuthorized = true;
                    this.Close();
                }
                else MessageBox.Show("Заполните все поля", "Ошибка");

            }
        }

        // Смена темы оформления
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
