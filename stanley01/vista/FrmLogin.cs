using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stanley01.negocio;
using stanley01.dominio;


namespace stanley01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text; 
            log.Password = txtPass.Text;

            ClsLogin clsl = new ClsLogin();

            int variabledeevualuacion= clsl.acceso(log);

            if (variabledeevualuacion==1){

                MessageBox.Show("Welcom");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
