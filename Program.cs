using System;
public class Program
{
    public static void Main()
    {
        string strFirst;
        char charCount;
        int Count = 0;
        Console.Write("Enter your text: ");
        strFirst = Console.ReadLine();
        Console.Write("Enter Count Character: ");
        charCount = Convert.ToChar(Console.ReadLine());
        Console.Write("Your character Count: ");
        foreach(char chr in strFirst) {
            if (chr == charCount) {
                Count++;
            }
        }
        Console.Write(Count);
    }
}