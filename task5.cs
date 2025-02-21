// Task 5: Smartwatch Step Counter
// Task: Create a class Smartwatch with:
// Fields: ownerName and stepCount.
// Add methods AddSteps(int steps) and ShowSteps().
// In Main(), create a smartwatch object, simulate adding steps, and display the total.

class Smartwatch
{
    private string ownerName;
    private int stepCount;

    public Smartwatch(string ownerName)
    {
        this.ownerName = ownerName;
        this.stepCount = 0;
    }

    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public int StepCount
    {
        get { return stepCount; }
        set { stepCount = value; }
    }

    public void AddSteps(int steps)
    {
        if (steps < 0) 
        {
            Console.WriteLine("invalid argument try again");
            return;
        }
        
        else 
        {
            this.StepCount += steps;
        }
    }

    public void ShowSteps() 
    {
        Console.WriteLine($"{this.OwnerName} your steps is {this.StepCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Smartwatch smartwatch = new Smartwatch("Simon");
        Random steps = new Random();
        Console.Write("Today I want run hours");
        if(int.TryParse(Console.ReadLine(), out int hours) == false)
        {
            Console.WriteLine("invalid input");
        }
        
        Console.WriteLine($"Smartwatch today I want run {hours} please count my steps");

        for (int i = 0; i < hours; ++i)
        {
            smartwatch.AddSteps(steps.Next(1000,10000));
        }

        smartwatch.ShowSteps();
    }
}