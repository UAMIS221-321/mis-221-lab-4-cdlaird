
string userInput = "";
while (userInput != "4"){
    DisplayMenu();
    userInput = GetUserChoice();
    RouteEm(userInput);
}

static void DisplayMenu(){
    System.Console.WriteLine("Which Pizza Slice would you like?\n1.Plain Pizza \n2.Cheese Pizza\n3.Pepperoni Pizza\n4.Exit");
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteEm(string userChoice){
    switch(userChoice){
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepPizza();
            break;
        case "4":
            SayBye();
            break;
        default:
            BadInput();
            break;
    }
}

static void PlainPizza(){
    Random rand = new Random();
    int rows = new Random().Next(8,13);
    System.Console.WriteLine("Plain Pizza:");
    for (int i = rows; i >0; i--){
        for (int j = 0; j<i; j++)
        {
            System.Console.Write("* ");
            }
            Console.WriteLine();
    }
    Pause();
}

static void CheesePizza()
{
    Random rand = new Random();
    int rows = new Random().Next(8,13);
    System.Console.WriteLine("Cheese Pizza");
    for (int i = rows; i >0; i--)
    {
        System.Console.Write("* ");
        for (int j = 0; j< i-1;j++)
        {
            if (i==rows || i==1 || j==0|| j==i-2){
                Console.Write("* ");
            }
            else {
                Console.Write("# ");
            }
        }
        if (i>1)
            Console.WriteLine("*");
        else
            Console.WriteLine();
    }
    Pause();
}

static void PepPizza()
    {
        Random rand = new Random();
        int rows = new Random().Next(8, 13);
        Random random = new Random();
        Console.WriteLine("Pepperoni Pizza:");
        for (int i = rows; i > 0; i--)
        {
            Console.Write("* ");
            for (int j = 0; j < i - 1; j++)
            {
                if (i == rows || i == 1 || j == 0 || j == i - 2)
                {
                    Console.Write("* ");
                }
                else
                {
                    int randomValue = random.Next(0, 4); 
                    if (randomValue == 0) // 1 in 4 chance to place a pepperoni
                    {
                    Console.Write("[] "); // Print pepperoni
                    }
                else
                {
                    Console.Write("# "); 
                }
            }
            
        }
        if (i > 1)
                Console.WriteLine("*");
            else
                Console.WriteLine();
        
    }
    Pause();
    }

static void BadInput()
{
    System.Console.WriteLine("Invalid menu choice.");
    Pause();
    
}

static void SayBye()
{
    System.Console.WriteLine("Goodbye!");
}

static void Pause()
{
    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
    Console.Clear();
}