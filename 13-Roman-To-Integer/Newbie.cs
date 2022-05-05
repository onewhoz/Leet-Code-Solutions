public class Solution {
    public int RomanToInt(string s)
            {
                int result = 0;
                int i = 0;
                char prev = 'A';
                for (i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case 'I':
                            result += 1;
                            prev = s[i];
                            break;
                        case 'V':
                            if (prev == 'I')
                            {
                                result += 3;
                            }
                            else
                            {
                                result += 5;
                            }
                                
                            break;
                        case 'X':
                            if (prev == 'I')
                            {
                                result += 8;
                            }
                            else
                            {
                                result += 10;
                            }

                            prev = s[i];
                            break;
                        case 'L':
                            if (prev == 'X')
                            {
                                result += 30;
                            }
                            else
                            {
                                result += 50;
                            }
                            
                            break;
                        case 'C':
                            if (prev == 'X')
                            {
                                result += 80;
                            }
                            else
                            {
                                result += 100;
                            }
                            prev = s[i];
                            break;
                        case 'D':
                            if (prev == 'C')
                            {
                                result += 300;
                            }
                            else
                            {
                                result += 500;
                            }

                            break;
                        case 'M':
                            if (prev == 'C')
                            {
                                result += 800;
                            }
                            else
                            {
                                result += 1000;
                            }
                            break;
                      
                    }
                }

                return result;
            }
        
    }
