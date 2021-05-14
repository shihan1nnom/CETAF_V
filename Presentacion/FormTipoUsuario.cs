using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormTipoUsuario : Form
    {
        public FormTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new FormMsgBox();
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FormTipoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
