using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRODISIC.Entidades;
using PRODISIC.Negocio;
using System.IO;

namespace PRODISIC.Presentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"

        int nCodigo = 0;
        int nCodigo_ma = 0;
        int nCodigo_um = 0;
        int nCodigo_sf = 0;
        int nCodigo_ad = 0;
        int Estadoguarda = 0;
        DataTable Dtdetalle = new DataTable();
        #endregion

        #region "Mis Metodos"

        private void Formato_pr()
        {
            Dgv_Listado.Columns[0].Width = 90;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_PR";
            Dgv_Listado.Columns[1].Width = 260;
            Dgv_Listado.Columns[1].HeaderText = "PRODUCTO";
            Dgv_Listado.Columns[2].Width = 150;
            Dgv_Listado.Columns[2].HeaderText = "MARCA";
            Dgv_Listado.Columns[3].Width = 100;
            Dgv_Listado.Columns[3].HeaderText = "MEDIDA";
            Dgv_Listado.Columns[4].Width = 150;
            Dgv_Listado.Columns[4].HeaderText = "SUBFAMILIA";
            Dgv_Listado.Columns[5].Width = 90;
            Dgv_Listado.Columns[5].HeaderText = "P.UNITARIO";
            Dgv_Listado.Columns[6].Width = 150;
            Dgv_Listado.Columns[6].HeaderText = "ÁREA DESPACHO";
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;
            Dgv_Listado.Columns[11].Visible = false;
        }

        private void Formato_ma()
        {
            Dgv_1.Columns[0].Visible = false;
            Dgv_1.Columns[1].Width = 320;
            Dgv_1.Columns[1].HeaderText = "MARCA";
            
        }

        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Productos.Listado_pr(cTexto);
                this.Formato_pr();
                Lbl_totalregistros.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

       private void Listado_ma(string cTexto)
        {
            try
            {
                Dgv_1.DataSource = N_Productos.Listado_ma(cTexto);
                this.Formato_ma();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpia_Texto()
        {
            Txt_descripcion_pr.Text = "";
            Txt_descripcion_ma.Text = "";
            Txt_descripcion_um.Text = "";
            Txt_descripcion_sf.Text = "";
            Txt_precio_unitario.Text = "0.00";
            Txt_descripcion_ad.Text = "";
            Txt_observacion.Text = "";
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }

        private void Estado_Texto(bool lEstado)
        {
            Txt_descripcion_pr.ReadOnly = !lEstado;
            Txt_precio_unitario.ReadOnly = !lEstado;
            Txt_observacion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;
            Btn_retornar.Visible = !lEstado;
            Btn_lupa_ma.Visible=lEstado;
        }

        private void Mostrar_img(int nCodigo_pr)
        {
            Byte[] bImagen = new byte[0];
            bImagen = N_Productos.Mostrar_img(nCodigo_pr);
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void Crear_Tabla_pv()
        {
            this.Dtdetalle = new DataTable("Detalle");
            this.Dtdetalle.Columns.Add("Descripcion_pv", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("OK", System.Type.GetType("System.Boolean"));
            this.Dtdetalle.Columns.Add("Codigo_pv", System.Type.GetType("System.Int32"));

            Dgv_PuntosVentas.DataSource = this.Dtdetalle;

            Dgv_PuntosVentas.Columns[0].Width = 220;
            Dgv_PuntosVentas.Columns[0].HeaderText = "PUNTO DE VENTA";
            Dgv_PuntosVentas.Columns[0].ReadOnly = true;
            Dgv_PuntosVentas.Columns[1].Width = 45;
            Dgv_PuntosVentas.Columns[1].HeaderText = "OK";
            Dgv_PuntosVentas.Columns[1].ReadOnly = true;
            Dgv_PuntosVentas.Columns[2].Visible = false;
        }

        private void Agregar_pv(string Descripcion_pv, bool OK, int nCodigo_pv)
        {
            DataRow Fila = Dtdetalle.NewRow();
            Fila["Descripcion_pv"] = Descripcion_pv;
            Fila["OK"] = OK;
            Fila["Codigo_pv"] = nCodigo_pv;
            this.Dtdetalle.Rows.Add(Fila);
        }

        private void Puntos_Ventas_OK(int nOpcion, int nCodigo_pr)
        {
            try
            {
                DataTable Tablatemp = new DataTable();
                Tablatemp = N_Productos.Puntos_Ventas_OK(nOpcion, nCodigo_pr);
                Dtdetalle.Clear();
                for (int nFila = 0; nFila <= Tablatemp.Rows.Count - 1; nFila++)
                {
                    this.Agregar_pv(Convert.ToString(Tablatemp.Rows[nFila][0]),
                                   Convert.ToBoolean(Tablatemp.Rows[nFila][1]),
                                   Convert.ToInt32(Tablatemp.Rows[nFila][2]));
                }
                Dgv_PuntosVentas.DataSource = Dtdetalle;

                if (nOpcion >= 1)
                {
                    Dgv_PuntosVentas.Columns["OK"].ReadOnly = false;
                }
                else
                {
                    Dgv_PuntosVentas.Columns["OK"].ReadOnly = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_pr"].Value);
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ma"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_um"].Value);
                Txt_descripcion_sf.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value);
                Txt_precio_unitario.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["precio_unitario"].Value);
                Txt_descripcion_ad.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ad"].Value);
                Txt_observacion.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["observacion"].Value);

                this.nCodigo_ma = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ma"].Value);
                this.nCodigo_um = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_um"].Value);
                this.nCodigo_sf = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value);
                this.nCodigo_ad = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ad"].Value);
                this.Mostrar_img(this.nCodigo);
                this.Puntos_Ventas_OK(this.Estadoguarda, this.nCodigo);
            }
        }

        private void Selecciona_item_ma()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_1.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_1.CurrentRow.Cells["descripcion_ma"].Value);
                this.nCodigo_ma = Convert.ToInt32(Dgv_1.CurrentRow.Cells["codigo_ma"].Value);
            }
        }

        #endregion

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_pr("%");
            this.Listado_ma("%");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Estadoguarda = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.Limpia_Texto();
            this.Estado_Texto(true);
            Tbc_principal.SelectedIndex = 1;
            Btn_lupa_ma.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_Texto();
            this.Estado_Texto(false);
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tbc_principal.SelectedIndex = 0;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            Tbc_principal.SelectedIndex = 0;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_precio_unitario.Text == String.Empty || Txt_descripcion_sf.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Rpta = "";
                    E_SubFamilias oPropiedad = new E_SubFamilias();
                    oPropiedad.Codigo_sf = this.nCodigo;
                    oPropiedad.Descripcion_sf = Txt_observacion.Text.Trim();
                    oPropiedad.Codigo_fa = this.nCodigo_ma;
                    Rpta = N_SubFamilias.Guardar_sf(this.Estadoguarda,oPropiedad); 
                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        this.Limpia_Texto();
                        this.Estado_Texto(false);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_BotonesProcesos(false);
                        this.Estadoguarda = 0;
                        this.nCodigo = 0;
                        this.nCodigo_ma = 0;
                        this.Listado_pr("%");
                        Tbc_principal.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta, 
                                        "Aviso del sistema", 
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                this.Estadoguarda = 2; //Actualiza registro
                this.Estado_BotonesPrincipales(false);
                this.Estado_BotonesProcesos(true);
                this.Estado_Texto(true);
                this.Limpia_Texto();
                this.Selecciona_item();
                Tbc_principal.SelectedIndex = 1;
                Txt_descripcion_pr.Focus();
            }
        }


        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Estadoguarda == 0)
            {
                this.Selecciona_item();
                this.Estado_BotonesProcesos(false);
                Tbc_principal.SelectedIndex = 1;
            }

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de eliminar el registro seleccionado?",
                                        "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion==DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Selecciona_item();
                    Rpta = N_SubFamilias.Eliminar_sf(this.nCodigo);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_pr("%");
                        MessageBox.Show("EL registro ha sido eliminado",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        this.nCodigo = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                    this.Limpia_Texto();
                }
                
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pr(txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
           if (Dgv_Listado.Rows.Count > 0)
            {
                Reportes.Frm_Rpt_SubFamilias oRpt_sf = new Reportes.Frm_Rpt_SubFamilias();
                oRpt_sf.Txt_p1.Text = txt_buscar.Text.Trim();
                oRpt_sf.ShowDialog();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_ma();
            Pnl_Listado_1.Visible = false;
            Txt_observacion.Focus();
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Listado_fa(Txt_buscar1.Text.Trim());
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            //Pnl_Listado_1.Location = Btn_lupa1.Location;
            Pnl_Listado_1.Visible = true;
            Txt_buscar1.Focus();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
