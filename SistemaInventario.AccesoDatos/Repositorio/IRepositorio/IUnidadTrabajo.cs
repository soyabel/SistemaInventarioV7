using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable //Te permite desacerte de cualquier recurso que obteniste del sistema y asi liberarlo
    {
        IBodegaRepositorio Bodega { get; }
        Task Guardar();
    }
}
