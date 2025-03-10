﻿using System.ComponentModel;

class SmallExercises
{
    static void Main(string[] args)
    {
        new SumNumber().displaySumNumber();
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
        //new NumberSequenceToHundred().DisplayNumberSequenceToHundred();
        //new FlipACoin().DisplayFlipACoin();
        //new WrongLoop().DisplayWrongLoop();
        //new ThrowTheDice().DisplayTrowTheDice();
        //new Triangle().DisplayTriangle();
        //new ReversedTriangle().DisplayReversedTriangle();

    }

    // 2.1 Skapa ett program där användaren får mata in två heltal, varefter programmet beräknar summan.
    class SumNumber
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

            Console.WriteLine("Skriv hur kallt det är i Stockholm");
            int tempStockholm = int.Parse(Console.ReadLine());

            if (tempGoteborg < tempStockholm)
            {
                Console.WriteLine("Det kallare i Göteborg");
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
                Console.WriteLine("Det är kallast i Arboga");
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
            // Det var inget boolskt uttryck. Det var tidigare en tilldelande operator. 
            if (var == 10)
            {
                Console.WriteLine("den är 10!");
            }
        }
    }

    // 4.1 Skapa ett program som med hjäp av iteration skriver ut alla tal mellan 1 och 20.
    class NumberSequenceToTwenty
    {
        public void DisplayNumberSequenceToTwenty()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1);
            }

        }
    }

    // 4.2 Skapa ett program där användaren får mata in valfritt tal upp till 100. 
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

    //4.3 Be användaren mata in hur många gånger han eller hon vill singla slant. 
    //Programmet ska sedan slumpvis mata ut om det blir krona eller klave, lika många gånger som användaren angett.
    //För att implementera uppgiften i C# behöver du söka reda på hur man slumpar fram saker.
    class FlipACoin
    {
        public void DisplayFlipACoin()
        {
            Console.Write("Hur många gånger vill du singla slant? ");
            int inputFlips = int.Parse(Console.ReadLine());
            // Klassen Random används för att generera slumpmässiga tal.
            Random randomFlips = new Random(inputFlips);

            int head = 0; // Börjar på 0
            int tail = 0; // Börjar på 0

            for (int i = 0; i < inputFlips; i++)
            {
                if (randomFlips.Next(2) == 0)
                {
                    head++;
                    Console.WriteLine("Det är krona!");
                }
                else
                {
                    tail++;
                    Console.WriteLine("Det är klave!");
                }
            }
        }
    }

    // 4.4 Följande loop simulerar en bilfärd men får vi ett felmeddelande.
    // Detta är ett kompileringsfel: Cannot implicitly convert type 'string' to 'bool'. 
    class WrongLoop
    {
        public void DisplayWrongLoop()
        {
            string str;
            do
            {
                Console.WriteLine("Är vi framme snart?");
                str = Console.ReadLine();
                //Ändrad till en jämnförande operator "==".
            } while (str == "n");
        }
    }

    // 4.5 Skapa ett program som fem gånger slumpar fram tärningsslag (tal mellan 1 och 6). Börja med att skriva pseudokod för detta.
    // För att implementera uppgiften i C# behöver du söka reda på hur man slumpar fram saker.
    // ======= pseudokod =========
    // 1. Kasta tärning
    // 2. Upprepa 5 gånger
    // 3. Tärningsnummer = visar slumpmässigt tal mellan 1 och 6
    // 4. Skriv ut kastnummer och tärningsnummer
    // 6. Avsluta program
    class ThrowTheDice
    {
        public void DisplayTrowTheDice()
        {
            Console.WriteLine("Tärningen kastas 5 gånger!");
            // Klassen Random används för att generera slumpmässiga tal.
            Random randomCount = new Random();

            for (int i = 0; i < 5; i++)
            {
                int diceNumber = randomCount.Next(1, 7); //genererar värden mellan 1 till 6
                Console.WriteLine($"Antal kast {i + 1}: {diceNumber}");
            }
        }
    }

    //4.6 För att lösa denna uppgift beöver du använda två loopar. En loop inuti en annan. 
    //Skriv ett program där man kan mata in en siffra x. Programmet skriver sedan ut en triangel fylld av tecknet x, med x som bas och x som höjd. 
    //Med basen uppåt och spetsen nedåt. 
    class Triangle
    {
        public void DisplayTriangle()
        {
            Console.Write("Ange antal: ");
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = inputNumber; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{inputNumber} ");
                }
                Console.WriteLine();
            }
        }
    }

    // 4.7 Utveckla programmet ovan, men vänd så triangelns bas är nedåt och spetsen uppåt. 
    class ReversedTriangle
    {
        public void DisplayReversedTriangle()
        {
            Console.Write("Ange antal: ");
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{inputNumber} ");
                }
                Console.WriteLine();
            }
        }
    }
}
