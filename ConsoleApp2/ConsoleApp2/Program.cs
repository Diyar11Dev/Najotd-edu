﻿// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");
string hashcode = HashGenerator.Generate("diyarii1713");
Console.WriteLine(hashcode);
public class HashGenerator
{
    public static string Generate(string password)
    {
        const int keySize = 64;
        const int iterations = 350000;

        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            new byte[0],
            iterations,
            hashAlgorithm,
            keySize);

        return Convert.ToHexString(hash);
    }

}