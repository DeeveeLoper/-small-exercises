class SmallExercises
{
    static void Main(string[] args)
    {

        //new SumNumer().displaySumNumber();

        //new AverageValue().displayAverageValue();

        //new StoryWithTwoNames().displayStoryWithTwoNames();

        //new floatingNumber().displayFloatingNumber();

        //new WrongVarible().displayWrongVarible();

        //new SwapNumbers().displaySwapNumbers();


    }

    // 2.1 Skapa ett program där användaren får mata in två heltal, varefter programmet beräknar summan.
    class SumNumer
    {
        public void displaySumNumber()
        {
            Console.Write("Skriv första helttalet: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Skriv andra helttalet: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int sumNumbers = firstNumber + secondNumber;
            Console.WriteLine($"Summan blir: {sumNumbers}");
        }
    }

    // 2.2 Skapa ett program där användaren får mata in tre heltal, varefter programmet beräknar summan och medelvärdet av dessa tal.
    class AverageValue
    {
        public void displayAverageValue()
        {
            Console.Write("Skriv in först heltalet: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Skriv in först heltalet: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Skriv in först heltalet: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumNumbers = firstNumber + secondNumber + thirdNumber;
            int averageValue = sumNumbers / 3;

            Console.WriteLine($"Summan är {sumNumbers} och medelvärdet är {averageValue}.");
        }
    }

    // 2.3 Låt användaren mata in namnet på två personer. Programmet ska sedan skriva ut en kort berättelse om dessa två personer.
    class StoryWithTwoNames
    {
        public void displayStoryWithTwoNames()
        {
            Console.Write("Skriv ett namn till första person: ");
            string firstName = Console.ReadLine();

            Console.Write("Srkiv ett namn till andra personen: ");
            string secondName = Console.ReadLine();

            Console.WriteLine($"Det var en gång en prins som heter {firstName} och han gifte sig med en prinsessa som heter {secondName}. Och dem levde lyckliga i alla sina dar. ");
        }
    }

    // 2.4 Använd metoden Math.Round() för att avrunda ett flyttal som användaren skriver in till två decimaler. 
    // Om användaren t.ex. skriver in t.ex. 2.56789 så ska programmet avrunade det till 2.57
    class floatingNumber
    {
        public void displayFloatingNumber()
        {
            Console.WriteLine("Skriv in ett flyttal som ska avrundas:");
            float floatingNumber = float.Parse(Console.ReadLine());
            double roundedNumber = Math.Round(floatingNumber, 2);
            Console.WriteLine($"Avrundat flyttal är: {roundedNumber}");
        }
    }

    // 2.5 I följande kodstycke ger inte rätt utskrift
    class WrongVarible
    {
        public void displayWrongVarible()
        {
            // variblerna ska vara float eller double. 
            double a = 1;
            double b = 2;
            double c = a / b;
            Console.WriteLine(c);
        }
    }

    // 2.6 Skapa ett program där användaren får mata in två heltal. 
    //Programmet ska sedan byta värde på dessa två variabler genom att använda en tredje temporär variabel. 
    //Skriv ut värdena före och efter bytet.
    class SwapNumbers
    {
        public void displaySwapNumbers()
        {
            Console.WriteLine("Skriv första heltal: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv andra heltalet: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Första heltalet är {firstNumber} och andra heltalet är {secondNumber}.");

            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine($"Nu är första heltalet {firstNumber} och andra heltalet {secondNumber}.");
        }
    }

    // 2.7 Skapa ett program där användaren får mata in två heltal. 
    //Programmet ska sedan byta värde på dessa två variabler utan att använda en tredje temporär variabel. Skriv ut värdena före och efter bytet.
    //Du får endast använda variabler av typen int, tilldelningsoperatorn samt de aritmetiska operatorerna + eller -. 
    //Använd ej tuples/tuple deconstruction eller nån annan fancy teknik. Syftet är att öva dig i logiskt tänkande.

    class SwapNumbersTwo
    {
        public void displaySwapNumbers()
        {
            Console.WriteLine("Skriv första heltal: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv andra heltalet: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Första heltalet är {firstNumber} och andra heltalet är {secondNumber}.");

            //Obs, denna uppgift är något klurig men den går att lösa. 
            //Kom ihåg att en variabel kan användas på båda sidor av tilldelningsoperatorn =, men att det som står till höger om = alltid sker först.
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine($"Nu är första heltalet {firstNumber} och andra heltalet {secondNumber}.");
        }
    }





}