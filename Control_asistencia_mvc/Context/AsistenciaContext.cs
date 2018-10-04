using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Control_asistencia_mvc.Models;

namespace Control_asistencia_mvc.Context
{
    public class AsistenciaContext: DbContext
    {
       public DbSet<Cargos>Cargos { get; set; }
    }
}