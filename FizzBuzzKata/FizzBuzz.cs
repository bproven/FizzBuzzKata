using System.Text;

namespace FizzBuzz
{

	public static class FizzBuzz
	{

		public static string GetOutput() => GetOutput( 1, 100 );

		public static string GetOutput( int start, int end )
		{
			var stringBuilder = new StringBuilder();
			for ( int i = start; i <= end; i++ )
			{
				if ( stringBuilder.Length > 0 )
				{
					stringBuilder.Append( Environment.NewLine );
				}
				stringBuilder.Append( GetOutput( i ) );
			}
			return stringBuilder.ToString();
		}

		public static string GetOutput( int i )
		{

			string result = string.Empty;

			if ( i % 3 == 0 )
			{
				result = result + "Fizz";
			}

			if ( string.IsNullOrEmpty( result ) )
			{
				result = i.ToString();
			}

			return result;
		}

	}

}
