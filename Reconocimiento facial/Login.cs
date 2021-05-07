using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class Login : Form
    {
        public static bool cambio;

        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "" && textClave.Text != "")
            {
                if (textUsuario.Text == "Admin" && textClave.Text == "admin12345")
                {
                    Frm_Registrar Admin = new Frm_Registrar();
                    this.Close();
                    MessageBox.Show("Bienvenido Administrador!~.");
                    cambio = true;
                    Admin.Show();
                }
                else if (textUsuario.Text == "Admin2" && textClave.Text == "admin12345")
                {
                    Frm_Registrar Admin = new Frm_Registrar();
                    this.Close();
                    MessageBox.Show("Bienvenido Administrador de Base de Datos!~.");
                    cambio = false;
                    Admin.Show();
                }
                else
                {
                    if (textUsuario.Text != "Admin")
                    {
                        MessageBox.Show("El usuario ingresado no es correcto!~.");
                    }
                    else
                    {
                        MessageBox.Show("La contraseña ingresada no es correcto!~.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ambos campos deben estar completados!~.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
