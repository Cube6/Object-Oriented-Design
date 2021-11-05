using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory.Structuralcode
{
	public class SimpleFactory
	{
		public AbstractProduct CreateProduct(ProductType productType)
		{
			switch (productType)
			{
				case ProductType.Type1:
					return new ConcreteProduct1();
				case ProductType.Type2:
					return new ConcreteProduct2();
				default:
					return null;
			}
		}
	}
}
