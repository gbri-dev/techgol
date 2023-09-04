using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pratice_web.Models
{
    [Table("Categorias")]
    public class Category
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria")]
        [StringLength(50, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [Display(Name = "Nome")]
        public string CategoriaName { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para a categoria")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //Uma categoria possui muitos lanches
        public List<Product> Products { get; set; }

    }
}
