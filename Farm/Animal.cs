


public abstract class Animal
{
    public double Weight {  get; set; }
    public bool IsMale {  get; set; }
    public string Name { get; set; }

    public DateTime BirthDate { get; set; } 
    public static int TotalNumber { get; private set; }
    public int Number { get; private set; }

    static Animal()
    {
        TotalNumber = 0;
    }
    public Animal()
    {
        TotalNumber++;
        Number = TotalNumber;
    }


    public abstract int Life();
    public abstract double StressFactor();
    public abstract int TimeToDie();
    public abstract float KillPriority();
    public abstract int CostPerDay();
    public abstract int ValuePerDay();
}


