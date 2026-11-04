using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN_FRGP_ActividadII
{
    internal class Articulo
    {
       
        
        public int CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public List<Imagen> Imagenes { get; set } = new List<Imagen>();
        public float Precio { get; set; }

        
    }
}
