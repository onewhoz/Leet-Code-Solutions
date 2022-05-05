
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        IDictionary<char, int> resultMap = new Dictionary<char, int>();
        IDictionary<char, int> resultMap2 = new Dictionary<char, int>();

        int num = 0;
        for (int i = 0; i < s.Length; i++){
      
            
           if (resultMap.TryGetValue(s[i], out num)){
                resultMap[s[i]] = 1 + num;
           }
            else resultMap[s[i]] = 1;
            
            if (resultMap2.TryGetValue(t[i], out num)){
                resultMap2[t[i]] = 1 + num;
           }
            else resultMap2[t[i]] = 1;   
        }
        
        foreach(var item in resultMap)
        {
            if(resultMap2.ContainsKey(item.Key) == false 
               || item.Value != resultMap2[item.Key]) return false;
        }
        return true;
        
        
    }
}
