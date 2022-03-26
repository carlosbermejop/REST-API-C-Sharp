using System.ComponentModel.DataAnnotations;

namespace Catalog
{
    public record ItemDTO(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);
    public record CreateItemDTO([Required] string Name, string Description, [Range(1, 1000)] decimal Price);
    public record UpdateItemDTO([Required] string Name, string Description, [Range(1, 1000)] decimal Price);
}
