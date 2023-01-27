class LoadData
{

    public void LoadEntryData (String name, DisplayData data){

        String[] lines = System.IO.File.ReadAllLines(name);
        
        foreach (String line in lines) {

            string[] parts = line.Split(",");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._answer = parts[2];
            data.entryList.Add(entry);
        }
    }
}