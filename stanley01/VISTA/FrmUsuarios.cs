
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jose01.MODEL;

namespace Jose01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
        }

        void Carga()
            
        {

            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();
                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.Id, iteracion.NombreUsuario,iteracion.Apellido, iteracion.Edad,iteracion.Pass);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try {


                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }catch(Exception EX) { 
            
                MessageBox.Show(EX.ToString());
            }
            Carga();







        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(txtID.Text);
                    UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                     
                    //userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }
            Carga();
        }

        private void FrmUsuarios_Load (object sender, EventArgs e) { 
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(txtID.Text);
                    UserList userList = db.UserList.Where(x => x.Id == 1).Select(x => x).FirstOrDefault();
                    //UserList userList = new UserList();
                    //userList = db.UserList.Find(1);
                    userList.NombreUsuario = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.SaveChanges();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Carga();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
