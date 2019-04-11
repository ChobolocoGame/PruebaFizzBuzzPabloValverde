using System.ComponentModel.DataAnnotations;

/*Declaramos campo requerido y Number nullable*/
namespace WebApplication2.ViewModels.Home
{
    public class IndexViewModel
    {
        [Required, Range(1, 100)]
        public int? Number { get; set; }
        public string Result { get; set; }
    }
}