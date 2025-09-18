namespace MetoderÖvning3
{
    internal class Program
    {
        static string[] toDoList = Array.Empty<string>(); 
        static void Main(string[] args)
        {
            Console.WriteLine("Vad behöver du göra idag?");

            // do While loop tills användarens input == "klar"
            //Läs användarens input
            //appenda strängen till en sträng array
            string input;
            do
            {
                input = Console.ReadLine();
                if(input != "klar")
                {
                    string[] appended = new string[toDoList.Length + 1];
                    Array.Copy(toDoList, appended, toDoList.Length);
                    appended[appended.Length - 1] = input;
                    toDoList = appended;
                }
            }
            while (input != "klar");

            // for loop som går igenom sträng arrayen och skriver ut varje sak som användaren vill ha gjort
            Console.WriteLine("Dina uppgifter idag:");
            for (int i = 0; i < toDoList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }
        }
    }
}
