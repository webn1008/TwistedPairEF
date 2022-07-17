using System.ComponentModel.DataAnnotations;

namespace TwistedPairEF.Models
{
    public class PairModel
    {
        public int Id { get; set; }
        [Required]
        [Range(26, 600)]
        public int PairNumber { get; set; } = 0;
        public string? FirstPair { get; set; }
        public string? SecondPair { get; set; }
        public string? FirstBinderColor { get; set; }
        public string? SecondBinderColor { get; set; }

    }
}
