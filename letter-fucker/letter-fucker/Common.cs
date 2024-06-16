namespace letter_fucker;

public static class Common
{
    public static double GetPercents(int part, int whole)
    {
        double output = 0.00f;

        output = part / (whole / 100);

        return output;
    }
}