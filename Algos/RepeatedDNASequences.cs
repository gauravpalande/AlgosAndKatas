public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) 
    {
        var n = s.Length;
        var lo = 0;
        var hi = 0;   
        var hash = 0;
        var seen = new Dictionary<int, int>();
        var result = new List<string>();
        var baseNum = 5;
        var highestPower = (int)Math.Pow(baseNum, 9);
        while(hi < n)
        {
            hash = baseNum * hash + (s[hi] - 'a');
            if (hi - lo + 1 == 10)
            {
                seen[hash] = seen.GetValueOrDefault(hash, 0) + 1;
                if (seen[hash] == 2)
                {
                    result.Add(s.Substring(lo, hi - lo + 1));
                }
                hash -= (s[lo] - 'a') * highestPower;
                lo++;
            }
            hi++;
        }
        return result;
    }
}