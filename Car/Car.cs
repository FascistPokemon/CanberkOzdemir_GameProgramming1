﻿namespace FirstGame;

public class Car : Vehicle
{
    private IEngine _engine;

    public Car(float fuelAmount, IEngine engine)
    {
        Fuel = fuelAmount;
        _engine = engine;
    }

    public void StartCar()
    {
        _engine.StartCar();
        // Other car starting stuff
    }
}