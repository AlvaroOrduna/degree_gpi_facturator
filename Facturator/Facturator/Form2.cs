using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturator
{
    public partial class UserAuth : Form
    {
        Dictionary<string, string> users = new Dictionary<string, string>();

        public UserAuth()
        {
            InitializeComponent();

            users.Add("Joseba", "1234");
            users.Add("Josu", "4321");
            users.Add("Álvaro", "alvaro");
            users.Add("Iñigo", "123456789");

            pass.Text = "";
            pass.PasswordChar = '*';
            pass.MaxLength = 14;

            errorMsg.ForeColor = System.Drawing.Color.Red;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String userName = user.Text;
            String userPass = pass.Text;

            if (!userName.Equals("") && !userPass.Equals("")) {
                String userPassFormDic;
                if (users.TryGetValue(userName,out userPassFormDic) &&
                    userPassFormDic.Equals(userPass))
                {
                    Facturacion f = new Facturacion();

                    errorMsg.Text = "";

                    this.Hide();
                    f.Show();
                    return;
                }
            }

            errorMsg.Text = "Error de autentificación";
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
