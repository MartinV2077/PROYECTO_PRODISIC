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
    public class N_MesaAbierta
    {
        public static DataTable Listar_Subfamilias_RP(int nCodigo_pv)
        {
            D_MesaAbierta Datos = new D_MesaAbierta();
            return Datos.Listar_Subfamilias_RP(nCodigo_pv);
        }

        public static DataTable ListarProductos_SubFamilias_RP(int nCodigo_pv, int nCodigo_sf)
        {
            D_MesaAbierta Datos = new D_MesaAbierta();
            return Datos.ListarProductos_SubFamilias_RP(nCodigo_pv, nCodigo_sf);
        }

        public static DataTable Busquedarapida_pr(string cTexto)
        {
            D_MesaAbierta Datos = new D_MesaAbierta();
            return Datos.Busquedarapida_pr(cTexto);
        }

    }
}
