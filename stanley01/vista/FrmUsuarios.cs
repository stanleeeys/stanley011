using stanley01.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stanley01.vista
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        
            
              {
                InitializeComponent();
                Carga();
                clear();
              }

        void clear()
        {
            textId.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textEdad.Clear();
            textPass.Clear();
        }

            void Carga()

            {

                Tabla.Rows.Clear();
                using (programacionEntities db = new programacionEntities())
                {
                    var Lista = db.UserList.ToList();
                    foreach (var iteracion in Lista)
                    {
                        Tabla.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
                    }
                }
            }
        

        private void button1_Click(object sender, EventArgs e)
        { 
            try { 
            using (programacionEntities db = new programacionEntities()) {


                UserList userList = new UserList();



                userList.NombreUsuario = textNombre.Text;
                userList.Apellido = textApellido.Text;
                userList.Edad = Convert.ToInt32(textEdad.Text);
                userList.Pass = textPass.Text;
                db.UserList.Add(userList);
                db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
            clear();



        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(textId.Text);
                    UserList userListddd = db.UserList.Where(x => x.Id == 141).Select(x => x).FirstOrDefault();
                    //int Eliminar = Convert.ToInt32(textId.Text);
                    //userList1 = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userListddd);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(textId.Text);
                    UserList userList = db.UserList.Where(x => x.Id == 1).Select(x => x).FirstOrDefault();
                    //UserList userList = new UserList();
                    //userList = db.UserList.Find(1);
                    userList.NombreUsuario = textNombre.Text;
                    userList.Apellido = textApellido.Text;
                    userList.Edad = Convert.ToInt32(textEdad.Text);
                    userList.Pass = textPass.Text;
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Carga();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = Tabla.CurrentRow.Cells[0].Value.ToString();
            String Nombre = Tabla.CurrentRow.Cells[1].Value.ToString();
            String Apellido= Tabla.CurrentRow.Cells[2].Value.ToString();
            String Edad = Tabla.CurrentRow.Cells[3].Value.ToString();
            String Pass = Tabla.CurrentRow.Cells[4].Value.ToString();

            textId.Text = Id;
            textNombre.Text = Nombre;
            textApellido.Text = Apellido;
            textEdad.Text = Edad;
            textPass.Text = Pass;
            

        }
    }
   
}
