namespace letter_fucker;

public class Files
{
    public static string ImportInput(string path)
    {
        string output = "";

        try
        {
            using (StreamReader sr = new StreamReader(path))
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