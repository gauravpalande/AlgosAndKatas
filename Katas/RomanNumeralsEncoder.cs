using System;

public class RomanConvert
{
	public static string Solution(int n)
	{
  string roman = "";
  string[] thousand = {"","M","MM","MMM"};
  string[] hundred = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
  string[] ten = {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
  string[] one = {"","I","II","III","IV","V","VI","VII","VIII","IX"};
  
  roman += thousand[(n/1000)%10];
  roman += hundred[(n/100)%10];
  roman += ten[(n/10)%10];
  roman += one[n%10];
  
  return roman;
		
	}
}