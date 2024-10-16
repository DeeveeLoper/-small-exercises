using System.ComponentModel;

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
        //new SwapNumbersTwo().displaySwapNumbers();
        //new AdultCheck().displayAdultCheck();
        //new WeatherCheckOne().displayWeatherCheckOne();
        //new WeatherCheckTwo().displayWeatherCheckTwo();
        //new WeatherCheckThree().displayWeatherCheckThree();
        //new ColdestCheckOne().displayColdestCheckOne();
        //new ColdestCheckTwo().displayColdestCheckTwo();
        //new CheckWaterTemp().displayCheckWaterTemp();
        //new WrongIf().DisplayWrongIf();
        //new NumberSequenceToTwenty().DisplayNumberSequenceToTwenty();
        new NumberSequenceToHundred().DisplayNumberSequenceToHundred();




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

    // 3.1 Skriv ett program där användaren får mata in sin ålder. Programmet kontrollerar sedan om användaren är myndig eller inte.
    class AdultCheck
    {
        public void displayAdultCheck()
        {
            Console.WriteLine("Skriv in din ålder");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Jippi! Du är myndig och stor.");
            }
            else
            {
                Console.WriteLine("Tyvärr, Du är inte myndig.");
            }
        }
    }

    // 3.2 Skapa ett program som ställer frågan ''Är det fint väder?''. 
    //Om användaren svarar ''j'' skriver programmet ut ''Vi går på picknick!''. Annars händer ingenting.

    class WeatherCheckOne
    {
        public void displayWeatherCheckOne()
        {
            Console.WriteLine("Är det fint väder?");
            string answer = Console.ReadLine();

            if (answer == "j")
            {
                Console.WriteLine("Vi går på picknick!");
            }
        }
    }

    // 3.3 Arbeta vidare på föregående övning men lägg till att användaren kan svara ''n''. 
    //Då skriver programmet ut ''Vi stannar inne och läser en bok''. 
    //Det ska inte spela någon roll om användaren matar in liten eller stor bokstav.
    class WeatherCheckTwo
    {
        public void displayWeatherCheckTwo()
        {
            Console.WriteLine("Är det fint väder?");
            string answer = Console.ReadLine();
            if (answer == "j" || answer == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }
            else if (answer == "n" || answer == "N")
            {
                Console.WriteLine("Vi stannar inne ock läser en bok");
            }
        }
    }

    // 3.4 Arbeta vidare med föregående övning. 
    // Gör så att om användaren matar in något annat än ''j'', ''J'', ''n'' eller ''N'' så skriver programmet ut ''Jag förstår inte''.
    class WeatherCheckThree
    {
        public void displayWeatherCheckThree()
        {
            Console.WriteLine("Är det fint väder?");
            string answer = Console.ReadLine();
            if (answer == "j" || answer == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }
            else if (answer == "n" || answer == "N")
            {
                Console.WriteLine("Vi stannar inne ock läser en bok");
            }
            else
            {
                Console.WriteLine("Jag förstår inte?");
            }
        }
    }

    //Skapa ett program där användaren får mata in temperaturen för två städer (du kan själv hitta på vilka städerna är). 
    //Programmet ska sedan berätta var det är kallast. Om det är lika kallt i båda städerna så ska programmet berätta detta istället.
    class ColdestCheckOne
    {
        public void displayColdestCheckOne()
        {
            Console.WriteLine("Skriv hur kallt det är i Göteborg: ");
            int tempGoteborg = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv hur kallt det är i Stocholm");
            int tempStockholm = int.Parse(Console.ReadLine());

            if (tempGoteborg < tempStockholm)
            {
                Console.WriteLine("Det kallare i göteborg");
            }
            else if (tempGoteborg > tempStockholm)
            {
                Console.WriteLine("Det kallare i Stockholm");
            }
            else if (tempGoteborg == tempStockholm)
            {
                Console.WriteLine("Det är lika kallt i båda städerna");
            }
        }
    }

    //3.6 Skapa ett program där användaren får mata in temperaturen för tre städer. 
    //Programmet ska berätta var det är kallast. Du kan utgå från följande kod men ersätta … med rätt booleanska villkor
    class ColdestCheckTwo
    {
        public void displayColdestCheckTwo()
        {
            Console.Write("Ange temperatur för Östersund: ");
            int ostersund = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange temperatur för Åmål: ");
            int amal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ang temperatur för Arboga: ");
            int arboga = Convert.ToInt32(Console.ReadLine());

            if (ostersund < amal && ostersund < arboga)
            {
                Console.WriteLine("Det kallast i Östersund");
            }
            else if (amal < ostersund && amal < arboga)
            {
                Console.WriteLine("Det är kallast i Åmål.");
            }
            else if (arboga < ostersund && arboga < amal)
            {
                Console.WriteLine("Det är kallat i Arboga");
            }
        }
    }

    // 3.7 Skriv ett program där användaren får mata in temperaturen för vatten. 
    //Programmet ska sedan skriva ut om vattnet är fruset, flytande eller kokande. 
    //Om du vill kan du lägga till andra kategorier också (som ljummet, hett etc).
    class CheckWaterTemp
    {
        public void displayCheckWaterTemp()
        {
            Console.Write("Skriv temperatur för vattnet: ");
            int waterTemp = int.Parse(Console.ReadLine());
            // OBS. Använd "if" för att inte få en evighets-loop. 
            if (waterTemp <= 0)
            {
                Console.WriteLine("Vattnet är fruset!");
            }
            else if (waterTemp < 50)
            {
                Console.WriteLine("Vattnet är flytanda!");
            }
            else if (waterTemp < 100)
            {
                Console.WriteLine("Vattnet är varmt!");
            }
            else
            {
                Console.WriteLine("Vattnet är kokande!");
            }
        }
    }

    // 3.8 Något stämmer inte riktigt med följande if-sats
    class WrongIf
    {
        public void DisplayWrongIf()
        {
            int var = 10;
            // Det var inget boolskt utryck. Det var tidigare en tilldelningsoperator. 
            if (var == 10)
            {
                Console.WriteLine("den är 10!");
            }
        }
    }

    //4.1 Skapa ett program som med hjäp av iteration skriver ut alla tal mellan 1 och 20.
    class NumberSequenceToTwenty
    {
        public void DisplayNumberSequenceToTwenty()
        {
            // for-loopen skriv ut heltal från 1 till 20.
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1);
            }

        }
    }

    //4.2 Skapa ett program där användaren får mata in valfritt tal upp till 100. 
    //Programmet skriver sedan ut alla tal, från talet som användaren matade in upp till och med 100. 
    //Om man matar in ett tal som är större än 100 så stängs programmet av direkt.
    class NumberSequenceToHundred
    {
        public void DisplayNumberSequenceToHundred()
        {
            Console.Write("Skriv ett heltal: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine("Programmet avbryt!");
                return;
            }
            else
            {
                for (int i = number; i <= 100; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }



    }



}
