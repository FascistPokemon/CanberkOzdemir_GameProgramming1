namespace FirstGame;

public class ElectricEngine : Engine
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("The engine does not make and sound");
        ChechBatteryStatus();
    }

    private void CheckBatteryStatus()
    {
        Console.WriteLine("The battery is fine")
    }
    
}