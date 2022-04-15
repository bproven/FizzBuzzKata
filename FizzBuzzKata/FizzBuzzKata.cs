using System.Text;

namespace FizzBuzzKata
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
				stringBuilder.Append( i );
			}
			return stringBuilder.ToString();
		}

	}

}
