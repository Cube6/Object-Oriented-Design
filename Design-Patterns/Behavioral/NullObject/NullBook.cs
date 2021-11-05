using System;

namespace Design_Patterns
{
	public class NullBook : IBook
	{
		public NullBook(int id) { }
		public bool IsNull()
		{
			return true;
		}

		public void Show()
		{
			Console.WriteLine("Sorry，未找到符合您输入的ID的图书信息，请确认您输入的不是非法值。");
		}
	}
}

