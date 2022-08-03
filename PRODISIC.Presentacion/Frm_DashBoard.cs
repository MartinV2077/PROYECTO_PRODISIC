using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PRODISIC.Presentacion
{
    public partial class Frm_DashBoard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Frm_DashBoard()
        {
            InitializeComponent();
            CustomizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 46);
            Pnl_menu.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Mis Metodos"
        private void CustomizeDesing()
        {
            Pnl_procesos.Visible = false;
            Pnl_reportes.Visible=false;
            Pnl_datosmaestros.Visible = false;
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
