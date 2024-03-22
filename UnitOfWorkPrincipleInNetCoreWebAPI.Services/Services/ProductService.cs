using UnitOfWorkPrincipleInNetCoreWebAPI.Core.Interfaces;
using UnitOfWorkPrincipleInNetCoreWebAPI.Core.Model;
using UnitOfWorkPrincipleInNetCoreWebAPI.Core.Specifications;

namespace UnitOfWorkPrincipleInNetCoreWebAPI.Services.Services
{
    public class ProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _unitOfWork.Repository<Product>().ListAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _unitOfWork.Repository<Product>().GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _unitOfWork.Repository<ProductBrand>().ListAllAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _unitOfWork.Repository<ProductType>().ListAllAsync();
        }

        public async Task<IReadOnlyList<Product>> GetProductsByBrandIdAsync(int brandId)
        {
            var spec = new ProductsWithTypesAndBrandsSpecification(brandId);
            return await _unitOfWork.Repository<Product>().ListAsync(spec);
        }

        public async Task<IReadOnlyList<Product>> GetProductsByTypeIdAsync(int typeId)
        {
            var spec = new ProductsWithTypesAndBrandsSpecification(typeId);
            return await _unitOfWork.Repository<Product>().ListAsync(spec);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            _unitOfWork.Repository<Product>().Add(product);
            await _unitOfWork.Complete();
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            _unitOfWork.Repository<Product>().Update(product);
            await _unitOfWork.Complete();
            return product;
        }

        public async Task DeleteProductAsync(Product product)
        {
            _unitOfWork.Repository<Product>().Delete(product);
            await _unitOfWork.Complete();
        }
    }
}
