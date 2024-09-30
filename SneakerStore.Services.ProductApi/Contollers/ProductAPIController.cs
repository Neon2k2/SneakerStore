using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SneakerStore.Services.CouponAPI.Data;
using SneakerStore.Services.ProductApi.Model.Dto;
using SneakerStore.Services.ProductApi.Models;
using SneakerStore.Services.ProductApi.Models.Dto;

namespace SneakerStore.Services.ProductApi.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductAPIController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _db;
        private readonly ResponseDto _response;

        public ProductAPIController(IMapper mapper, AppDbContext db)
        {
            _mapper = mapper;
            _db = db;
            _response = new ResponseDto();
        }

        public IMapper Mapper { get; }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Product> objList = _db.Products.ToList();
                _response.Result = _mapper.Map<IEnumerable<ProductDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]

        public ResponseDto Get(int id)
        {
            try
            {
                Product product = _db.Products.First(u => u.ProductId == id);
                _response.Result = product;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;

        }

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Post([FromBody] ProductDto productDto)
        {
            try
            {
                Product product = _mapper.Map<Product>(productDto);
                _db.Products.Add(product);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ProductDto>(product);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Put([FromBody] ProductDto productDto)
        {
            try
            {
                Product product = _mapper.Map<Product>(productDto);
                _db.Products.Update(product);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ProductDto>(product);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }


        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Product product = _db.Products.First(u => u.ProductId == id);
                _db.Products.Remove(product);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ProductDto>(product);
                _response.IsSuccess = true;
                _response.Message = $"Coupon code {product.Name} has been Deleted";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;

        }
    }
}
