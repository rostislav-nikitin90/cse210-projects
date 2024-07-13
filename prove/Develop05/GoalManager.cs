using System;
using System.IO;
using System.Text;

namespace Develop05;

public class GoalManager
{   
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine($"\nYou have {GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options\n1. Create New Goal\n2. List Goals\n" +
                              "3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n");
            Console.Write("Select a choice from the menu: ");

            string userOption = Console.ReadLine();
            
            switch (userOption) {
                case "1":
                    Console.Clear();
                    CreateGoal();
                    break;

                case "2":
                    Console.Clear();
                    Console.Write($"\nYou currently have {GetTotalPoints()} points.\n");
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    Console.Clear();
                    Console.Write($"\nYou currently have {GetTotalPoints()} points.\n");
                    LoadGoals();
                    break;

                case "5":
                    Console.Clear();
                    Console.Write($"\nYou currently have {GetTotalPoints()} points.\n");
                    RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Thank you for using the Eternal Quest Program! See you next time!");
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select an option from menu (1-6).");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }

    public GoalManager()
    {
        _score = 0;
    }
    public void CreateGoal()
    {
        Console.Write("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        switch (type) {
        case "1":
            Console.Write("What is the name of your simple goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleG = new("Simple Goal:", name, description, points);
            _goals.Add(simpleG);
            break;          

        case "2":
            Console.Write("What is the name of your eternal goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine());
            EternalGoal eternalG = new("Eternal Goal:", name, description, points);
            _goals.Add(eternalG);
            break;

        case "3":
            Console.WriteLine("What is the name of your checklist goal?  ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?  ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?  ");
            points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?  ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistG = new("Check List Goal:", name, description, points, target, bonus);
            _goals.Add(checklistG);
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a type of goal (1-3).");
            Thread.Sleep(2000);
            break;
        }
    }

    public int GetTotalPoints()
    {
        return _score;
    }
    
    public void CalcuatePoints(int points)
    {
        _score += points;
    }

    public void AddBonus(int bonus)
    {
        _score += bonus;
    }

    public void SetTotalPoints(int score)
    {
        _score = score;
    }

    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe Goals are:");

        int index = 1;

        foreach (Goal goal in _goals)
        {          
            goal.GetDetailsString(index);
            index++;
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file?\n");
        string filename = Console.ReadLine();
        
        if (filename is { Length: > 0 })
        {
            using StreamWriter outputFile = new StreamWriter(filename);
            outputFile.WriteLine(GetTotalPoints());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentaion());
            }
        }
        Console.WriteLine("Filename can't be null or empty. Please consider to provide a filename.");
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file?\n");
        string filename = Console.ReadLine();
        if (filename is { Length: > 0 })
        {
            if (_goals.Any( item => item != null) )
            {
                _goals.Clear();
            }

            string[] lines = File.ReadAllLines(filename);
            int score = int.Parse(lines[0]);
            SetTotalPoints(score);
            lines = lines.Skip(1).ToArray();
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                if (parts[0] == "Simple Goal:")
                {
                    SimpleGoal simpleG = new(type, name, description, points, isComplete);
                    _goals.Add(simpleG);
                }

                if (parts[0] == "Eternal Goal:")
                {
                    EternalGoal eternalG = new(type, name, description, points, isComplete);
                    _goals.Add(eternalG);
                }

                if (parts[0] == "Check List Goal:")
                {
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    int counter = int.Parse(parts[7]);
                    ChecklistGoal checklistG = new(type, name, description, points, isComplete, target, bonus, counter);
                    _goals.Add(checklistG);
                }
            }
        }
        Console.WriteLine("Filename can't be null or empty. Please consider to provide a filename.");
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        Console.Write("\nWhich goal did you accomplished?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetUserPoints();
        CalcuatePoints(goalPoints);

        GetGoalsList()[select].RecordEvent(_goals);

        Console.WriteLine($"\nYou have {GetTotalPoints()} points.\n");
    }
}