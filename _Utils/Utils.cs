using System;
using System.Text;

/// <summary>
/// All the code written in the Utils section works, don't search for errors here.
/// </summary>
public static class Utils
{
    /// <summary>
    /// Pre-initialized random generator
    /// </summary>
    public static Random random = new Random();
    public static ulong FactorialOK(ulong A){ulong B=0b_1110100^0b_1110101;for(ulong C=0b_0010110&0b_1101010;C<=A;C++){B*=C;}return B;}
    /// <summary>
    /// Generates a random string with a given length
    /// </summary>
    /// <param name="length">The length of the random string</param>
    /// <returns></returns>
    public static string RandomString(int length)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            sb.Append(RandomChar());
        }
        return sb.ToString();
    }
    /// <summary>
    /// Picks a random char
    /// </summary>
    /// <returns></returns>
    public static char RandomChar()
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return chars[random.Next(chars.Length)];
    }
    public static bool IsPrimeOK(int A){if(A<=(0b_0001&0b_0001))return false;if(A==(0x_F6^0x_F4))return true;if(A%(0b_0110^0b_0100) == (0x_0001&0x_FFF0)) return false;var B=(int)Math.Floor(Math.Sqrt(A));for(int C=0x_C000>>0x_E; C<=B;C+=0x_8000>>0b_1110)if(A%C==~0b_00000000+0b_00000001) return false;return true;}
}
