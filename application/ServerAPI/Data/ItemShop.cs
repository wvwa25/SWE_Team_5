using System.Text.Json.Serialization;

namespace ServerAPI.Data
{
	public class ItemShop
	{
		[JsonPropertyName("name")]
		public string? Name { get; set; }
		[JsonPropertyName("_id")]
		public string? ID { get; set; }
		[JsonPropertyName("price")]
		public string? Price { get; set; }
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }
		[JsonPropertyName("email")]
		public string? Email { get; set; }
		[JsonPropertyName("password")]
		public string? Password { get; set; }
		[JsonPropertyName("role")]
		public string? Role { get; set; }
	}
	

}
