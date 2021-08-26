using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLab01_2
{
    public partial class Form1 : Form
    {
        int pos;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dvgUsuarios.CurrentRow.Index;
            txtDNI.Text = dvgUsuarios[1, pos].Value.ToString();
            txtNombre.Text = dvgUsuarios[2, pos].Value.ToString();
            txtApellido.Text = dvgUsuarios[3, pos].Value.ToString();
            txtDireccion.Text = dvgUsuarios[4, pos].Value.ToString();
            txtTelefono.Text = dvgUsuarios[5, pos].Value.ToString();
            txtEmail.Text = dvgUsuarios[6, pos].Value.ToString();
            dtpFecha.Text = dvgUsuarios[7, pos].Value.ToString();
            cboDepartamento.Text = dvgUsuarios[8, pos].Value.ToString();
            cboCargo.Text = dvgUsuarios[9, pos].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fecha = dtpFecha.Text;
            string departamento = cboDepartamento.Text;
            string cargo = cboCargo.Text;
            dvgUsuarios.Rows.Add(codigo, dni, nombre, apellido, direccion, telefono, email, fecha, departamento, cargo);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dvgUsuarios.Rows.Remove(dvgUsuarios.CurrentRow);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fecha = dtpFecha.Text;
            string departamento = cboDepartamento.Text;
            string cargo = cboCargo.Text;
            dvgUsuarios[1, pos].Value = dni;
            dvgUsuarios[2, pos].Value = nombre;
            dvgUsuarios[3, pos].Value = apellido;
            dvgUsuarios[4, pos].Value = direccion;
            dvgUsuarios[5, pos].Value = telefono;
            dvgUsuarios[6, pos].Value = email;
            dvgUsuarios[7, pos].Value = dtpFecha.Text;
            dvgUsuarios[8, pos].Value = departamento;
            dvgUsuarios[9, pos].Value = cargo;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
