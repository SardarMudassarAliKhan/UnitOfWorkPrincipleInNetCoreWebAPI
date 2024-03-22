using UnitOfWorkPrincipleInNetCoreWebAPI.Core.Model;

namespace UnitOfWorkPrincipleInNetCoreWebAPI.Services.IServices
{
    public interface IProductService
    {
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
        Task<IReadOnlyList<Product>> GetProductsByBrandIdAsync(int brandId);
        Task<IReadOnlyList<Product>> GetProductsByTypeIdAsync(int typeId);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task DeleteProductAsync(Product product);
    }
}
