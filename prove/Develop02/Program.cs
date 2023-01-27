using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        DisplayData data = new DisplayData();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5){

            Options options = new Options();
            options._options = "Please select one of the following choices";
            options._select = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n";
            options.DisplayInfo();
            choice = options._choice;
            

            if (choice == 1){

                Entry entry = new Entry();
                entry._list = new List<string> { "Who was the most interesting person I interacted with today?","What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?", "What was the funniest thing of the day?"};
    
                entry.DisplayRandom();
                String prompt = entry._prompt;
                String answer = entry._answer;
                entry._date = dateText;
                entry._prompt = prompt;
                entry._answer = answer;
                data.entryList.Add(entry);
            } 

            else if (choice == 2){
                data.DisplayResults();
            }

            else if (choice == 3){
                String name = options.NameOfFile();
                LoadData loadData = new LoadData();
                loadData.LoadEntryData(name, data);   
            }
            else if (choice == 4){
                String name = options.NameOfFile();
                data.SaveIntoFile(name);
            }
        
        } 
        Console.WriteLine("See you tomorrow");

    }
}