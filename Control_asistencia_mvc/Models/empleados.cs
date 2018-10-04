using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Control_asistencia_mvc.Models
{
    public class empleados
    {

        public int id_empl { get; set; }
        public string nombres { get; set; }
        public string apelli { get; set; }
        public int id_cargo { get; set; }
        public int id_depto { get; set; }
        public DateTime fecha_ingreso { get; set; }

        public int id_tipo_empl { get; set; }
    }
}