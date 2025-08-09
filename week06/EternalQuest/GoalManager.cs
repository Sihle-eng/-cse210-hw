using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        string choice = "";
        string fifth = "5";

        while (choice != fifth)
        {
            Console.WriteLine("Menu Options:");

            string first = "1";
            Console.WriteLine(" 1. Create New Goal");

            string second = "2";
            Console.WriteLine(" 2. List Goals");

            string third = "3";
            Console.WriteLine(" 3. Save Goals");

            string fourth = "4";
            Console.WriteLine(" 4. Load Goals");

            Console.WriteLine(" 5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == first)
            {
                CreateGoal();
            }
            else if (choice == second)
            {
                foreach (Goal goal in _goals)
                {
                    Console.Write(goal.GetDetailsString());
                }

            }
            else if (choice == third)
            {
                Console.Write("Enter the file name to save goals: ");
                string fileName = Console.ReadLine();
                SaveGoal(fileName);
            }
            else if (choice == fourth)
            {
                Console.Write("Enter the file name to load goals: ");
                string fileName = Console.ReadLine();
                LoadGoal(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option. ");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        ListGoalName();
        ListGoalDetails();
        
    }
    public void ListGoalName()
    {
        foreach (Goal goal in _goals)
        {
            string[] parts = goal.GetStringRepresentation().Split('|');
            string name = parts[1];
            Console.WriteLine(name);
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string[] parts = goal.GetStringRepresentation().Split('|');
            string description = parts[2];

            Console.WriteLine(description);

        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");

        string first = "1";
        Console.WriteLine(" 1. Simple Goal");

        string second = "2";
        Console.WriteLine(" 2. Eternal Goal");

        string third = "3";
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("What type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if (choice == first)
        {
            Console.Write("Enter the name of your goal: ");
            string name = Console.ReadLine();

            Console.Write("Enter a short description of your goal: ");
            string description = Console.ReadLine();

            Console.Write("Enter the number of points for this goal: ");
            string pointsInput = Console.ReadLine();
            int points = int.Parse(pointsInput);

            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
            goal.RecordEvent();
        }
        else if (choice == second)
        {
            Console.Write("Enter the name of your goal: ");
            string name = Console.ReadLine();

            Console.Write("Enter a short description of your goal: ");
            string description = Console.ReadLine();

            Console.Write("Enter the number of points for this goal: ");
            string pointsInput = Console.ReadLine();
            int points = int.Parse(pointsInput);

            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
            goal.RecordEvent();

        }
        else if (choice == third)
        {
            Console.Write("Enter the name of your goal: ");
            string name = Console.ReadLine();

            Console.Write("Enter a short description of your goal: ");
            string description = Console.ReadLine();

            Console.Write("Enter the number of points for this goal: ");
            string pointsInput = Console.ReadLine();
            int points = int.Parse(pointsInput);

            Console.Write("Enter the target number of completions for this goal: ");
            string targetInput = Console.ReadLine();
            int target = int.Parse(targetInput);

            Console.Write("Enter the bonus points for this goal: ");
            string bonusInput = Console.ReadLine();
            int bonus = int.Parse(bonusInput);

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
            goal.RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid goal type. ");
        }

    }
    public void RecordEvent()
    {
        
        int _timesRecorded = 0;
        _timesRecorded++;
        if (_timesRecorded > 1)
        {
        
        }
    }
    public int CalculateTotalScore()
    {
        int total = 0;
        foreach (Goal goal in _goals)
        {
            total += goal.GetPoints();
        }
        return total;
    }
    public void SaveGoal(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine($"Score | {CalculateTotalScore}");
            foreach (Goal goal in _goals)
            {
                // outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                // outputFile.WriteLine(DisplayPlayerInfo());
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoal(string file)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string goalType = parts[0];

            if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
                foreach (Goal g in _goals)
                {
                    Console.WriteLine(g.GetStringRepresentation());
                }
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
                foreach (Goal g in _goals)
                {
                    Console.WriteLine(g.GetDetailsString());
                }

            }
            else if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
                foreach (Goal g in _goals)
                {
                    Console.WriteLine(g.GetDetailsString());
                }
            }
        }

    }
}
