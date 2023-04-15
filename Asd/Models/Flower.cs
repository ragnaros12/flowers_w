using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Asd.Models;

public class Flower
{
    public int Id { get; set; }

    [MinLength(3)]
    [Required]
    public string Name { get; set; } = default!;

    [Required]
    [Range(1, int.MaxValue)]
    public int Height { get; set; }

    public string Image { get; set; } = default!;

    [Required]
    [MinLength(10)]
	public string Description { get; set; } = default!;

    [Required]
    [Range(1, int.MaxValue)]
	public double Price { get; set; }
}