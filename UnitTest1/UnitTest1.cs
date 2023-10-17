using CarFactoryLibrary;

public class UnitTest1
{
    [Fact]
    public void usingAssertBollean()
    {
        BMW bMW = new BMW();
        bool result = bMW.IsStopped();
        Assert.True(result);
    }
    //-----------------------------------

    [Fact]
    public void usingAssertEquality()
    {
        Toyota toyota = new Toyota();
        BMW bMW = new BMW();
        Toyota toyota2 = new Toyota();
        Assert.Equal(toyota.velocity, 10);

    }
    //-----------------------------------


    [Fact]
    public void usingAssertRefrance()
    {
        Toyota toyota1 = new Toyota();
        BMW bMW = new BMW();
        Toyota toyota2 = new Toyota();
        Assert.NotSame(toyota1, toyota2);

    }

    //-----------------------------------
    [Fact]
    public void usingAssertType()
    {
        var car = CarFactory.NewCar(CarTypes.BMW);
        Assert.IsType<BMW>(car);

    }

    //-----------------------------------

    [Fact]
    public void usingAssertCollection()
    {
        CarStore carsstore = new CarStore();
        Toyota toyota1 = new Toyota();
        Assert.Contains<Car>(toyota1, carsstore.cars);

    }
    //------------------------------------
    [Fact]
    public void throwexeption()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            CarFactory.NewCar(carType: CarTypes.Honda);
        });
    }
}