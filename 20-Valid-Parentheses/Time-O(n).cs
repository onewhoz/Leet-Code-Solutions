public class Solution {
     public bool IsValid(string s)
            {
                int curlycount = 0;
                int bracketscount = 0;
                int parentheseescount = 0;
                string remmember = "";
                bool validity = false;
                for (int i = 0; i < s.Length; i++)
                {
                    
                    switch (s[i])
                    {
                        case '(':
                            parentheseescount++;
                            remmember += s[i];
                            break;
                        case '[':
                            bracketscount++;
                            remmember += s[i];
                            break;
                        case '{':
                            curlycount++;
                            remmember += s[i];
                            break;
                        case ')':
                            if (parentheseescount != 0 && remmember[remmember.Length - 1] == '(')
                            {
                                validity = true;
                                parentheseescount--;
                                remmember = remmember.Remove(remmember.Length - 1);
                            }
                            else return false;
                            break;
                        case ']':
                            if (bracketscount != 0 && remmember[remmember.Length - 1] == '[')
                            {
                                validity = true;
                                bracketscount--;
                                remmember = remmember.Remove(remmember.Length - 1);
                            }
                            else return false;
                            break;
                        case '}':
                            if (curlycount != 0 && remmember[remmember.Length - 1] == '{')
                            {
                                validity = true;
                                curlycount--;
                                remmember = remmember.Remove(remmember.Length - 1);
                            }
                            else return false;
                            break;

                    }
                 
                }
          if (curlycount > 0 || parentheseescount > 0 || bracketscount > 0)
                    {
                        return false;
                    }
                return validity;
            }
}
