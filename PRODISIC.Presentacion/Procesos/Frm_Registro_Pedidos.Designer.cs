namespace PRODISIC.Presentacion.Procesos
{
    partial class Frm_Registro_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro_Pedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_titulo_form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Pnl_superior = new System.Windows.Forms.Panel();
            this.Pnl_Listado_1 = new System.Windows.Forms.Panel();
            this.Btn_retornar1 = new System.Windows.Forms.Button();
            this.Dgv_1 = new System.Windows.Forms.DataGridView();
            this.Lbl_mensaje = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_turno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_fechatrabajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_lupa1 = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Txt_puntoventa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_titulo_mesas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_titulo_form.SuspendLayout();
            this.Pnl_superior.SuspendLayout();
            this.Pnl_Listado_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_1)).BeginInit();
            this.Pnl_titulo_mesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_titulo_form
            // 
            this.Pnl_titulo_form.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Pnl_titulo_form.Controls.Add(this.label3);
            this.Pnl_titulo_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo_form.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo_form.Name = "Pnl_titulo_form";
            this.Pnl_titulo_form.Size = new System.Drawing.Size(984, 36);
            this.Pnl_titulo_form.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "REGISTRAR PEDIDOS";
            // 
            // Pnl_superior
            // 
            this.Pnl_superior.BackColor = System.Drawing.Color.OrangeRed;
            this.Pnl_superior.Controls.Add(this.Pnl_Listado_1);
            this.Pnl_superior.Controls.Add(this.Lbl_mensaje);
            this.Pnl_superior.Controls.Add(this.Txt_estado);
            this.Pnl_superior.Controls.Add(this.label6);
            this.Pnl_superior.Controls.Add(this.Txt_turno);
            this.Pnl_superior.Controls.Add(this.label5);
            this.Pnl_superior.Controls.Add(this.Txt_fechatrabajo);
            this.Pnl_superior.Controls.Add(this.label4);
            this.Pnl_superior.Controls.Add(this.Btn_lupa1);
            this.Pnl_superior.Controls.Add(this.Btn_salir);
            this.Pnl_superior.Controls.Add(this.Txt_puntoventa);
            this.Pnl_superior.Controls.Add(this.label2);
            this.Pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_superior.Location = new System.Drawing.Point(0, 36);
            this.Pnl_superior.Name = "Pnl_superior";
            this.Pnl_superior.Size = new System.Drawing.Size(984, 140);
            this.Pnl_superior.TabIndex = 8;
            // 
            // Pnl_Listado_1
            // 
            this.Pnl_Listado_1.BackColor = System.Drawing.Color.LightCyan;
            this.Pnl_Listado_1.Controls.Add(this.Btn_retornar1);
            this.Pnl_Listado_1.Controls.Add(this.Dgv_1);
            this.Pnl_Listado_1.Location = new System.Drawing.Point(223, 8);
            this.Pnl_Listado_1.Name = "Pnl_Listado_1";
            this.Pnl_Listado_1.Size = new System.Drawing.Size(291, 106);
            this.Pnl_Listado_1.TabIndex = 15;
            this.Pnl_Listado_1.Visible = false;
            // 
            // Btn_retornar1
            // 
            this.Btn_retornar1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_retornar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar1.Image = ((System.Drawing.Image)(resources.GetObject("Btn_retornar1.Image")));
            this.Btn_retornar1.Location = new System.Drawing.Point(248, 3);
            this.Btn_retornar1.Name = "Btn_retornar1";
            this.Btn_retornar1.Size = new System.Drawing.Size(34, 27);
            this.Btn_retornar1.TabIndex = 13;
            this.Btn_retornar1.UseVisualStyleBackColor = true;
            this.Btn_retornar1.Click += new System.EventHandler(this.Btn_retornar1_Click);
            // 
            // Dgv_1
            // 
            this.Dgv_1.AllowUserToAddRows = false;
            this.Dgv_1.AllowUserToDeleteRows = false;
            this.Dgv_1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dgv_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_1.ColumnHeadersHeight = 34;
            this.Dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_1.EnableHeadersVisualStyles = false;
            this.Dgv_1.Location = new System.Drawing.Point(3, 3);
            this.Dgv_1.Name = "Dgv_1";
            this.Dgv_1.ReadOnly = true;
            this.Dgv_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_1.Size = new System.Drawing.Size(239, 100);
            this.Dgv_1.TabIndex = 12;
            this.Dgv_1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_1_CellDoubleClick);
            // 
            // Lbl_mensaje
            // 
            this.Lbl_mensaje.BackColor = System.Drawing.Color.Thistle;
            this.Lbl_mensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_mensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mensaje.ForeColor = System.Drawing.Color.Red;
            this.Lbl_mensaje.Location = new System.Drawing.Point(0, 117);
            this.Lbl_mensaje.Name = "Lbl_mensaje";
            this.Lbl_mensaje.Size = new System.Drawing.Size(984, 23);
            this.Lbl_mensaje.TabIndex = 14;
            this.Lbl_mensaje.Text = "Mensaje";
            this.Lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(531, 64);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.ReadOnly = true;
            this.Txt_estado.Size = new System.Drawing.Size(103, 22);
            this.Txt_estado.TabIndex = 13;
            this.Txt_estado.Text = "Estado x";
            this.Txt_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(553, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "ESTADO";
            // 
            // Txt_turno
            // 
            this.Txt_turno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_turno.Location = new System.Drawing.Point(411, 64);
            this.Txt_turno.Name = "Txt_turno";
            this.Txt_turno.ReadOnly = true;
            this.Txt_turno.Size = new System.Drawing.Size(103, 22);
            this.Txt_turno.TabIndex = 11;
            this.Txt_turno.Text = "Turno x";
            this.Txt_turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(438, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "TURNO";
            // 
            // Txt_fechatrabajo
            // 
            this.Txt_fechatrabajo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fechatrabajo.Location = new System.Drawing.Point(250, 66);
            this.Txt_fechatrabajo.Name = "Txt_fechatrabajo";
            this.Txt_fechatrabajo.ReadOnly = true;
            this.Txt_fechatrabajo.Size = new System.Drawing.Size(133, 22);
            this.Txt_fechatrabajo.TabIndex = 9;
            this.Txt_fechatrabajo.Text = "Fecha de trabajo x";
            this.Txt_fechatrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(250, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "FECHA DE TRABAJO";
            // 
            // Btn_lupa1
            // 
            this.Btn_lupa1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_lupa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lupa1.Image = ((System.Drawing.Image)(resources.GetObject("Btn_lupa1.Image")));
            this.Btn_lupa1.Location = new System.Drawing.Point(193, 58);
            this.Btn_lupa1.Name = "Btn_lupa1";
            this.Btn_lupa1.Size = new System.Drawing.Size(35, 34);
            this.Btn_lupa1.TabIndex = 7;
            this.Btn_lupa1.UseVisualStyleBackColor = true;
            this.Btn_lupa1.Click += new System.EventHandler(this.Btn_lupa1_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_salir.BackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.Btn_salir.FlatAppearance.BorderSize = 2;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_salir.ImageKey = "salir.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(853, 32);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(90, 60);
            this.Btn_salir.TabIndex = 6;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            // 
            // Txt_puntoventa
            // 
            this.Txt_puntoventa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_puntoventa.Location = new System.Drawing.Point(25, 64);
            this.Txt_puntoventa.Name = "Txt_puntoventa";
            this.Txt_puntoventa.ReadOnly = true;
            this.Txt_puntoventa.Size = new System.Drawing.Size(162, 22);
            this.Txt_puntoventa.TabIndex = 1;
            this.Txt_puntoventa.Text = "Punto de venta x";
            this.Txt_puntoventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "PUNTO DE VENTA";
            // 
            // Pnl_titulo_mesas
            // 
            this.Pnl_titulo_mesas.BackColor = System.Drawing.Color.SaddleBrown;
            this.Pnl_titulo_mesas.Controls.Add(this.label1);
            this.Pnl_titulo_mesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo_mesas.Location = new System.Drawing.Point(0, 176);
            this.Pnl_titulo_mesas.Name = "Pnl_titulo_mesas";
            this.Pnl_titulo_mesas.Size = new System.Drawing.Size(984, 40);
            this.Pnl_titulo_mesas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = ": : : MESAS : : :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 216);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 384);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Registro_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Pnl_titulo_mesas);
            this.Controls.Add(this.Pnl_superior);
            this.Controls.Add(this.Pnl_titulo_form);
            this.Name = "Frm_Registro_Pedidos";
            this.Text = "Frm_Registro_Pedidos";
            this.Load += new System.EventHandler(this.Frm_Registro_Pedidos_Load);
            this.Pnl_titulo_form.ResumeLayout(false);
            this.Pnl_titulo_form.PerformLayout();
            this.Pnl_superior.ResumeLayout(false);
            this.Pnl_superior.PerformLayout();
            this.Pnl_Listado_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_1)).EndInit();
            this.Pnl_titulo_mesas.ResumeLayout(false);
            this.Pnl_titulo_mesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pnl_superior;
        private System.Windows.Forms.Panel Pnl_titulo_mesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Txt_puntoventa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_lupa1;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_turno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_fechatrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_mensaje;
        private System.Windows.Forms.Panel Pnl_Listado_1;
        private System.Windows.Forms.Button Btn_retornar1;
        private System.Windows.Forms.DataGridView Dgv_1;
        private System.Windows.Forms.Timer timer1;
    }
}