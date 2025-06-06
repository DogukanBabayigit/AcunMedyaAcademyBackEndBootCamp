using System;
using System.Text.Json.Serialization;

namespace EShop.MVC.Models
{
    public class CategoryModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("createDate")]
        public DateTime CreateDate { get; set; }

        [JsonPropertyName("updatedDate")]
        public DateTime UpdatedDate { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; } = null!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = null!;

        // İlgili kategorideki ürünlerin sayısını veren bir propety ekleyin. Bunun için API tarafında yapılması gerekenleri yapın.
    }
}
