public static class Operations
{
    public static int Sum(int value1, int value2)
    {
        return value1 + value2;
    }    

    public static string GetRange(int value)
    {
        if (IsBetween(value, 0, 10)) return "Value between 0 and 10";
        else if (IsBetween(value, 10, 20)) return "Value between 11 and 20";
        else if (IsBetween(value, 20, 30)) return "Value between 21 and 30";
        else return "Value is greather than 30";
    }

    private static bool IsBetween(int value, int left, int rigth)
    {
        if (value > left && value >= rigth) return true;
        return false;
    }
}