using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepasoMVCvehiculos.Models;

namespace RepasoMVCvehiculos.Datos
{
    public class VehiculoAdmin
    {
        public IEnumerable<VEHICULOS> consultar()
        {
            using (REPASO_DBEntities contexto = new REPASO_DBEntities())
            {
                return contexto.VEHICULOS.AsNoTracking().ToList();

            }
        }
        //Guardar un vehiculo en la base de datos
        public void Guardar(VEHICULOS modelo)
        {
            using(REPASO_DBEntities contexto = new REPASO_DBEntities())
            {
                contexto.VEHICULOS.Add(modelo);
                contexto.SaveChanges();
            }
        }
    }
}