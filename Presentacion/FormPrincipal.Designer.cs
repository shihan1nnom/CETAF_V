namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCopiaSeguridad = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnAsignaciones = new System.Windows.Forms.Button();
            this.btnAmbientes = new System.Windows.Forms.Button();
            this.btnSedes = new System.Windows.Forms.Button();
            this.btnTipoUsuario = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelFormulario);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelTop);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1280, 720);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormulario
            // 
            this.panelFormulario.AutoScroll = true;
            this.panelFormulario.AutoScrollMinSize = new System.Drawing.Size(1030, 690);
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelFormulario.Controls.Add(this.panel1);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(250, 30);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(1030, 690);
            this.panelFormulario.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(1)))));
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnCopiaSeguridad);
            this.panelMenu.Controls.Add(this.btnConsultas);
            this.panelMenu.Controls.Add(this.btnAsignaciones);
            this.panelMenu.Controls.Add(this.btnAmbientes);
            this.panelMenu.Controls.Add(this.btnSedes);
            this.panelMenu.Controls.Add(this.btnTipoUsuario);
            this.panelMenu.Controls.Add(this.btnActivos);
            this.panelMenu.Controls.Add(this.btnCategoria);
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 690);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.SizeChanged += new System.EventHandler(this.panelMenu_SizeChanged);
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Black Ops One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "CETAF";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 621);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "CERRAR SESION";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCopiaSeguridad
            // 
            this.btnCopiaSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiaSeguridad.FlatAppearance.BorderSize = 3;
            this.btnCopiaSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCopiaSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiaSeguridad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiaSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnCopiaSeguridad.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiaSeguridad.Image")));
            this.btnCopiaSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopiaSeguridad.Location = new System.Drawing.Point(-1, 469);
            this.btnCopiaSeguridad.Name = "btnCopiaSeguridad";
            this.btnCopiaSeguridad.Size = new System.Drawing.Size(250, 40);
            this.btnCopiaSeguridad.TabIndex = 8;
            this.btnCopiaSeguridad.Text = "COPIA SEGURIDAD";
            this.btnCopiaSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopiaSeguridad.UseVisualStyleBackColor = true;
            this.btnCopiaSeguridad.Click += new System.EventHandler(this.btnCopiaSeguridad_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultas.FlatAppearance.BorderSize = 3;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(-1, 423);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(250, 40);
            this.btnConsultas.TabIndex = 7;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAsignaciones.FlatAppearance.BorderSize = 3;
            this.btnAsignaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.ForeColor = System.Drawing.Color.White;
            this.btnAsignaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignaciones.Image")));
            this.btnAsignaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaciones.Location = new System.Drawing.Point(-1, 377);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(250, 40);
            this.btnAsignaciones.TabIndex = 6;
            this.btnAsignaciones.Text = "ASIGNACIONES";
            this.btnAsignaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignaciones.UseVisualStyleBackColor = true;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnAmbientes
            // 
            this.btnAmbientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAmbientes.FlatAppearance.BorderSize = 3;
            this.btnAmbientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAmbientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbientes.ForeColor = System.Drawing.Color.White;
            this.btnAmbientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAmbientes.Image")));
            this.btnAmbientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmbientes.Location = new System.Drawing.Point(-1, 331);
            this.btnAmbientes.Name = "btnAmbientes";
            this.btnAmbientes.Size = new System.Drawing.Size(250, 40);
            this.btnAmbientes.TabIndex = 5;
            this.btnAmbientes.Text = "AMBIENTES";
            this.btnAmbientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAmbientes.UseVisualStyleBackColor = true;
            this.btnAmbientes.Click += new System.EventHandler(this.btnAmbientes_Click);
            // 
            // btnSedes
            // 
            this.btnSedes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSedes.FlatAppearance.BorderSize = 3;
            this.btnSedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSedes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSedes.ForeColor = System.Drawing.Color.White;
            this.btnSedes.Image = ((System.Drawing.Image)(resources.GetObject("btnSedes.Image")));
            this.btnSedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSedes.Location = new System.Drawing.Point(-1, 285);
            this.btnSedes.Name = "btnSedes";
            this.btnSedes.Size = new System.Drawing.Size(250, 40);
            this.btnSedes.TabIndex = 4;
            this.btnSedes.Text = "SEDES";
            this.btnSedes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSedes.UseVisualStyleBackColor = true;
            this.btnSedes.Click += new System.EventHandler(this.btnSedes_Click);
            // 
            // btnTipoUsuario
            // 
            this.btnTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTipoUsuario.FlatAppearance.BorderSize = 3;
            this.btnTipoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnTipoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoUsuario.Image")));
            this.btnTipoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoUsuario.Location = new System.Drawing.Point(-1, 239);
            this.btnTipoUsuario.Name = "btnTipoUsuario";
            this.btnTipoUsuario.Size = new System.Drawing.Size(250, 40);
            this.btnTipoUsuario.TabIndex = 3;
            this.btnTipoUsuario.Text = "TIPO USUARIO";
            this.btnTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoUsuario.UseVisualStyleBackColor = true;
            this.btnTipoUsuario.Click += new System.EventHandler(this.btnTipoUsuario_Click);
            // 
            // btnActivos
            // 
            this.btnActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActivos.FlatAppearance.BorderSize = 3;
            this.btnActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivos.ForeColor = System.Drawing.Color.White;
            this.btnActivos.Image = ((System.Drawing.Image)(resources.GetObject("btnActivos.Image")));
            this.btnActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivos.Location = new System.Drawing.Point(-1, 193);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(250, 40);
            this.btnActivos.TabIndex = 2;
            this.btnActivos.Text = "ACTIVOS";
            this.btnActivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoria.FlatAppearance.BorderSize = 3;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(-1, 147);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(250, 40);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "CATEGORIA";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuario.FlatAppearance.BorderSize = 3;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(-1, 101);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(250, 40);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(1)))));
            this.panelTop.Controls.Add(this.btnRestaurar);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 30);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1214, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1180, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1216, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1250, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(299, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 268);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Control Total y Eficaz de Activos Fijos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Black Ops One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "CETAF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(650, 515);
            this.Name = "FormPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCopiaSeguridad;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnAsignaciones;
        private System.Windows.Forms.Button btnAmbientes;
        private System.Windows.Forms.Button btnSedes;
        private System.Windows.Forms.Button btnTipoUsuario;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}