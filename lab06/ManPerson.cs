using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab06
{
    public partial class ManPerson : Form
    {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public ManPerson()
        {
            InitializeComponent();
        }

        private void ManPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-HP314DE\\SQLEXPRESS2017;DataBase=School;Integrated Security=true";
            con = new SqlConnection(str);
            txtPersonID.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            //Llenamos el dataset con una tabla llamada Person
            adapter.Fill(ds, "Person");

            //Asignamos esa tabla del dataset a un objeto Table
            //para trabajar directamente con él
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertPerson", con);

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            //Creamos una fila nueva la cual insertaremos en la BD
            //esta fila debe tener la estructura correspondiente
            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtFirstName.Text;
            fila["HireDate"] = txtHireDate.Text;
            fila["EnrollmentDate"] = txtEnrollmentDate.Text;

            //Una vez tenemos la fila, la agregamos a la tabla Persona del dataset
            tablePerson.Rows.Add(fila);

            //Actualizamos el dataset con la tabla Person
            adapter.Update(tablePerson);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdatePerson", con);

            //Add the parameter for the InsertCommand.
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            //Creamos un array de DataRow el cual almacenará la fila que coincida
            //con el resultado de la busqueda de personID
            //A cada compo de la fila, le asignamos el valor modificado
            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["HireDate"] = txtHireDate.Text;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;

            //Actualizamos el dataset con la tabla modificada
            adapter.Update(tablePerson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", con);
            cmd.Parameters.Add("@PersonID", SqlDbType.Int).SourceColumn = "PersonID";
            SqlDataAdapter adapter = new SqlDataAdapter() ;
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            //Buscamos la fila a eliminar
            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            //Eliminamos de la tabla la fila especificada
            tablePerson.Rows.Remove(fila[0]);
            //Actualizamos el dataset con la tabla modificada
            adapter.Update(tablePerson);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();

                string hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if(String.IsNullOrEmpty(hireDate))
                    txtHireDate.Checked = false;
                else txtHireDate.Text = hireDate;

                string enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = enrollmentDate;
            }
        }

        private void btnOrderLastName_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.Sort = "LastName ASC";
            dgvListado.DataSource = dv;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEnrollmentDate.Value = DateTime.Now;
            txtHireDate.Value = DateTime.Now;
            
        }

        //TAREA DOS MÉTODOS MÁS BUSCAR POR NOMBRE Y POR APELLIDO 
        private void btnBuscarName_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "FirstName = '" + txtFirstName.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
            dgvListado.DataSource = dv;
        }
    }
}
