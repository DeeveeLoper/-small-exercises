class SmallExercises
{
    static void Main(string[] args)
    {

        //new SumNumer().displaySumNumber();

        //new AverageValue().displayAverageValue();

        new StoryWithTwoNames().displayStoryWithTwoNames();



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

    // Låt användaren mata in namnet på två personer. Programmet ska sedan skriva ut en kort berättelse om dessa två personer.
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


}