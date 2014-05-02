using System;

namespace Example.Common
{
	public class Counter
	{
		int count = 0;

		public Counter ()
		{
		}			

		public string Increment()
		{
			return (++count).ToString();
		}

		public int Value ()
		{
			return count;
		}
	}
}

