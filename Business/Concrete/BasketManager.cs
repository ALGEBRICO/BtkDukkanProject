using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private IBasketDal _basketDal;
        private IProductService _productService;

        public BasketManager(IBasketDal basketDal,IProductService productService)
        {
            _basketDal = basketDal;
            _productService = productService;
        }

        public IResult Add(Basket basket)
        {
            _basketDal.Add(basket);
            return new SuccessResult("Ürün sepete eklendi");

        }

        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(),"Sepetteki ürünler listelendi.");
        }
    }
}
