using MiLibro.Services;
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

namespace MiLibro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ValidationUser(UserName.Text, Password.Text))
            {
                MessageBox.Show("Login Correcto");
            }
            else {
                MessageBox.Show("Usuario o contrasenia incorrecta");
            }
        }

        bool ValidationUser(string user, string pass) {
            SqlDataReader data = BasicServices.Instance.Read("SELECT * FROM usuarios");
            while (data.Read())
            {
                if (data.GetString(3) == user && data.GetString(4) == pass)
                {
                    return true;
                }
            }
            data.Close();
            return false;
        }

    }
}
