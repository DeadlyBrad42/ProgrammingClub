using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_AustralianVoting_Test
{
	[TestClass]
	public class UnitTest1
	{
		string _testSet1 = @"3
Matt
Jessica
Sarah
1 2 3
1 2 3
1 2 3
1 2 3
1 2 3
1 2 3
1 2 3
1 2 3
1 3 2
1 3 2
1 3 2
1 3 2
1 3 2
1 3 2
1 3 2
1 3 2
1 3 2
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 1 3
2 3 1
2 3 1
2 3 1
2 3 1
2 3 1
2 3 1
2 3 1
2 3 1
2 3 1
2 3 1
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 1 2
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
3 2 1
";

		string _testSet2 = @"3
John Doe
Jane Smith
Jane Austen
1 2 3
2 1 3
2 3 1
1 2 3
3 1 2
";
		[TestMethod]
		public void TestMethod1()
		{
		}
	}
}
