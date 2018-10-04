using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Control_asistencia_mvc.Models
{
    public class Cargos
    {
       [Key]
        public int id_cargo { get; set; }
        public string descripcion { get; set; }
    }
}