
List<Animal> animals = new List<Animal>()
{
new Cow(){IsMale=true,Weight=250,BirthDate=new DateTime(2022,10,05),},
new Sheep(){IsMale = false, Weight = 100,BirthDate=new DateTime(2021,09,05)},
 new Sheep(){IsMale = false, Weight = 100,BirthDate=new DateTime(2021,09,05),},
};


foreach (Animal animal in animals)
{
    Console.WriteLine(animal);
}




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


public class Cow : Animal
{
    static Cow() { MaxLife = 9125; }
    public static int MaxLife { get; }

    public override int Life()
    {
        int Age = (int)(DateTime.Now - BirthDate).TotalDays;

        return MaxLife - Age;
    }
   
    List <Environment> environments { get; set; }  
    List<CowParameter> cowParameters { get; set; } 


    public override string ToString() =>
        $"C{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";

    public override int TimeToDie()
    {
       int age = (int)(DateTime.Now - BirthDate).TotalDays;
        return   age- MaxLife;
    }

    public override float KillPriority()
    {
        int days = MaxLife  - Life();
        double KillPriority ;
        switch (days)
        {
            case int day when days <= 1825:
                KillPriority = 1;
                break;
            case int day when days > 1825 && days <= 3650:
                KillPriority = 0.75;
                break;
            case int day when days > 3650 && days <= 5475:
                KillPriority = 0.5;
                break;
            case int day when days > 5475 && days <= 7300:
                KillPriority = 0.25;
                break;
            default:
                KillPriority = 0;
                break;
        }

        return (float)KillPriority;
    }


    public override int CostPerDay()
    {
        throw new NotImplementedException();
    }

    public override int ValuePerDay()
    {
        throw new NotImplementedException();
    }

    
}



public class Sheep : Animal
{   
    static Sheep() { MaxLife = 4380; }
    public static int MaxLife { get; }
    public override int Life()
    {
        int Age = (int)(DateTime.Now - BirthDate).TotalDays;

        return MaxLife - Age;
    }
    List<Environment> environments = new List<Environment>();
    List<SheepParameter> sheepParameters = new List<SheepParameter>();
    public override string ToString() =>
        $"S{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";

    public override double StressFactor()
    {
        throw new NotImplementedException();
    }

    public override int TimeToDie()
    {
        int age = (int)(DateTime.Now - BirthDate).TotalDays;
        return age - MaxLife;
    }

    public override float KillPriority()
    {
        int days = MaxLife - Life();
        double KillPriority;
        switch (days)
        {
            case int day when days <= 876:
                KillPriority = 1;
                break;
            case int day when days > 876 && days <= 1752:
                KillPriority = 0.75;
                break;
            case int day when days > 1752 && days <= 2628:
                KillPriority = 0.5;
                break;
            case int day when days > 2628 && days <= 3504:
                KillPriority = 0.25;
                break;
            default:
                KillPriority = 0;
                break;
        }

        return (float)KillPriority;
    }

    public override int CostPerDay()
    {
        throw new NotImplementedException();
    }

    public override int ValuePerDay()
    {
        throw new NotImplementedException();
    }
}




class HealthParameter<T>
{
    public string Name { get; set; }
    public T Current { get; set; }
    public  T Standard { get; set; }
    public double Alpha { get; set; }
    public virtual double StressFactor() =>
           (Convert.ToDouble(Current) / Convert.ToDouble(Standard)) * Alpha;



}


    public class Environment
    {
        public HealthParameter TDS { get; set; }

        public HealthParameter Temperature { get; set; }

        public HealthParameter Density { get; set; }

        public HealthParameter db { get; set; }

        public HealthParameter AQI { get; set; }

        public HealthParameter OX { get; set; }

        public DateTime Date { get; set; }
    }



public class CowParameter 
{
    public HealthParameter   TimeToStand { get; set; }

    public HealthParameter TimeToDie { get; set; }

    public HealthParameter TimeToRelax { get; set; }

    public HealthParameter NumberOfMeals { get; set; }

    public HealthParameter NumberOfMilkProduction { get; set; }

    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}
public class SheepParameter
{
    public HealthParameter TimeToStand { get; set; }

    public HealthParameter TimeToDie { get; set; }

    public HealthParameter TimeToRelax { get; set; }

    public HealthParameter NumberOfMeals { get; set; }

    public HealthParameter NumberOfMilkProduction { get; set; }

    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}


