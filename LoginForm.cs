using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MachineForms
{
    public partial class LoginForm : Form
    {
        private const string MySQLAddress = "Server=120.79.215.238;Port=3306;User=root;Password=C343a4296bb5;Database=exchange_data;SslMode=none;charset=utf8";
        public LoginForm()
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            System.Threading.Thread.Sleep(1000);
            welcome.Close();
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(this)
            {
                SkinFile = Application.StartupPath + "//steelBlack.ssk"
            };
        }

        private void LinkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.foreverloveysy.xin");
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(UserName.Text == string.Empty || Password.Text == string.Empty)
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                string Input_User = UserName.Text = "AreaOne";
                string Input_Passwd = Password.Text;
                string query_user_ID = string.Format("select count(*) from User where UserName='{0}' and UserPassword='{1}'", Input_User, Input_Passwd);
                MySqlConnection connect = new MySqlConnection(MySQLAddress);
                connect.Open();
                MySqlCommand command = new MySqlCommand(query_user_ID, connect);
                int sign = Convert.ToInt32(command.ExecuteScalar());
                connect.Close();
                if (sign > 0)
                {
                    string verify_status = string.Format("select UserStatus from User where UserName='{0}' and UserPassword='{1}'", Input_User, Input_Passwd);
                    MySQLConnect mySQLConnect = new MySQLConnect();
                    int isOnline = Convert.ToInt32(mySQLConnect.ExecuteQuery(verify_status));
                    if (isOnline == 0)
                    {
                        MessageBox.Show("登陆成功！");
                        ReviseData reviseData = new ReviseData();
                        string reviseOnlineStatus = "User";
                        reviseData.SendSQLString(reviseOnlineStatus);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("此账户已经登陆");
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码输入错误！");
                }
            }
        }
        private void Btn_Login2_Click(object sender, EventArgs e)
        {
            if (UserName.Text == string.Empty || Password.Text == string.Empty)
            {
                this.Visible = true;
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //MessageBox.Show("用户名或密码不能为空");  
            }
            /*else
            {
                string Input_User = UserName.Text;
                string Input_Passwd = Password.Text;
                string query_user_ID = string.Format("select count(*) from User where UserName='{0}' and UserPassword='{1}'", Input_User, Input_Passwd);
                MySqlConnection connect = new MySqlConnection(MySQLAddress);
                connect.Open();
                MySqlCommand command = new MySqlCommand(query_user_ID, connect);
                int sign = Convert.ToInt32(command.ExecuteScalar());
                if (sign > 0)
                {
                    string verify_status = string.Format("select UserStatus from User where UserName='{0}' and UserPassword='{1}'", Input_User, Input_Passwd);
                    MySQLConnect mySQLConnect = new MySQLConnect();
                    int isOnline = Convert.ToInt32(mySQLConnect.ExecuteQuery(verify_status));
                    if (isOnline == 0)
                    {
                        MessageBox.Show("登陆成功！");
                        ReviseData reviseData = new ReviseData();
                        string reviseOnlineStatus = "update User set UserStatus=b'1' where UserID=3";
                        reviseData.SendSQLString(reviseOnlineStatus);
                        this.Visible = true;
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("此账户已经登陆");
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码输入错误！");
                }
                connect.Close();
            }*/
        }
        private void Account1_Click(object sender, EventArgs e)
        {
            UserName.Text = "AreaOne";
        }
        private void Account2_Click(object sender, EventArgs e)
        {
            UserName.Text = "Root";
        }
        private void Btn_User_Click(object sender, EventArgs e)
        {
            string UserData = UserName.Text;
            if(UserData == "AreaOne")
            {
                RevisePassword revisePassword = new RevisePassword("2");
                revisePassword.Show();
            }
            else if(UserData == "Root")
            {
                RevisePassword revisePassword = new RevisePassword("3");
                revisePassword.Show();
            }
            else
            {
                MessageBox.Show("账户为空或用户不存在");
            }
        }
    }
}