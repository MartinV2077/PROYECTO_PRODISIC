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

     
    }
}
