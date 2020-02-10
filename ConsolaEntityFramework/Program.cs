using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Monto");
            dt.Columns.Add("Concepto");
            dt.Columns.Add("Direccion");
            List<SPGetFactura_Result> listFactura = new List<SPGetFactura_Result>();

            using (PruebaEntities entity = new PruebaEntities())
            {
                listFactura = entity.SPGetFactura(id).ToList();
            }

            foreach(var fac in listFactura)
            {
                dt.Rows.Add(fac.Id, fac.Monto, fac.Concepto, fac.Direccion);
            }
        }
    }
}
