using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestCuenta.Entidad
{
    public class Cuenta
    {
        [Key]
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public bool tieneAcceso { get; set; }
    }
}
