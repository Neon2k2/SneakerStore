using SneakerStore.Web.Models;

namespace SneakerStore.Web.Service.IService
{
    public interface IProductService
    {
        public Task<ResponseDto?> GetProductAsync(string name);
        public Task<ResponseDto?> GetAllProductsAsync();
        public Task<ResponseDto?> GetProductByIdAsync(int id);
        public Task<ResponseDto?> CreateProductsAsync(ProductDto productDto);
        public Task<ResponseDto?> UpdateProductsAsync(ProductDto productDto);
        public Task<ResponseDto?> DeleteProductsAsync(int productId);

    }
}
