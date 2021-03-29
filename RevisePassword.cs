using System;
using System.Windows.Forms;

namespace MachineForms
{
    public partial class RevisePassword : Form
    {
        private string Account;
        public RevisePassword(string UserData)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(this)
            {
                SkinFile = Application.StartupPath + "//steelBlack.ssk"
            };
            Account = UserData;
        }
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            string get_newPassword = "update User set UserPassword=" + Passwd_text.Text + " where UserID=" + Account;
            MessageBox.Show(get_newPassword);
            ReviseData reviseData = new ReviseData();
            reviseData.SendSQLString(get_newPassword);
            MessageBox.Show("密码修改成功！");
            this.Close();
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
