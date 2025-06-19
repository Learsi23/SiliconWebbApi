using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;
    
public class CoursesEntity
{

    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public string? ImageName { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Discount { get; set; }
    public int Hours { get; set; }
    public bool IsBestSeller { get; set; }
    public bool IsDigital { get; set; }

    public string? LikesNumbers { get; set; }
    public string? LikesProcent { get; set; }

    public string? BigImageUrl { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime LastUpdated { get; set; }

    public int? CategoryId { get; set; }
    public CategoryEntity? Category { get; set; }

}
