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

		public int Increment()
		{
			return (++Value);
		}

		public int Value
		{
			get 
			{
				return count;
			}
			private set 
			{
				count = value;
				RaisePropertyChanged (() => Value);
			}
		}
	}
}

