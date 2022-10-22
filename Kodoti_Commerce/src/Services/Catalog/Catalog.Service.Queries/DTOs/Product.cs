namespace Catalog.Service.Queries.DTOs
{
     public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductInStockDto Stock { get; set; } //esto es para crear la relacion entre el product y el stock uno a uno
                                                  //si se requiere de a muchos es con una lista List<ProductInStock>
    }
}
