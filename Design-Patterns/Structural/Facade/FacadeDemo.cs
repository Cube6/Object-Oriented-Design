
using Design_Patterns.Structural.FacadePattern.Sample1;
using Design_Patterns.Structural.FacadePattern.Structural_code;

namespace Design_Patterns.Structural.FacadePattern
{
	class FacadeDemo : PatternDemoBase
	{
		/*
		 意图：
			The Facade design pattern provides a unified interface to a set of interfaces in a subsystem. This pattern defines a higher-level interface that makes the subsystem easier to use.
			为子系统中的一组接口提供一个一致的界面，Facade 模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。

		场景：
			- 当你要为一个复杂子系统提供一个简单接口时。子系统往往因为不断演化而变得越
			来越复杂。大多数模式使用时都会产生更多更小的类。这使得子系统更具可重用性，
			也更容易对子系统进行定制，但这也给那些不需要定制子系统的用户带来一些使用
			上的困难。Facade 可以提供一个简单的缺省视图，这一视图对大多数用户来说已
			经足够，而那些需要更多的可定制性的用户可以越过 Facade 层。

			- 客户程序与抽象类的实现部分之间存在着很大的依赖性。引入 Facade 将这个子系
			统与客户以及其他的子系统分离，可以提高子系统的独立性和可移植性。

			- 当你需要构建一个层次结构的子系统时，使用 Facade 模式定义子系统中每层的入
			口点。如果子系统之间是相互依赖的，你可以让它们仅通过 Facade 进行通讯，从
			而简化了它们之间的依赖关系。

		 */

		public override string PatternName => "Facade Pattern";

		protected override void RunImpl()
		{
			#region Structural code

			var facade = new Facade();
			facade.MethodA();
			facade.MethodB();

			/***********************Output*******************************
				MethodA() ----
				SubSystemOne Method
				SubSystemTwo Method
				SubSystemFour Method

				MethodB() ----
				SubSystemTwo Method
				SubSystemThree Method
			**************************************************************/

			#endregion

			#region Sample1

			/*
			 *  In order to place an order first we need to create an object of Product class and get the product details by calling the GetProductDetails. 
			 *  Then if everything is fine then we need to make the Payment and in order to do this, 
			 *  we need to create an instance of the Payment class and call the MakePayment method. 
			 *  If Payment is successful then we need to send the Invoice to the customer and to do so, 
			 *  we need to create an instance of the Invoice class and call the SendInvoice method. 
			 *  So, in order to place the order, we need to do the above mention steps.
			 *  The Façade Design Pattern in C# is actually an extra class that sits at the top of the above classes. 
			 *  
			 *  Order is the Façade class which will take the responsibility of placing the order. 
			 *  This class internally creates the instance of the respective classes and calls the method.
			 */
			Order order = new Order();
			order.PlaceOrder();

			#endregion
		}
    }
}