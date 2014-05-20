using System;
using Cirrious.MvvmCross.ViewModels;

namespace Example.Common
{
	public class Counter : MvxViewModel
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

