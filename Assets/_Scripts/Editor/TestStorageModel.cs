using NUnit.Framework;
public class TestStorageModel {

	[Test]
	public void TestWhenCreatedUnitsIsZero(){
		StorageModel sm = new StorageModel ();
		Assert.AreEqual (0, sm.GetUnits ());
	}

	[Test]
	public void TestWhenCreatedCapacityIsOneHundred(){
		StorageModel sm = new StorageModel ();
		Assert.AreEqual (100, sm.Capacity);
	}

	[Test]
	public void TestWhenCreatedMaxDeliveryIsTwenty(){
		StorageModel sm = new StorageModel ();
		Assert.AreEqual (20, sm.MaxDelivery);
	}

	[Test]
	public void TestWhenCreatedNearlyFullPercentageIs75(){
		StorageModel sm = new StorageModel ();
		Assert.AreEqual (0.75, sm.NearlyFullPercentage);
	}

	[Test]
	public void TestWhenCreatedIsNearlyFullFalse(){
		StorageModel sm = new StorageModel ();
		Assert.IsFalse (sm.IsNearlyFull());
	}

	[Test]
	public void TestAfterDeliveryOf10DeliveryTrueUnits10(){
		StorageModel sm = new StorageModel ();

		bool delivery = sm.Deliver (10);
		int units = sm.GetUnits ();
		int expected = 10;

		Assert.IsTrue (delivery);
		Assert.AreEqual (expected, units);
	}

	[Test]
	public void TestAfterDeliveryOf25DeliveryFalseUnits0(){
		StorageModel sm = new StorageModel ();

		bool delivery = sm.Deliver (25);
		int units = sm.GetUnits ();
		int expected = 0;

		Assert.IsFalse (delivery);
		Assert.AreEqual (expected, units);
	}

	[Test]
	public void TestAfterFourDeliverysOf20IsNearlyFullTrueUnits80(){
		StorageModel sm = new StorageModel ();

		sm.Deliver (20);
		sm.Deliver (20);
		sm.Deliver (20);
		sm.Deliver (20);

		bool nearlyFull = sm.IsNearlyFull() ;
		int units = sm.GetUnits ();
		int expected = 80;

		Assert.IsTrue (nearlyFull);
		Assert.AreEqual (expected, units);

	}
}
