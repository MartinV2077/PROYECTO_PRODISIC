using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PRODISIC.Entidades;
using PRODISIC.Datos;

namespace PRODISIC.Negocio
{
    public class N_Prodisic_Venta
    {
        public static DataTable Listado_pv(string cTexto)
        {
            D_Prodisic_Venta Datos = new D_Prodisic_Venta();
            return Datos.Listado_pv(cTexto);
        }

        public static string Guardar_pv(int nOpcion, E_Prodisic_Venta oPropiedad)
        {
            D_Prodisic_Venta Datos = new D_Prodisic_Venta();
            return Datos.Guardar_pv(nOpcion, oPropiedad);
        }

        public static string Eliminar_pv(int Ncodigo)
        {
            D_Prodisic_Venta Datos = new D_Prodisic_Venta();
            return Datos.Eliminar_pv(Ncodigo);
        }
    }
}
