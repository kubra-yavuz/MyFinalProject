using System;
using System.Text;
using System.Collections.Generic;
using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
	public interface IProductDal:IEntityRepository<Product>
	{
		
	}
}

