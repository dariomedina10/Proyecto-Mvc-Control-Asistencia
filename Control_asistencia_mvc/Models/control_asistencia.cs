using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Control_asistencia_mvc.Models
{
    public class control_asistencia
    {

        public int id_control { get; set; }
        public DateTime fecha { get; set; }
        public int id_turno { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_salida { get; set; }
       
        public int id_empl { get; set; }
    
    }
}