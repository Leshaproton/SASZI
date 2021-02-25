using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace CourseWork
{
    public partial class Form1 : Form
    {
        string ConnStr = @"Data Source=DESKTOP-OMJFGSG;Initial Catalog=CourseWork;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FillStudent(); //Вызов метода
                FillWork(); //Вызов метода
                MessageBox.Show("Подключение к базе данных выполнено");
            }
            catch (Exception exep)
            {
                MessageBox.Show("Подключение к базе данных не выполнено! " + exep.Message);
            }

        }
        private void FillStudent()
        {
            string SqlText = "SELECT * FROM [Студенты]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Студенты]");
            dataGridView1.DataSource = ds.Tables["[Студенты]"].DefaultView;
        }
        private void FillWork()
        {
            // сформировать строку SQL-запроса
            string SqlText = "SELECT * FROM [Курсовые_работы]";
            int index;
            string ID_work;
            index = dataGridView1.CurrentRow.Index;
            ID_work = dataGridView1[0, index].Value.ToString();
            SqlText = "SELECT * FROM [Курсовые_работы],[Студенты] WHERE (([Курсовые_работы].[ID_student] = ";
            SqlText = SqlText + ID_work + ") AND ([Студенты].[ID_student] = " + ID_work + "))";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Курсовые_работы]");
            dataGridView2.DataSource = ds.Tables["[Курсовые_работы]"].DefaultView;
        }

        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn; // экземпляр класса типа SqlConnection
            SqlCommand cmd;
            // выделение памяти с инициализацией строки соединения с базой данных
            cn = new SqlConnection(ConnStr);
            cn.Open(); // открыть источник данных
            cmd = cn.CreateCommand(); // задать SQL-команду
            cmd.CommandText = SqlText; // задать командную строку
            cmd.ExecuteNonQuery(); // выполнить SQL-команду
            cn.Close(); // закрыть источник данных
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.RowCount;
            int row = dataGridView1.CurrentRow.Index;
            if (n != (row + 1)) // Проверка, был ли клик на последней строке
                FillStudent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SqlText = "INSERT INTO [Студенты] ([ID_student],[ФИО_студента]," +
                "[Дата_рождения],[Телефон],[Паспорт],[Курс],[Адрес_регистрации]," +
                "[Студ_билет],[Направление_подготовки],[ID_metodist]," +
                "[Номер_зачетной_книжки],[ID_group]) " +
                "VALUES (1, 'ФИО_студента-01','Дата_рождения-01','Телефон-01','Паспорт-01','Курс-01'," +
                "'Адрес_регистраци-01','Студ_билет-01','Направление_подготовки-01'," +
                "'1','Номер_зачетной_книжки-01','1') ";
            Form2 f = new Form2(); // создать экземпляр окна
            if (f.ShowDialog() == DialogResult.OK)
            {
                // сформировать SQL-строку
                SqlText = "INSERT INTO [Студенты] ([ID_student],[ФИО_студента]," +
                "[Дата_рождения],[Телефон],[Паспорт],[Курс],[Адрес_регистрации]," +
                "[Студ_билет],[Направление_подготовки],[ID_metodist]," +
                "[Номер_зачетной_книжки],[ID_group]) VALUES (";
                SqlText = SqlText + "\'" + f.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox2.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox3.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox4.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox5.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox6.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox7.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox8.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox9.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox10.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox11.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox12.Text + "\') ";
                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
                FillStudent();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string SqlText = "SELECT * FROM [Список_предметов]";
            Form9 f = new Form9();
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Список_предметов]");
            f.dataGridView1.DataSource = ds.Tables["[Список_предметов]"].DefaultView;
            f.ShowDialog();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index, n;
            string name_student, ID_work;
            string SqlText = "DELETE FROM [Курсовые_работы] WHERE [Курсовые_работы].[ID_work] = ";
            n = dataGridView2.Rows.Count;
            if (n == 1) return;
            Form6 f = new Form6();
            index = dataGridView2.CurrentRow.Index;
            ID_work = Convert.ToString(dataGridView2[0, index].Value);
            // сформировать SQL-команду
            SqlText = SqlText + ID_work;
            // заполнить информационную справку в окне Form5
            name_student = Convert.ToString(dataGridView2[1, index].Value);
            f.label2.Text = ID_work + " - " + name_student;
            if (f.ShowDialog() == DialogResult.OK) // вывести форму
            {
                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
                FillWork();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index, index_src, n;
            string SqlText = "UPDATE [Курсовые_работы] SET ";
            string ID_work, ID_spec, theme, dateOut, dateIn, times, mark;
            string nameStudent;
            n = dataGridView2.Rows.Count;
            if (n == 1) return;
            Form7 f = new Form7();
            // заполнить форму данными перед открытием
            index = dataGridView2.CurrentRow.Index;
            ID_work = dataGridView2[0, index].Value.ToString();
            ID_spec = dataGridView2[1, index].Value.ToString();
            theme = dataGridView2[2, index].Value.ToString();
            dateOut = dataGridView2[3, index].Value.ToString();
            dateIn = dataGridView2[4, index].Value.ToString();
            times = dataGridView2[5, index].Value.ToString();
            mark = dataGridView2[6, index].Value.ToString();
            index_src = dataGridView1.CurrentRow.Index;
            nameStudent = dataGridView1[1, index_src].Value.ToString();
            f.label2.Text = nameStudent;
            f.textBox1.Text = ID_work;
            f.textBox2.Text = ID_spec;
            f.textBox3.Text = theme;
            f.textBox4.Text = dateOut;
            f.textBox5.Text = dateIn;
            f.textBox6.Text = times;
            f.textBox7.Text = mark;

            if (f.ShowDialog() == DialogResult.OK)
            {
                ID_work = f.textBox1.Text;
                ID_spec = f.textBox2.Text;
                theme = f.textBox3.Text;
                dateOut = f.textBox4.Text;
                dateIn = f.textBox5.Text;
                times = f.textBox1.Text;
                mark = f.textBox7.Text;

                SqlText += "ID_work = \'" + ID_work + "\', ID_spec = \'" + ID_spec + "\', Тема_работы = \'" + theme + "\', Дата_выдачи = \'" + dateOut + "\', Время_на_выполнение = \'" + dateIn + "\', Количество_попыток = \'" + times + "\', Оценка = \'" + mark + "\'";
                SqlText += "WHERE [Курсовые_работы].[ID_work] = " + ID_work;
                MyExecuteNonQuery(SqlText);
                FillWork();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string SqlText = "INSERT INTO [Курсовые_работы] ([ID_student],[ID_work]," +
                "[ID_spec],[Тема_работы],[Дата_выдачи],[Время_на_выполнение],[Количество_попыток], [Оценка]) " +
                "VALUES (1, '1','1','Тема_работы-01','Дата_выдачи-01','Время_на_выполнение-01'," +
                "'Количество_попыток-01', 'Оценка-01') ";
            int index; // номер выделенной строки в таблице Студент
            string ID_student;
            // string name;
            Form4 f = new Form4();

            index = dataGridView1.CurrentRow.Index;
            ID_student = Convert.ToString(dataGridView1[0, index].Value);
            // name = Convert.ToString(dataGridView1[1, index].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {

                SqlText = "INSERT INTO [Курсовые_работы] ([ID_student],[ID_work],[ID_spec]," +
                    "[Тема_работы],[Дата_выдачи],[Время_на_выполнение]," +
                    "[Количество_попыток], [Оценка]) VALUES (";
                // Сформировать значения переменной SqlText
                SqlText = SqlText + ID_student + ", "; 
                SqlText = SqlText + "\'" + f.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox2.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox3.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox4.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox5.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox6.Text + "\', ";
                SqlText = SqlText + "\'" + f.textBox7.Text + "\') ";
                MyExecuteNonQuery(SqlText);
                // вывести таблицу Курсовая работа
                FillWork();

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string SqlText = "SELECT [Студенты].[ID_student],[ФИО_студента], [Курсовые_работы].[Тема_работы],[Оценка],[ID_work] " +
                "FROM[Студенты]" +
                "RIGHT JOIN[Курсовые_работы]" +
                "ON[Курсовые_работы].[ID_student] = [Студенты].[ID_student]" +
                "ORDER BY[Курсовые_работы].[Оценка] DESC; ";
            Form10 f = new Form10();
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Студенты]");
            f.dataGridView1.DataSource = ds.Tables["[Студенты]"].DefaultView;
            f.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string SqlText = "SELECT * FROM [Преподаватели]";
            Form8 f = new Form8();
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Преподаватели]");
            f.dataGridView1.DataSource = ds.Tables["[Преподаватели]"].DefaultView;
            f.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Студенты] SET ";
            string num_student, name_student, bd_student, phone_student,
            passport_student, course_student, adr_student,
            pas_student, spec_student, numMetodist_student, examBook_student, numGroup_student;
            // проверка, есть ли вообще записи в таблице Студент
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            Form3 f = new Form3();
            // заполнить форму данными перед открытием
            index = dataGridView1.CurrentRow.Index;
            num_student = dataGridView1[0, index].Value.ToString();
            name_student = dataGridView1[1, index].Value.ToString();
            bd_student = dataGridView1[2, index].Value.ToString();
            phone_student = dataGridView1[3, index].Value.ToString();
            passport_student = dataGridView1[4, index].Value.ToString();
            course_student = dataGridView1[5, index].Value.ToString();
            adr_student = dataGridView1[6, index].Value.ToString();
            pas_student = dataGridView1[7, index].Value.ToString();
            spec_student = dataGridView1[8, index].Value.ToString();
            numMetodist_student = dataGridView1[9, index].Value.ToString();
            examBook_student = dataGridView1[10, index].Value.ToString();
            numGroup_student = dataGridView1[11, index].Value.ToString();
            f.textBox1.Text = num_student;
            f.textBox2.Text = name_student;
            f.textBox3.Text = bd_student;
            f.textBox4.Text = phone_student;
            f.textBox5.Text = passport_student;
            f.textBox6.Text = course_student;
            f.textBox7.Text = adr_student;
            f.textBox8.Text = pas_student;
            f.textBox9.Text = spec_student;
            f.textBox10.Text = numMetodist_student;
            f.textBox11.Text = examBook_student;
            f.textBox12.Text = numGroup_student;

            if (f.ShowDialog() == DialogResult.OK)
            {
                num_student = f.textBox1.Text;
                name_student = f.textBox2.Text;
                bd_student = f.textBox3.Text;
                phone_student = f.textBox4.Text;
                passport_student = f.textBox5.Text;
                course_student = f.textBox6.Text;
                adr_student = f.textBox7.Text;
                pas_student = f.textBox8.Text;
                spec_student = f.textBox9.Text;
                numMetodist_student = f.textBox10.Text;
                examBook_student = f.textBox11.Text;
                numGroup_student = f.textBox12.Text;

                SqlText += "ID_student = \'" + num_student +
                "\', ФИО_студента = '" + name_student +
                "\', Дата_рождения = '" + bd_student +
                "\', Телефон = '" + phone_student +
                "\', Паспорт = '" + passport_student +
                "\', Курс = '" + course_student +
                "\', Адрес_регистрации = '" + adr_student +
                "\', Студ_билет = '" + pas_student +
                "\', Направление_подготовки = '" + spec_student +
                "\', ID_metodist = '" + numMetodist_student +
                "\', Номер_зачетной_книжки = '" + examBook_student +
                "\', ID_group = '" + numGroup_student + "\' ";
                SqlText += "WHERE [Студенты].[ID_student] = " + name_student;
                MyExecuteNonQuery(SqlText);
                FillStudent();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index, n;
            string ID_student;
            string name_student, bd_student;
            string SqlText = "DELETE FROM [Студенты] WHERE [Студенты].[ID_student] = ";
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            Form5 f = new Form5();
            index = dataGridView1.CurrentRow.Index;
            ID_student = Convert.ToString(dataGridView1[0, index].Value);
            // сформировать SQL-команду
            SqlText = SqlText + ID_student;
            // заполнить информационную справку в окне Form5
            name_student = Convert.ToString(dataGridView1[1, index].Value);
            bd_student = Convert.ToString(dataGridView1[2, index].Value);
            f.label2.Text = ID_student + " - " + name_student + " - " + bd_student;
            if (f.ShowDialog() == DialogResult.OK) // вывести форму
            {
                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
                // отобразить таблицу Source
                FillStudent();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            int row = dataGridView1.CurrentRow.Index;
            if (n != (row + 1)) // Проверка, был ли клик на последней строке
                FillStudent();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.RowCount;
            int row = dataGridView1.CurrentRow.Index;
            if (n != (row + 1)) // Проверка, был ли клик на последней строке
                FillStudent();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            // на основе выделенной строки в таблице Студент вывести таблицу Курсовая работа
            // определить количество строк в dataGridView1
            int n = dataGridView1.RowCount;
            int row = dataGridView1.CurrentRow.Index;
            if (n != (row + 1)) // Проверка, был ли клик на последней строке
                FillWork();

        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.RowCount;
            int row = dataGridView1.CurrentRow.Index;
            if (n != (row + 1)) // Проверка, был ли клик на последней строке
                FillWork();

        }

    }
}
