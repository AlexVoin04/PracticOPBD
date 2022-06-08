using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDHotel
{
    public partial class Form1 : Form
    {
        public static int idmax;

        public void GetEmployees(string a, string b, string c)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DEKVKMF\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True"))
            {
                Con.Open();
                string query = "SELECT" +
                                "[Полное имя] = E.[Name] + ' ' + E.[Surname]," +
                                "[Отчество (если есть)] = [Patronymic]," +
                                "[Дата рождения] = IAE.[Born]," +
                                "[Номер телефона] = IAE.[Tel]," +
                                "[Серия паспорта] = IAE.[PasspSerries]," +
                                "[Номер паспорта] = IAE.[PasspNumber]," +
                                "[Должность] = P.[Post]," +
                                "[Оклад] = P.[Salary]" +
                                "FROM [Employees] AS E " +
                                "JOIN [EmployeeInformation] AS EI ON E.ID = EI.EmployeesID " +
                                "JOIN [InformationAboutEmployees] AS IAE ON EI.InformationAboutEmployeesID = IAE.ID " +
                                "JOIN[Posts] AS P ON IAE.PostsID = P.ID " +
                                $"{c} " +
                                $"ORDER BY E.[{a}] {b}";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                Con.Close();
                if (dt.Rows.Count != 0)
                {
                    Grid_Employees.Visible = true;
                    Grid_Employees.DataSource = dt;
                    Grid_Employees.Update();
                    Grid_Employees.Columns[0].Width = 173; // ФИ
                    Grid_Employees.Columns[1].Width = 150; // О
                    Grid_Employees.Columns[2].Width = 100; // ДР
                    Grid_Employees.Columns[3].Width = 100; // Номер телефона
                    Grid_Employees.Columns[4].Width = 100; // Серия паспорта
                    Grid_Employees.Columns[5].Width = 100; // Номер паспорта
                    Grid_Employees.Columns[6].Width = 170; // Должность
                    Grid_Employees.Columns[7].Width = 110; // Оклад
                }
                else
                {
                    Grid_Employees.Visible = false;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            GetEmployees("ID", "ASC","");
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DEKVKMF\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True"))
            {
                Con.Open();
                string query = "SELECT [ID] = P.ID,[Post] = P.[Post] FROM [Posts] AS P";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                CB_Post.DataSource = dt;
                CB_Post.ValueMember = "ID";
                CB_Post.DisplayMember = "Post";
                Con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            AddEmployeesForm form = new AddEmployeesForm();
            form.Show();
            this.Hide();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            GetEmployees("ID", "ASC", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteEmployeesForm form = new DeleteEmployeesForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateEmployeesForm form = new CreateEmployeesForm();
            form.Show();
            this.Hide();
        }


        private void bt_Sort1_Click(object sender, EventArgs e)
        {
            GetEmployees("Name","ASC","");
        }

        private void bt_Sort2_Click(object sender, EventArgs e)
        {
            GetEmployees("Name","DESC","");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetEmployees("ID", "ASC","");
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            GetEmployees("ID", "ASC", $"WHERE P.[Post] = '{CB_Post.Text}'");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_SearchFN_Click(object sender, EventArgs e)
        {
            GetEmployees("ID", "ASC", $"WHERE E.[Name] LIKE '{txt_Search.Text}%'");
        }

        private void bt_SearchLN_Click(object sender, EventArgs e)
        {
            GetEmployees("ID", "ASC", $"WHERE E.[Surname] LIKE '{txt_Search.Text}%'");
        }
    }
}
