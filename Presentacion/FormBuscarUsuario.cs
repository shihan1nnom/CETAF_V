using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class FormBuscarUsuario : Form
    {
        
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void MostrarUsers()
        {
            ModeloUsuario ModelUser = new ModeloUsuario();
            dataGridView1.DataSource = ModelUser.MostrarUsers();
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsers();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUsuario _usuario = Owner as FormUsuario;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                _usuario.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                _usuario.txtTipoIdent.SelectedValue = dataGridView1.CurrentRow.Cells["TipoIdent"].Value.ToString();
                _usuario.txtNumIdent.Text = dataGridView1.CurrentRow.Cells["NumIdent"].Value.ToString();
                _usuario.txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                _usuario.txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                _usuario.txtNombreUser.Text = dataGridView1.CurrentRow.Cells["NombreUser"].Value.ToString();
                _usuario.txtPass.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                _usuario.txtTipoUsuario.SelectedValue = dataGridView1.CurrentRow.Cells["TipoUserID"].Value.ToString();
                _usuario._UsuarioID = dataGridView1.CurrentRow.Cells["UsuarioID"].Value.ToString();
                this.Close();
            }
            else
            {
                lbAviso.Visible = true;
                lbAviso.Text = "Debe seleccionar la fila a modificar";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
