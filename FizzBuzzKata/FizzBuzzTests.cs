using Xunit;

namespace FizzBuzz.Test
{

	public class FizzBuzzTests
	{

		[Fact]
		public void FizzBuzz1To100Test()
		{
			var expected = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
Fizz
14
FizzBuzz
16
17
Fizz
19
Buzz
Fizz
22
Fizz
Fizz
Buzz
26
Fizz
28
29
FizzBuzz
Fizz
Fizz
Fizz
Fizz
Buzz
Fizz
Fizz
Fizz
Fizz
Buzz
41
Fizz
Fizz
44
FizzBuzz
46
47
Fizz
49
Buzz
Fizz
52
Fizz
Fizz
Buzz
56
Fizz
58
59
FizzBuzz
61
62
Fizz
64
Buzz
Fizz
67
68
Fizz
Buzz
71
Fizz
Fizz
74
FizzBuzz
76
77
Fizz
79
Buzz
Fizz
82
Fizz
Fizz
Buzz
86
Fizz
88
89
FizzBuzz
91
92
Fizz
94
Buzz
Fizz
97
98
Fizz
Buzz";
			Assert.Equal( expected, FizzBuzz.GetOutput() );
		}

		[Fact]
		public void DivisibleByThreeTest1()
		{
			Assert.Equal( "1", FizzBuzz.GetOutput( 1 ) );
		}

		[Fact]
		public void DivisibleByThreeTest2()
		{
			Assert.Equal( "Fizz", FizzBuzz.GetOutput( 3 ) );
		}

		[Fact]
		public void DivisibleByFiveTest()
		{
			Assert.Equal( "Buzz", FizzBuzz.GetOutput( 5 ) );
		}

		[Fact]
		public void DivisibleByThreeAndFiveTest()
		{
			Assert.Equal( "FizzBuzz", FizzBuzz.GetOutput( 3 * 5 ) );
		}

		[Fact]
		public void ExtraCredit1Test()
		{
			Assert.Equal( "Fizz", FizzBuzz.GetOutput( 13 ) );
		}

		[Fact]
		public void MakeTestOutput()
		{
			for ( int i = 1; i <= 100; i++ )
			{
				System.Diagnostics.Debug.WriteLine( FizzBuzz.GetOutput( i ) );
			}
		}

	}

}
