namespace letter_fucker;

public class Files
{
    public static string ImportInput(string path)
    {
        string output = "";

        using (StreamReader sr = new StreamReader(path))
        {
            output = sr.ReadToEnd();
        }
        
        return output;
    }
    
}