namespace Design_Patterns
{
	public class BookFactory
	{
		public IBook QueryBook(int id)
		{
			IBook book;
			switch (id)
			{
				case 1:
					book = new Book(id);
					break;
				case 2:
					book = new Book(id);
					break;
				default:
					// book = null;
					book = new NullBook(id);//创建一个NullBook对象
					break;
			}

			return book;
		}
	}
}




