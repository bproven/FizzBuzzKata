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
13
14
Buzz
16
17
Fizz
19
Buzz
Fizz
22
23
Fizz
Buzz
26
Fizz
28
29
Buzz
31
32
Fizz
34
Buzz
Fizz
37
38
Fizz
Buzz
41
Fizz
43
44
Buzz
46
47
Fizz
49
Buzz
Fizz
52
53
Fizz
Buzz
56
Fizz
58
59
Buzz
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
73
74
Buzz
76
77
Fizz
79
Buzz
Fizz
82
83
Fizz
Buzz
86
Fizz
88
89
Buzz
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

		public void MakeTestOutput()
		{
			for ( int i = 1; i <= 100; i++ )
			{
				System.Diagnostics.Debug.WriteLine( FizzBuzz.GetOutput( i ) );
			}
		}

	}

}
