using System;
using System.Diagnostics;

public class Binary
{
    private readonly int value;

    public Binary(int value)
    {
        this.value = value;
    }

    public static implicit operator Binary(string b)
    {
        return new Binary(Convert.ToInt32(b, 2));
    }

    public static explicit operator int(Binary b)
    {
        return b.value;
    }

    public static Binary operator +(Binary a, Binary b)
    {
        return new Binary(a.value + b.value);
    }

    public static Binary operator -(Binary a, Binary b)
    {
        return new Binary(a.value - b.value);
    }

    public static void PrintBinary(Binary binary)
    {
        Debug.WriteLine("binary: " + (int)binary);
    }
}