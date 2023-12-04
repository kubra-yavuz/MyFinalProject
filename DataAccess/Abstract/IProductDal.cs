﻿using System;
using System.Text;
using System.Collections.Generic;
using Entities.Concrete;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface IProductDal:IEntityRepository<Product>
	{
		List<ProductDetailDto> GetProductDetails();
	}
}

