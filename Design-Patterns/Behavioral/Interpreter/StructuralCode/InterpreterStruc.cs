namespace Interpreter_StructuralCode
{

	public interface AbstractExpression
	{
		public void interpret(string info);
	}

	public class TerminalExpression : AbstractExpression
	{
		public void interpret(string info)
		{

		}
	}
	public class NonTerminalExpression : AbstractExpression
	{
		private AbstractExpression exp1;
		private AbstractExpression exp2;
		public void interpret(string info)
		{

		}
	}

	public class Context
	{
		public Context()
		{

		}
		public void operation (string info)
		{

		}
	}
}
