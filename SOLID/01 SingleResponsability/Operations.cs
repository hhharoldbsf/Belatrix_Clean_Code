public static class Operations
{
    public static int Sum(int value1, int value2)
    {
        return value1 + value2;
    }

    public static bool IsBetween(int value, int left, int rigth)
    {
        if (value > left && value >= rigth) return true;
        return false;
    }
}