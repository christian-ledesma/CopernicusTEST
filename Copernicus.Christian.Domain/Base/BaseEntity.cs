using System.ComponentModel.DataAnnotations;

namespace Copernicus.Christian.Domain.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
