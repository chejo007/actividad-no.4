using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEmpresa.Models
{
    public class Proveedores
    {
        [Key]
        public int IdProveedor { get; set; }
        public string? Nit { get; set; }
        public string? NombreProveedor { get; set; }
        public string? Direccion { get; set; }
        public string? RazonSocial { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
