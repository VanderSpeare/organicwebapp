using System.Security.Cryptography;
using System.Text;

namespace WebApp.Services;

public static class HashHelpers
{
    public static string HashSha256(this string plaintext)
    {
        return Convert.ToHexString(SHA512.HashData(Encoding.ASCII.GetBytes(plaintext)));

    }
    public static string HashHmacSha512(this string plaintext, string key)
    {
        return Convert.ToHexString(HMACSHA512.HashData(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(plaintext)));
    }
}