//-----------------------------------------------------------------------------
// Runtime: 1ms
// Memory Usage: 41.95 MB
// Link: https://leetcode.com/problems/first-letter-to-appear-twice/description/
//-----------------------------------------------------------------------------


public class Solution {
    public char RepeatedCharacter(string s) {
         Dictionary<char, int> prvky = new Dictionary<char, int>();
 
 for (int i = 0 ; i < s.Length ; i++)
 {
     if (prvky.ContainsKey(s[i]))
        return  s[i];
     prvky[s[i]] = i;                  
 }
    return '0';
    }
}