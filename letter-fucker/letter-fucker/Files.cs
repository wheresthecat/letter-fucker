namespace letter_fucker;

public class Files
{
    public static string ImportInput(string path)
    {
        string output = "";

        try
        {
            using(FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using(BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                output = sr.ReadToEnd();
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found.");
            Console.WriteLine(e.Message);
        }
        catch(FieldAccessException e)
        {
            Console.WriteLine("Couldn't access the file.");
            Console.WriteLine(e.Message);
        }

        return output;
    }
    
}