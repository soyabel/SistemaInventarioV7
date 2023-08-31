using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="El nombre debe ser maximo de 06 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion es Requerido")]
        [MaxLength(100, ErrorMessage = "La descripcion debe ser maximo de 06 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es Requerido")]
        public bool Estado { get; set; }

    }
}
