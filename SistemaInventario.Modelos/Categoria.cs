using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="El nombre debe de tener maximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(100, ErrorMessage = "La descripion debe de tener maximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="El estado es Requerido")]
        public bool Estado { get; set; }
    }
}
