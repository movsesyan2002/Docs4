//Task 7: Fitness Tracker System
// Task: Create a class WorkoutSession with:
// Fields: exerciseType and durationInMinutes.
// Add a method ShowWorkoutDetails().
// In Main(), create and display different workout sessions.


class WorkoutSession
{
    private string exerciseType;
    private int durationInMinutes;

    public WorkoutSession(string exercisetype)
    {
        this.exerciseType = exercisetype;
        this.durationInMinutes = 0;
    }   

    public string ExerciseType
    {
        get { return exerciseType; }
    }

    public int DurationInMinutes
    {
        get { return durationInMinutes; }
        set { durationInMinutes = value; }
    }

    
    public void ShowWorkoutDetails()
    {
        Console.WriteLine($"Today I do this exercise {this.ExerciseType} and {this.DurationInMinutes} minutes");
    }
}


class Program
{
    static void Main(string[] args)
    {
        WorkoutSession exercise = new WorkoutSession("Plank");
        WorkoutSession exercise2 = new WorkoutSession("Bench press");
        WorkoutSession exercise3 = new WorkoutSession("Sit up");

        WorkoutSession[] exercises = new WorkoutSession[] { exercise, exercise2,exercise3};
        Console.WriteLine("Today we do this exercises");
        for (int i = 0; i < exercises.Length; ++i) 
        {
            Console.WriteLine($"Exercise type {exercises[i].ExerciseType}");
        }

        while (true)
        {
            Console.WriteLine("Which do you want enter exercise and minute\nFor exit enter Exit");
            Console.Write("Exersize:");
            string? exer = Console.ReadLine();

            if (string.Compare(exer,"Exit") == 0) 
            {
                for (int i = 0; i < exercises.Length; ++i)
                {
                    if (exercises[i].DurationInMinutes > 0){
                        exercises[i].ShowWorkoutDetails();
                    } 
                }
                break;  
            }    
            
           
            Console.WriteLine("Minutes");
            int minute;
            
            if (int.TryParse(Console.ReadLine(), out minute) == false && minute <= 0)
            {
                Console.WriteLine("Invalid argument");
            }

           

            for (int i = 0; i < exercises.Length; ++i)
            {
                if (string.Compare(exer,exercises[i].ExerciseType) == 0)
                {
                    
                    if (exercises[i].DurationInMinutes > 0){
                        exercises[i].DurationInMinutes += minute;
                        break;
                    }
                    
                    else
                    {
                        exercises[i].DurationInMinutes = minute;
                        break;
                    } 
                }
            }

        }
    }
}    
