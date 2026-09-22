using System.Data.OleDb;


namespace coursework_progect1
{
    public partial class Тест : Form
    {
        int counter = 1; // счётчик
        int point = 0;
        int select = 0;
        int Question_counter = 1;

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TestDB.mdb;"; // нахождение файла
        private OleDbConnection myConnection;
        public Тест()
        {
            InitializeComponent();

            if (Globali.i == 1) { counter = 1; }
            else if (Globali.i == 2) { counter = 21; } //СВЕРИТЬ С БАЗОЙ ПОСЛЕ ИЗМЕНЕНИЙ!!!
            else if (Globali.i == 3) { counter = 41; }

            myConnection = new OleDbConnection(connectString);
            myConnection.Open(); // открытие базы данных

            OleDbCommand command = new OleDbCommand("SELECT QuestionText FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            label1.Text = command.ExecuteScalar().ToString(); // вывод первого вопроса 

            OleDbCommand answerA = new OleDbCommand("SELECT AnswerA FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton1.Text = answerA.ExecuteScalar().ToString(); // вывод первого ответа A
            OleDbCommand answerB = new OleDbCommand("SELECT AnswerB FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton2.Text = answerB.ExecuteScalar().ToString(); // вывод первого ответа B
            OleDbCommand answerC = new OleDbCommand("SELECT AnswerC FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton3.Text = answerC.ExecuteScalar().ToString(); // вывод первого ответа C
            OleDbCommand answerD = new OleDbCommand("SELECT AnswerD FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton4.Text = answerD.ExecuteScalar().ToString(); // вывод первого ответа D
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Question_counter++;
            if (Question_counter == 20)
            {
                button1.Visible = false;
                button2.Visible = true;
            }

            OleDbCommand cmdCorrect = new // Подсчёт правильных ответов 
            OleDbCommand("SELECT CorrectAnswer FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            string ansver_correct_db = cmdCorrect.ExecuteScalar().ToString();
            if (ansver_correct_db == select.ToString()) { point++; }



            counter++;

            OleDbCommand command = new OleDbCommand("SELECT QuestionText FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            label1.Text = command.ExecuteScalar().ToString(); // смена вопроса


            OleDbCommand answerA = new OleDbCommand("SELECT AnswerA FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton1.Text = answerA.ExecuteScalar().ToString(); // вывод ответа A
            OleDbCommand answerB = new OleDbCommand("SELECT AnswerB FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton2.Text = answerB.ExecuteScalar().ToString(); // вывод ответа B
            OleDbCommand answerC = new OleDbCommand("SELECT AnswerC FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton3.Text = answerC.ExecuteScalar().ToString(); // вывод ответа C
            OleDbCommand answerD = new OleDbCommand("SELECT AnswerD FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            radioButton4.Text = answerD.ExecuteScalar().ToString(); // вывод ответа D




            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { select = 1; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { select = 2; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { select = 3; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { select = 4; }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { select = 5; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question_counter++;
            if (Question_counter == 21)
            {
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                button2.Visible = false;
                label3.Visible = true;
            }

            OleDbCommand cmdCorrect = new
            OleDbCommand("SELECT CorrectAnswer FROM Questions WHERE QuestionID = " + counter + "AND SubjectID = " + Globali.i, myConnection);
            string ansver_correct_db = cmdCorrect.ExecuteScalar().ToString();
            if (ansver_correct_db == select.ToString()) { point++; }


            if (point <= 10) { label3.Text = "Ваша оценка - 2. Кол-во набранных баллов - " + point; }
            else if (point <= 15) { label3.Text = "Ваша оценка - 3. Кол-во набранных баллов - " + point; }
            else if (point <= 18) { label3.Text = "Ваша оценка - 4. Кол-во набранных баллов - " + point; }
            else if (point <= 20) { label3.Text = "Ваша оценка - 5. Кол-во набранных баллов - " + point; }


            MessageBox.Show("Тест окончен", "Поздравляем!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
