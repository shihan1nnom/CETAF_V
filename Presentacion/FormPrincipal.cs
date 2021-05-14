using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Funcionalidad del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION 
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(30, 30, 30));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        #endregion

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        // Metodo para abrir formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form _formulario;
            _formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault(); // Busca en la coleccion el formulario
            if (_formulario == null)
            {
                _formulario = new MiForm();
                _formulario.TopLevel = false;
                _formulario.FormBorderStyle = FormBorderStyle.None;
                _formulario.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(_formulario);
                panelFormulario.Tag = _formulario;
                _formulario.Show();
                _formulario.BringToFront();
                _formulario.FormClosed += new FormClosedEventHandler(CerrarForm);
            }
            else
            {
                _formulario.BringToFront();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin forma = new FormLogin();
            forma.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCategoria>();
            btnCategoria.BackColor = Color.Black;
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormActivos>();
            btnActivos.BackColor = Color.Black;
        }

        private void btnTipoUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTipoUsuario>();
            btnTipoUsuario.BackColor = Color.Black;
        }

        private void btnSedes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSedes>();
            btnSedes.BackColor = Color.Black;
        }

        private void btnAmbientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAmbientes>();
            btnAmbientes.BackColor = Color.Black;
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAsignaciones>();
            btnAsignaciones.BackColor = Color.Black;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormConsultas>();
            btnConsultas.BackColor = Color.Black;
        }

        private void btnCopiaSeguridad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCopiaSeguridad>();
            btnCopiaSeguridad.BackColor = Color.Black;
        }

        private void panelMenu_SizeChanged(object sender, EventArgs e)
        {
            this.panelMenu.AutoScroll = true;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormUsuario>();
            btnUsuario.BackColor = Color.Black;
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormUsuario"] == null)
            {
                btnUsuario.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormCategoria"] == null)
            {
                btnCategoria.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormActivos"] == null)
            {
                btnActivos.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormTipoUsuario"] == null)
            {
                btnTipoUsuario.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormSedes"] == null)
            {
                btnSedes.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormAmbientes"] == null)
            {
                btnAmbientes.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormAsignaciones"] == null)
            {
                btnAsignaciones.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormConsultas"] == null)
            {
                btnConsultas.BackColor = Color.FromArgb(255, 50, 1);
            }
            if (Application.OpenForms["FormCopiaSeguridad"] == null)
            {
                btnCopiaSeguridad.BackColor = Color.FromArgb(255, 50, 1);
            }
        }
    }
}
