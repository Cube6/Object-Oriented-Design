using Design_Patterns.Behavioral.ChainOfResponsibility.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility
{
	public class CORDemo : PatternDemoBase
	{
		//职责链模式的优点
			//接收者和发送者都不知道对方的明确信息，也不知道整个链的结构。只有一个指继承者的引用，降低了耦合。
			//增强了给对象指派职责的灵活性，随时增加或修改处理一个请求的结构。增强了给对象指派职责的灵活性。
			//增加新的请求时，无需改变链的结构，只需要在客户端重新建立链关系即可。
		//职责链模式的缺点
			//没有指定的接收者，仅指向继承者，所以不能确保在整个职责链结束之后请求一定能够得到处理。
			//职责链模式过长的话，影响运行性能。
			//建链不当容易形成死循环


		public override string PatternName => "Chain of Responsibilty ";

		protected override void RunImpl()
		{
			VacationCOR requestChainOfResponsibility = new VacationCOR();
			int[] requests = {1,2, 5, 14, 22, 18, 3, 27, 20 };
			foreach (int request in requests)
			{
				requestChainOfResponsibility.handleRequest(request);
			}
		}
	}
}
