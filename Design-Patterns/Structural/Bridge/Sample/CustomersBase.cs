/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Structural.Bridge.Sample
{
	/// <summary>
	/// The 'Abstraction' class
	/// </summary>
	public class CustomersBase
	{
		private DataObject dataObject;
		public DataObject Data
		{
			set { dataObject = value; }
			get { return dataObject; }
		}
		public virtual void Next()
		{
			dataObject.NextRecord();
		}
		public virtual void Prior()
		{
			dataObject.PriorRecord();
		}
		public virtual void Add(string customer)
		{
			dataObject.AddRecord(customer);
		}
		public virtual void Delete(string customer)
		{
			dataObject.DeleteRecord(customer);
		}
		public virtual void Show()
		{
			dataObject.ShowRecord();
		}
		public virtual void ShowAll()
		{
			dataObject.ShowAllRecords();
		}
	}
}
