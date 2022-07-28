using System.ComponentModel.DataAnnotations;
namespace TwistedPairEF.Models
{
    public class PairModel
    {
        public int Id { get; set; }
        
        [Range(1, 600)]
        public int PairNumber { get; set; }
        public string? FirstColor { get; set; }
        public string? SecondColor { get; set; }
        public string? FirstBinderColor { get; set; }
        public string? SecondBinderColor { get; set; }

    }
}
