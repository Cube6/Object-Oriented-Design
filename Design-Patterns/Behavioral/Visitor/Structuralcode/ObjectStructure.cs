using System.Collections.Generic;

namespace Design_Patterns.Behavioral.Visitor.Structuralcode
{
	public class ObjectStructure
	{
		List<Element> elements = new List<Element>();

		public void Attach(Element element)
		{
			elements.Add(element);
		}

		public void Detach(Element element)
		{
			elements.Remove(element);
		}

		public void Accept(Visitor visitor)
		{
			foreach (Element element in elements)
			{
				element.Accept(visitor);
			}
		}
	}
}
