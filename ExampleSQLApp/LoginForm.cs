using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
            //Настройка высоты поля с поролем
            PasswordBox.AutoSize = false;
            PasswordBox.Size = new Size(PasswordBox.Size.Width, LoginBox.Size.Height);
        }

        //Закрытие при нажатии на соответсвенную обл
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Меняю цвет крестика
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.LightGray;
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        //функции для возможности таскать форму по всему экрану
        Point LastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        //авторизация в проге 
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            String LoginUser = LoginBox.Text;
            String PassUser = PasswordBox.Text;

            if (LoginUser == "" || PassUser == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            //для подключения именно к нашей БД
            DB dB = new DB();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Віборка среди всех полей тех у кого совпадают лишь логин и пароль
            //с логином и паролем с формочки то есть тех что ввел пользіватель
            //вот эти UserL/P что-то типо заглушек(поввышение безопасности, но можно
            //было и сразу указать вставить наши переменные LoginUser и PassUser оно
            //бы работало но было бы более уязвимо к взлому)
            MySqlCommand command = new MySqlCommand
                ("SELECT * FROM `users` WHERE `login` = @UserL AND `pass` = @UserP", 
                dB./*функция написана в файле-классе DB*/GetConnection());
            //указываем заглушкам кем им быть
            command.Parameters.Add
                ("@UserL", /*тип поля в таблице*/MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add
                ("@UserP", /*тип поля в таблице*/MySqlDbType.VarChar).Value = PassUser;
            //выполнение того что мы указали комманд`у
            adapter.SelectCommand = command;
            //заполняем дататейбл данными(не просто так а для удобной работы с данными
            //дататейбл всё граматно фасует и к данным мы имееем легкий доступ)
            adapter.Fill(dataTable);

            //по идее если там где мы вытаскивали данные с локалхоста что-то досталось
            //то строк уже будет больше ноля пожтому такая проверочка
            if (dataTable.Rows.Count>0)
            {
                /*всплывающее окно*/MessageBox.Show("Succesful", "Log in");
            }
            else
            {
                MessageBox.Show("Not Succesful", "Log in");
            }
        }
    }
}
