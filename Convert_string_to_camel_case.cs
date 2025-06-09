using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
  }
}