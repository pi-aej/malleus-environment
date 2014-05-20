using NUnit.Framework;
using System;

namespace Example.Common.Test
{
	[TestFixture ()]
	public class CounterTest
	{
		[Test ()]
		public void Initial ()
		{
			Counter target = new Counter ();

			Assert.AreEqual (0, target.Value(), "The initial Value was not zero");
		}
			
		[Test ()]
		public void Increment ()
		{
			Counter target = new Counter ();

			Assert.AreEqual (0, target.Value(), "The initial Value was not zero");

			target.Increment ();

			Assert.AreEqual (1, target.Value(), "The incremented Value was not 1");
		}

		[Test ()]
		public void IncrementTwice ()
		{
			Counter target = new Counter ();

			Assert.AreEqual (0, target.Value(), "The initial Value was not zero");

			target.Increment ();

			Assert.AreEqual (1, target.Value(), "The incremented Value was not 1");

			target.Increment ();

			Assert.AreEqual (2, target.Value(), "The incremented Value was not 2");
		}
	}
}

