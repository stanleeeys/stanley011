using stanley01.DAO;
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
            ClsDUserList clsDUserList = new ClsDUserList();
            List<UserList> Lista = clsDUserList.cargarDatosUserList();

            foreach (var iteracion in Lista)
            {
                Tabla.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }
            }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textId.Text.Equals (""))
            {

                ClsDUserList clsDUserList = new ClsDUserList();
                //clsDUserList.SaveDatosUser(textNombre.Text, textApellido.Text, Convert.ToInt32(textEdad.Text), textPass.Text);
                UserList userList = new UserList();
                userList.NombreUsuario = textNombre.Text;
                userList.Apellido = textApellido.Text;
                userList.Edad = Convert.ToInt32(textEdad.Text);
                userList.Pass = textPass.Text;
                clsDUserList.SaveDatosUser(userList);
                
            }
            else {

                ClsDUserList clsDUserList = new ClsDUserList();

                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(textId.Text);
                userList.NombreUsuario = textNombre.Text;
                userList.Apellido = textApellido.Text;
                userList.Edad = Convert.ToInt32(textEdad.Text);
                userList.Pass = textPass.Text;
                clsDUserList.updateUser(userList);


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
            ClsDUserList user = new ClsDUserList();
            user.deleteUser(Convert.ToInt32(textId.Text));

            Carga();
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {

           
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
