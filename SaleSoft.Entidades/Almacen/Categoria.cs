using System.ComponentModel.DataAnnotations;

namespace SaleSoft.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El {0}, debe estar en {2} y {1} caracteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

    }
}
