public class GoalManager
{
    private List<Goal> _goals = new ();
    private int _score;

    private int _count = 0;

    private string _folderPath = "Goals/";

    public GoalManager()
    {

    }

    public void Start()
    {
        string Menu = "\n1. Create New Goal  | 2. List Goals  | 3. Save Goals  | 4. Load Goals ♽ | 5. Record Event  | 6. Quit\n";
        bool isMenuOn = true;

        do
        {
            DisplayPlayerPoint();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(Menu);
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
           {
                CreateGoal();
           }
           else if (userChoice == 2)
           {
                Console.WriteLine("");
                ListGoals();
           }
           else if (userChoice == 3)
           {
                SaveGoal();
           }
           else if (userChoice == 4)
           {
                LoadGoals();
           }
           else if (userChoice == 5)
           {
                RecordEvent();
           }
           else if (userChoice == 6)
           {
                isMenuOn =false;
                break;
           }

        } while (isMenuOn);
    }

    private  void DisplayPlayerPoint()
    {
        Console.WriteLine($"\nYou have {_score} points");
    }

    private void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetGoalName()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("The list of goals is empty. You can load your saved goals or create a new one");
        }
    }

    private void ListGoalDetails()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("The list of goals is empty. You can load your saved goals or create a new one");
        }
    }

    private void CreateGoal()
    {
        string[] goalTypes = {"Simple Goal", "Eternal Goals", "Checklist Goals"};
        Console.WriteLine($"\nThe types of goals are: 1. {goalTypes[0]} | 2. {goalTypes[1]} | 3. {goalTypes[2]}");
        Console.Write("\nWhat type of goal do you want create?: ");
        int GoalTypes = int.Parse(Console.ReadLine()) - 1;

        if (GoalTypes == 0)
        {
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[GoalTypes]);
            _goals.Add(simpleGoal);
        }
        else if (GoalTypes == 1)
        {
           EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[GoalTypes]);
           _goals.Add(eternalGoal);
        }
        else if (GoalTypes == 2)
        {
            CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[GoalTypes], target: SetCheckListCount(), bonus: SetBonusPoint());
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("!Invalid: This option does not exist.");
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplished?: ");
        int goalCompleteIndex = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        goalAccomplished.SetIsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        string congratulatoryMessage = $"\nCongratulations! You have earned {goalAccomplished.GetSetPoint()}\nYou now have {_score} points";
        Console.WriteLine(congratulatoryMessage);
        DisplayPlayerPoint();
    }

    private void ListGoals()
    {
        ListGoalDetails();
    }

    private void SaveGoal()
    {
        Console.Write("\nWhat would you like to name the file? : ");
        string fileName = Console.ReadLine();
        using StreamWriter Goals = new($"{_folderPath}{fileName}.txt");
        Goals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            Goals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();
        
    }

    private void LoadGoals()
    {
        string[] files = Directory.GetFiles(_folderPath);

        if (files.Length != 0)
        {
            Console.WriteLine("These are the saved files:");
            foreach (string file in files)    
            {
                _count++;
                Console.WriteLine($"{_count}. {Path.GetFileNameWithoutExtension(file)}");
            }
            _count = 0;

            Console.Write("Choose the file to load listed above: ");
            int choiceFile = int.Parse(Console.ReadLine());
            string[] fileContent = File.ReadAllLines(files[choiceFile - 1]);

            _goals.AddRange(ConvertToGoalObjects(fileContent));
        } 
        else Console.WriteLine("There are no files saved in your Goals-Folder");
    }

    private string SetGoalName()
    {
        Console.Write("\nWhat is the name of the goal? : ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }

    private int SetGoalPoint()
    {
        Console.Write("\nEnter the amount of point you want to achieve: ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }

    private string SetGoalDescription()
    {
        Console.Write("\nWrite a short description of the goal: ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    private int SetBonusPoint()
    {
        Console.Write("\nEnter the amount of bonus point you want to achieve for this goal: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    private int SetCheckListCount()
    {
        Console.Write("\nHow many times do you want to set for this goal to be completed? : ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
    
    private List<Goal> ConvertToGoalObjects(string[] param)
    {
        _score = int.Parse(param[0]);
        char colon = ':';
        char pipe = '|';
        int start = 1;
        int end = param.Length;
        param = param.Where((value, index) => index >= start && index <= end).ToArray();

        List<Goal> initialGoal = new();

        foreach (string list in param)
        {
            string[] parts = list.Split(colon);
            string goalName = parts[0].Trim();
            string[] contents = parts[1].Split(pipe);

            if (goalName == "Simple Goal")
            {
                SimpleGoal simpleGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                bool isComplete = bool.Parse(contents[3]);
                if (isComplete) 
                {
                    simpleGoal.SetCheckMark();
                    simpleGoal.SetIsCompleteToTrue();
                }
                initialGoal.Add(simpleGoal);
            }
            if (goalName == "Eternal Goals")
            {
                EternalGoal eternalGoal = new (name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                initialGoal.Add(eternalGoal);
            }
            if (goalName == "Checklist Goals")
            {
                CheckListGoal checkListGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName, bonus: int.Parse(contents[3].Trim()), target: int.Parse(contents[4].Trim()));
                bool isComplete = bool.Parse(contents[6]);
                if (isComplete)
                {
                    checkListGoal.SetCheckMark();
                    checkListGoal.SetIsCompleteToTrue();
                } 
                checkListGoal.AddSaveAmountCompleted(int.Parse(contents[5].Trim()));
                initialGoal.Add(checkListGoal);
            }
        }
        Console.WriteLine("\nYour file is loaded Successfully");
        return initialGoal;
    }
}