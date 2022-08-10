namespace PRODISIC.Presentacion
{
    partial class Frm_DashBoard
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
            this.components = new System.ComponentModel.Container();
            this.Pnl_menu = new System.Windows.Forms.Panel();
            this.CerrarSesion = new FontAwesome.Sharp.IconButton();
            this.Pnl_datosmaestros = new System.Windows.Forms.Panel();
            this.DM_areadespacho = new FontAwesome.Sharp.IconButton();
            this.DM_mesas = new FontAwesome.Sharp.IconButton();
            this.DM_puntoventas = new FontAwesome.Sharp.IconButton();
            this.DM_Familias = new FontAwesome.Sharp.IconButton();
            this.DM_subfamilias = new FontAwesome.Sharp.IconButton();
            this.DM_medidas = new FontAwesome.Sharp.IconButton();
            this.DM_marcas = new FontAwesome.Sharp.IconButton();
            this.DM_productos = new FontAwesome.Sharp.IconButton();
            this.Btn_datosmaestros = new FontAwesome.Sharp.IconButton();
            this.Pnl_reportes = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.Btn_reportes = new FontAwesome.Sharp.IconButton();
            this.Pnl_procesos = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.PR_registrarpedido = new FontAwesome.Sharp.IconButton();
            this.Btn_Procesos = new FontAwesome.Sharp.IconButton();
            this.Btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.Pnl_logo = new System.Windows.Forms.Panel();
            this.Pct_logo = new System.Windows.Forms.PictureBox();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new FontAwesome.Sharp.IconButton();
            this.Btn_maximizar = new FontAwesome.Sharp.IconButton();
            this.Btn_minimizar = new FontAwesome.Sharp.IconButton();
            this.TextoSeleccionado = new System.Windows.Forms.Label();
            this.IconoSeleccionado = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_barraestado = new System.Windows.Forms.Panel();
            this.Grb_fechayhora = new System.Windows.Forms.GroupBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Pnl_contenido = new System.Windows.Forms.Panel();
            this.Pnl_logoPRODISIC = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_menu.SuspendLayout();
            this.Pnl_datosmaestros.SuspendLayout();
            this.Pnl_reportes.SuspendLayout();
            this.Pnl_procesos.SuspendLayout();
            this.Pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_logo)).BeginInit();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoSeleccionado)).BeginInit();
            this.Pnl_barraestado.SuspendLayout();
            this.Grb_fechayhora.SuspendLayout();
            this.Pnl_contenido.SuspendLayout();
            this.Pnl_logoPRODISIC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_menu
            // 
            this.Pnl_menu.AutoScroll = true;
            this.Pnl_menu.BackColor = System.Drawing.Color.OrangeRed;
            this.Pnl_menu.Controls.Add(this.CerrarSesion);
            this.Pnl_menu.Controls.Add(this.Pnl_datosmaestros);
            this.Pnl_menu.Controls.Add(this.Btn_datosmaestros);
            this.Pnl_menu.Controls.Add(this.Pnl_reportes);
            this.Pnl_menu.Controls.Add(this.Btn_reportes);
            this.Pnl_menu.Controls.Add(this.Pnl_procesos);
            this.Pnl_menu.Controls.Add(this.Btn_Procesos);
            this.Pnl_menu.Controls.Add(this.Btn_Dashboard);
            this.Pnl_menu.Controls.Add(this.Pnl_logo);
            this.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_menu.Name = "Pnl_menu";
            this.Pnl_menu.Size = new System.Drawing.Size(252, 673);
            this.Pnl_menu.TabIndex = 0;
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.BackColor = System.Drawing.Color.SlateGray;
            this.CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.CerrarSesion.FlatAppearance.BorderSize = 0;
            this.CerrarSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.CerrarSesion.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarSesion.IconSize = 34;
            this.CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarSesion.Location = new System.Drawing.Point(0, 1061);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(235, 50);
            this.CerrarSesion.TabIndex = 6;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Pnl_datosmaestros
            // 
            this.Pnl_datosmaestros.BackColor = System.Drawing.Color.LightGray;
            this.Pnl_datosmaestros.Controls.Add(this.DM_areadespacho);
            this.Pnl_datosmaestros.Controls.Add(this.DM_mesas);
            this.Pnl_datosmaestros.Controls.Add(this.DM_puntoventas);
            this.Pnl_datosmaestros.Controls.Add(this.DM_Familias);
            this.Pnl_datosmaestros.Controls.Add(this.DM_subfamilias);
            this.Pnl_datosmaestros.Controls.Add(this.DM_medidas);
            this.Pnl_datosmaestros.Controls.Add(this.DM_marcas);
            this.Pnl_datosmaestros.Controls.Add(this.DM_productos);
            this.Pnl_datosmaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_datosmaestros.Location = new System.Drawing.Point(0, 652);
            this.Pnl_datosmaestros.Name = "Pnl_datosmaestros";
            this.Pnl_datosmaestros.Size = new System.Drawing.Size(235, 409);
            this.Pnl_datosmaestros.TabIndex = 5;
            this.Pnl_datosmaestros.Visible = false;
            // 
            // DM_areadespacho
            // 
            this.DM_areadespacho.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_areadespacho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_areadespacho.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_areadespacho.FlatAppearance.BorderSize = 0;
            this.DM_areadespacho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_areadespacho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_areadespacho.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_areadespacho.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_areadespacho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_areadespacho.IconSize = 34;
            this.DM_areadespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_areadespacho.Location = new System.Drawing.Point(0, 350);
            this.DM_areadespacho.Name = "DM_areadespacho";
            this.DM_areadespacho.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_areadespacho.Size = new System.Drawing.Size(235, 50);
            this.DM_areadespacho.TabIndex = 9;
            this.DM_areadespacho.Text = "Areas Despachos";
            this.DM_areadespacho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_areadespacho.UseVisualStyleBackColor = false;
            this.DM_areadespacho.Click += new System.EventHandler(this.DM_areadespacho_Click);
            // 
            // DM_mesas
            // 
            this.DM_mesas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_mesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_mesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_mesas.FlatAppearance.BorderSize = 0;
            this.DM_mesas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_mesas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_mesas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_mesas.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_mesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_mesas.IconSize = 34;
            this.DM_mesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_mesas.Location = new System.Drawing.Point(0, 300);
            this.DM_mesas.Name = "DM_mesas";
            this.DM_mesas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_mesas.Size = new System.Drawing.Size(235, 50);
            this.DM_mesas.TabIndex = 8;
            this.DM_mesas.Text = "Mesas";
            this.DM_mesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_mesas.UseVisualStyleBackColor = false;
            this.DM_mesas.Click += new System.EventHandler(this.DM_mesas_Click);
            // 
            // DM_puntoventas
            // 
            this.DM_puntoventas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_puntoventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_puntoventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_puntoventas.FlatAppearance.BorderSize = 0;
            this.DM_puntoventas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_puntoventas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_puntoventas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_puntoventas.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_puntoventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_puntoventas.IconSize = 34;
            this.DM_puntoventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_puntoventas.Location = new System.Drawing.Point(0, 250);
            this.DM_puntoventas.Name = "DM_puntoventas";
            this.DM_puntoventas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_puntoventas.Size = new System.Drawing.Size(235, 50);
            this.DM_puntoventas.TabIndex = 7;
            this.DM_puntoventas.Text = "Puntos de Ventas";
            this.DM_puntoventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_puntoventas.UseVisualStyleBackColor = false;
            this.DM_puntoventas.Click += new System.EventHandler(this.DM_puntoventas_Click);
            // 
            // DM_Familias
            // 
            this.DM_Familias.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_Familias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_Familias.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_Familias.FlatAppearance.BorderSize = 0;
            this.DM_Familias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_Familias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_Familias.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_Familias.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_Familias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_Familias.IconSize = 34;
            this.DM_Familias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_Familias.Location = new System.Drawing.Point(0, 200);
            this.DM_Familias.Name = "DM_Familias";
            this.DM_Familias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_Familias.Size = new System.Drawing.Size(235, 50);
            this.DM_Familias.TabIndex = 6;
            this.DM_Familias.Text = "Familias";
            this.DM_Familias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_Familias.UseVisualStyleBackColor = false;
            this.DM_Familias.Click += new System.EventHandler(this.DM_Familias_Click);
            // 
            // DM_subfamilias
            // 
            this.DM_subfamilias.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_subfamilias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_subfamilias.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_subfamilias.FlatAppearance.BorderSize = 0;
            this.DM_subfamilias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_subfamilias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_subfamilias.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_subfamilias.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_subfamilias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_subfamilias.IconSize = 34;
            this.DM_subfamilias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_subfamilias.Location = new System.Drawing.Point(0, 150);
            this.DM_subfamilias.Name = "DM_subfamilias";
            this.DM_subfamilias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_subfamilias.Size = new System.Drawing.Size(235, 50);
            this.DM_subfamilias.TabIndex = 5;
            this.DM_subfamilias.Text = "SubFamilias";
            this.DM_subfamilias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_subfamilias.UseVisualStyleBackColor = false;
            this.DM_subfamilias.Click += new System.EventHandler(this.DM_subfamilias_Click);
            // 
            // DM_medidas
            // 
            this.DM_medidas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_medidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_medidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_medidas.FlatAppearance.BorderSize = 0;
            this.DM_medidas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_medidas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_medidas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_medidas.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_medidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_medidas.IconSize = 34;
            this.DM_medidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_medidas.Location = new System.Drawing.Point(0, 100);
            this.DM_medidas.Name = "DM_medidas";
            this.DM_medidas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_medidas.Size = new System.Drawing.Size(235, 50);
            this.DM_medidas.TabIndex = 4;
            this.DM_medidas.Text = "Unidades de Medidas";
            this.DM_medidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_medidas.UseVisualStyleBackColor = false;
            this.DM_medidas.Click += new System.EventHandler(this.DM_medidas_Click);
            // 
            // DM_marcas
            // 
            this.DM_marcas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_marcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_marcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_marcas.FlatAppearance.BorderSize = 0;
            this.DM_marcas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_marcas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_marcas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_marcas.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_marcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_marcas.IconSize = 34;
            this.DM_marcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_marcas.Location = new System.Drawing.Point(0, 50);
            this.DM_marcas.Name = "DM_marcas";
            this.DM_marcas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_marcas.Size = new System.Drawing.Size(235, 50);
            this.DM_marcas.TabIndex = 3;
            this.DM_marcas.Text = "Marcas";
            this.DM_marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_marcas.UseVisualStyleBackColor = false;
            this.DM_marcas.Click += new System.EventHandler(this.DM_marcas_Click);
            // 
            // DM_productos
            // 
            this.DM_productos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DM_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DM_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.DM_productos.FlatAppearance.BorderSize = 0;
            this.DM_productos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DM_productos.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.DM_productos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DM_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DM_productos.IconSize = 34;
            this.DM_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DM_productos.Location = new System.Drawing.Point(0, 0);
            this.DM_productos.Name = "DM_productos";
            this.DM_productos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DM_productos.Size = new System.Drawing.Size(235, 50);
            this.DM_productos.TabIndex = 2;
            this.DM_productos.Text = "Productos";
            this.DM_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DM_productos.UseVisualStyleBackColor = false;
            this.DM_productos.Click += new System.EventHandler(this.DM_productos_Click);
            // 
            // Btn_datosmaestros
            // 
            this.Btn_datosmaestros.BackColor = System.Drawing.Color.SlateGray;
            this.Btn_datosmaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_datosmaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_datosmaestros.FlatAppearance.BorderSize = 0;
            this.Btn_datosmaestros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_datosmaestros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_datosmaestros.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.Btn_datosmaestros.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_datosmaestros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_datosmaestros.IconSize = 34;
            this.Btn_datosmaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_datosmaestros.Location = new System.Drawing.Point(0, 602);
            this.Btn_datosmaestros.Name = "Btn_datosmaestros";
            this.Btn_datosmaestros.Size = new System.Drawing.Size(235, 50);
            this.Btn_datosmaestros.TabIndex = 4;
            this.Btn_datosmaestros.Text = "Datos Maestros";
            this.Btn_datosmaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_datosmaestros.UseVisualStyleBackColor = false;
            this.Btn_datosmaestros.Click += new System.EventHandler(this.Btn_datosmaestros_Click);
            // 
            // Pnl_reportes
            // 
            this.Pnl_reportes.BackColor = System.Drawing.Color.LightGray;
            this.Pnl_reportes.Controls.Add(this.iconButton5);
            this.Pnl_reportes.Controls.Add(this.iconButton4);
            this.Pnl_reportes.Controls.Add(this.iconButton6);
            this.Pnl_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_reportes.Location = new System.Drawing.Point(0, 451);
            this.Pnl_reportes.Name = "Pnl_reportes";
            this.Pnl_reportes.Size = new System.Drawing.Size(235, 151);
            this.Pnl_reportes.TabIndex = 3;
            this.Pnl_reportes.Visible = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton5.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 34;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 100);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(235, 50);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "Opcion1";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton4.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 34;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 50);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(235, 50);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Opcion1";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton6.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 34;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(235, 50);
            this.iconButton6.TabIndex = 2;
            this.iconButton6.Text = "Opcion1";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.SlateGray;
            this.Btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_reportes.FlatAppearance.BorderSize = 0;
            this.Btn_reportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_reportes.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.Btn_reportes.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_reportes.IconSize = 34;
            this.Btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reportes.Location = new System.Drawing.Point(0, 401);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(235, 50);
            this.Btn_reportes.TabIndex = 2;
            this.Btn_reportes.Text = "Reportes";
            this.Btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_reportes.UseVisualStyleBackColor = false;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // Pnl_procesos
            // 
            this.Pnl_procesos.BackColor = System.Drawing.Color.LightGray;
            this.Pnl_procesos.Controls.Add(this.iconButton3);
            this.Pnl_procesos.Controls.Add(this.iconButton2);
            this.Pnl_procesos.Controls.Add(this.PR_registrarpedido);
            this.Pnl_procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_procesos.Location = new System.Drawing.Point(0, 250);
            this.Pnl_procesos.Name = "Pnl_procesos";
            this.Pnl_procesos.Size = new System.Drawing.Size(235, 151);
            this.Pnl_procesos.TabIndex = 0;
            this.Pnl_procesos.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconButton3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 34;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 100);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(235, 50);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Opcion3";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 34;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 50);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(235, 50);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Opcion2";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // PR_registrarpedido
            // 
            this.PR_registrarpedido.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PR_registrarpedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PR_registrarpedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.PR_registrarpedido.FlatAppearance.BorderSize = 0;
            this.PR_registrarpedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR_registrarpedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PR_registrarpedido.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.PR_registrarpedido.IconColor = System.Drawing.Color.WhiteSmoke;
            this.PR_registrarpedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PR_registrarpedido.IconSize = 34;
            this.PR_registrarpedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PR_registrarpedido.Location = new System.Drawing.Point(0, 0);
            this.PR_registrarpedido.Name = "PR_registrarpedido";
            this.PR_registrarpedido.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.PR_registrarpedido.Size = new System.Drawing.Size(235, 50);
            this.PR_registrarpedido.TabIndex = 2;
            this.PR_registrarpedido.Text = "Registrar Pedido";
            this.PR_registrarpedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PR_registrarpedido.UseVisualStyleBackColor = false;
            this.PR_registrarpedido.Click += new System.EventHandler(this.PR_registrarpedido_Click);
            // 
            // Btn_Procesos
            // 
            this.Btn_Procesos.BackColor = System.Drawing.Color.SlateGray;
            this.Btn_Procesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Procesos.FlatAppearance.BorderSize = 0;
            this.Btn_Procesos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Procesos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Procesos.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.Btn_Procesos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Procesos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Procesos.IconSize = 34;
            this.Btn_Procesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Procesos.Location = new System.Drawing.Point(0, 200);
            this.Btn_Procesos.Name = "Btn_Procesos";
            this.Btn_Procesos.Size = new System.Drawing.Size(235, 50);
            this.Btn_Procesos.TabIndex = 1;
            this.Btn_Procesos.Text = "Procesos";
            this.Btn_Procesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Procesos.UseVisualStyleBackColor = false;
            this.Btn_Procesos.Click += new System.EventHandler(this.Btn_Procesos_Click);
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.BackColor = System.Drawing.Color.SlateGray;
            this.Btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn_Dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.Dochub;
            this.Btn_Dashboard.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Dashboard.IconSize = 34;
            this.Btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dashboard.Location = new System.Drawing.Point(0, 150);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Size = new System.Drawing.Size(235, 50);
            this.Btn_Dashboard.TabIndex = 0;
            this.Btn_Dashboard.Text = "DashBoard";
            this.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Dashboard.UseVisualStyleBackColor = false;
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // Pnl_logo
            // 
            this.Pnl_logo.Controls.Add(this.Pct_logo);
            this.Pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_logo.Name = "Pnl_logo";
            this.Pnl_logo.Size = new System.Drawing.Size(235, 150);
            this.Pnl_logo.TabIndex = 0;
            // 
            // Pct_logo
            // 
            this.Pct_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_logo.Image = global::PRODISIC.Presentacion.Properties.Resources.Logo_PRODISIC;
            this.Pct_logo.Location = new System.Drawing.Point(3, 3);
            this.Pct_logo.Name = "Pct_logo";
            this.Pct_logo.Size = new System.Drawing.Size(229, 141);
            this.Pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_logo.TabIndex = 0;
            this.Pct_logo.TabStop = false;
            this.Pct_logo.Click += new System.EventHandler(this.Pct_logo_Click);
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Btn_maximizar);
            this.Pnl_titulo.Controls.Add(this.Btn_minimizar);
            this.Pnl_titulo.Controls.Add(this.TextoSeleccionado);
            this.Pnl_titulo.Controls.Add(this.IconoSeleccionado);
            this.Pnl_titulo.Controls.Add(this.label2);
            this.Pnl_titulo.Controls.Add(this.label1);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(252, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1032, 91);
            this.Pnl_titulo.TabIndex = 1;
            this.Pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseDown);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.Tomato;
            this.Btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_cerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Btn_cerrar.IconColor = System.Drawing.Color.White;
            this.Btn_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_cerrar.IconSize = 20;
            this.Btn_cerrar.Location = new System.Drawing.Point(987, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(45, 25);
            this.Btn_cerrar.TabIndex = 6;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_maximizar
            // 
            this.Btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_maximizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_maximizar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_maximizar.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.Btn_maximizar.IconColor = System.Drawing.Color.White;
            this.Btn_maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_maximizar.IconSize = 20;
            this.Btn_maximizar.Location = new System.Drawing.Point(946, 0);
            this.Btn_maximizar.Name = "Btn_maximizar";
            this.Btn_maximizar.Size = new System.Drawing.Size(45, 25);
            this.Btn_maximizar.TabIndex = 5;
            this.Btn_maximizar.UseVisualStyleBackColor = false;
            this.Btn_maximizar.Click += new System.EventHandler(this.Btn_maximizar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_minimizar.BackColor = System.Drawing.Color.Black;
            this.Btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Btn_minimizar.IconColor = System.Drawing.Color.White;
            this.Btn_minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_minimizar.IconSize = 20;
            this.Btn_minimizar.Location = new System.Drawing.Point(904, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(45, 25);
            this.Btn_minimizar.TabIndex = 4;
            this.Btn_minimizar.UseVisualStyleBackColor = false;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // TextoSeleccionado
            // 
            this.TextoSeleccionado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoSeleccionado.Location = new System.Drawing.Point(57, 63);
            this.TextoSeleccionado.Name = "TextoSeleccionado";
            this.TextoSeleccionado.Size = new System.Drawing.Size(158, 23);
            this.TextoSeleccionado.TabIndex = 3;
            this.TextoSeleccionado.Text = "HOME";
            // 
            // IconoSeleccionado
            // 
            this.IconoSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IconoSeleccionado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconoSeleccionado.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconoSeleccionado.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconoSeleccionado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoSeleccionado.Location = new System.Drawing.Point(6, 54);
            this.IconoSeleccionado.Name = "IconoSeleccionado";
            this.IconoSeleccionado.Size = new System.Drawing.Size(45, 32);
            this.IconoSeleccionado.TabIndex = 2;
            this.IconoSeleccionado.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1032, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROYECTO DE DESARROLLO DE SISTEMA DE INFORMACION PARA NEGOCIO DE COMIDAS RAPIDAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Size = new System.Drawing.Size(1032, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "P  R  O  D  I  S  I  C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pnl_barraestado
            // 
            this.Pnl_barraestado.BackColor = System.Drawing.Color.DimGray;
            this.Pnl_barraestado.Controls.Add(this.Grb_fechayhora);
            this.Pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_barraestado.Location = new System.Drawing.Point(252, 591);
            this.Pnl_barraestado.Name = "Pnl_barraestado";
            this.Pnl_barraestado.Size = new System.Drawing.Size(1032, 82);
            this.Pnl_barraestado.TabIndex = 2;
            // 
            // Grb_fechayhora
            // 
            this.Grb_fechayhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Grb_fechayhora.Controls.Add(this.Lbl_fecha);
            this.Grb_fechayhora.Controls.Add(this.Lbl_hora);
            this.Grb_fechayhora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grb_fechayhora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Grb_fechayhora.Location = new System.Drawing.Point(700, 6);
            this.Grb_fechayhora.Name = "Grb_fechayhora";
            this.Grb_fechayhora.Size = new System.Drawing.Size(320, 66);
            this.Grb_fechayhora.TabIndex = 0;
            this.Grb_fechayhora.TabStop = false;
            this.Grb_fechayhora.Text = "Fecha y hora del sistema";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(3, 45);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(58, 18);
            this.Lbl_fecha.TabIndex = 1;
            this.Lbl_fecha.Text = "Fecha";
            this.Lbl_fecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_hora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.Location = new System.Drawing.Point(3, 21);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(60, 24);
            this.Lbl_hora.TabIndex = 0;
            this.Lbl_hora.Text = "Hora";
            this.Lbl_hora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pnl_contenido
            // 
            this.Pnl_contenido.AutoScroll = true;
            this.Pnl_contenido.BackColor = System.Drawing.Color.White;
            this.Pnl_contenido.Controls.Add(this.Pnl_logoPRODISIC);
            this.Pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_contenido.Location = new System.Drawing.Point(252, 91);
            this.Pnl_contenido.Name = "Pnl_contenido";
            this.Pnl_contenido.Size = new System.Drawing.Size(1032, 500);
            this.Pnl_contenido.TabIndex = 3;
            // 
            // Pnl_logoPRODISIC
            // 
            this.Pnl_logoPRODISIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_logoPRODISIC.Controls.Add(this.label7);
            this.Pnl_logoPRODISIC.Controls.Add(this.label5);
            this.Pnl_logoPRODISIC.Controls.Add(this.label4);
            this.Pnl_logoPRODISIC.Controls.Add(this.label3);
            this.Pnl_logoPRODISIC.Controls.Add(this.pictureBox1);
            this.Pnl_logoPRODISIC.Location = new System.Drawing.Point(246, 90);
            this.Pnl_logoPRODISIC.Name = "Pnl_logoPRODISIC";
            this.Pnl_logoPRODISIC.Size = new System.Drawing.Size(500, 361);
            this.Pnl_logoPRODISIC.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(147, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "REALIZADO POR APRENDIZ MARTIN VASQUEZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(221, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "FICHA 2281978";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(196, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "PROYECTO SENA DE ADSI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(203, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "VERSION 0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRODISIC.Presentacion.Properties.Resources.Logo_PRODISIC;
            this.pictureBox1.Location = new System.Drawing.Point(100, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.Pnl_contenido);
            this.Controls.Add(this.Pnl_barraestado);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Pnl_menu);
            this.Name = "Frm_DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DashBoard";
            this.Pnl_menu.ResumeLayout(false);
            this.Pnl_datosmaestros.ResumeLayout(false);
            this.Pnl_reportes.ResumeLayout(false);
            this.Pnl_procesos.ResumeLayout(false);
            this.Pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_logo)).EndInit();
            this.Pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoSeleccionado)).EndInit();
            this.Pnl_barraestado.ResumeLayout(false);
            this.Grb_fechayhora.ResumeLayout(false);
            this.Grb_fechayhora.PerformLayout();
            this.Pnl_contenido.ResumeLayout(false);
            this.Pnl_logoPRODISIC.ResumeLayout(false);
            this.Pnl_logoPRODISIC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_menu;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Panel Pnl_barraestado;
        private System.Windows.Forms.Panel Pnl_contenido;
        private System.Windows.Forms.Panel Pnl_logo;
        private System.Windows.Forms.PictureBox Pct_logo;
        private FontAwesome.Sharp.IconButton Btn_Dashboard;
        private FontAwesome.Sharp.IconButton Btn_Procesos;
        private System.Windows.Forms.Panel Pnl_procesos;
        private FontAwesome.Sharp.IconButton PR_registrarpedido;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel Pnl_reportes;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton Btn_reportes;
        private FontAwesome.Sharp.IconButton CerrarSesion;
        private System.Windows.Forms.Panel Pnl_datosmaestros;
        private FontAwesome.Sharp.IconButton DM_medidas;
        private FontAwesome.Sharp.IconButton DM_marcas;
        private FontAwesome.Sharp.IconButton DM_productos;
        private FontAwesome.Sharp.IconButton Btn_datosmaestros;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Grb_fechayhora;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TextoSeleccionado;
        private FontAwesome.Sharp.IconPictureBox IconoSeleccionado;
        private FontAwesome.Sharp.IconButton Btn_minimizar;
        private FontAwesome.Sharp.IconButton Btn_maximizar;
        private FontAwesome.Sharp.IconButton Btn_cerrar;
        private System.Windows.Forms.Panel Pnl_logoPRODISIC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton DM_subfamilias;
        private FontAwesome.Sharp.IconButton DM_puntoventas;
        private FontAwesome.Sharp.IconButton DM_Familias;
        private FontAwesome.Sharp.IconButton DM_areadespacho;
        private FontAwesome.Sharp.IconButton DM_mesas;
    }
}