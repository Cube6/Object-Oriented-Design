using System;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class RankGradeSchoolReport : FouthGradeSchoolReport
	{
		private void ReportRank()
		{
			Console.WriteLine("My Ranking: 35");
		}

		public override void Report()
		{
			Console.WriteLine("Chinese：62， Mathematics： 65， English：63");
			ReportRank();
		}

		public override void Sign(string name)
		{
			Console.WriteLine($"Signature: {name}");
		}
	}
}
