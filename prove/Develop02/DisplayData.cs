using System.IO; 

public class DisplayData
{
    public List<Entry> entryList = new List<Entry>();
    public void DisplayResults (){

        foreach(Entry item in entryList){
            Console.WriteLine($"date: {item._date} - Prompt: {item._prompt}\n{item._answer}");
            Console.WriteLine();
        }
    }

//The program allows the user to save the data into a csv file
    public void SaveIntoFile (String fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Entry item in entryList){
                outputFile.WriteLine($"{item._date},{item._prompt},{item._answer},");
            }
        }
    }
}
