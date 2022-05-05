public class Solution {
    public string IntToRoman(int num) {
        
                string result = "";

                if (num / 1000 <= 3)
                {
                    for (int i = 0; i < num / 1000; i++)
                    {
                        result += 'M';
                    }
                    num -= (num / 1000) * 1000;
                }
                if (num / 100 == 9)
                {
                    result += "CM";
                    num -= 900;
                }
                else if (num / 100 == 4)
                {
                    result += "CD";
                    num -= 400;
                }
                if (num / 500 <= 1)
                {
                    for (int i = 0; i < num / 500; i++)
                    {
                        result += 'D';
                    }
                    num -= (num / 500) * 500;
                }
                if (num / 100 <= 3)
                {
                    for (int i = 0; i < num / 100; i++)
                    {
                        result += 'C';
                    }
                    num -= (num / 100) * 100;
                }


                if (num / 10 == 4)
                {
                    result += "XL";
                    num -= 40;
                }
                else if (num / 10 == 9)
                {
                    result += "XC";
                    num -= 90;
                }
                if (num / 50 <= 1)
                {
                    for (int i = 0; i < num / 50; i++)
                    {
                        result += 'L';
                    }
                    num -= (num / 50) * 50;
                }
                if (num / 10 <= 3)
                {
                    for (int i = 0; i < num / 10; i++)
                    {
                        result += 'X';
                    }
                    num -= (num / 10) * 10;
                }
                
                if (num / 5 <= 1 && num % 5 != 4)
                {
                    for (int i = 0; i < num / 5; i++)
                    {
                        result += 'V';
                    }
                    num -= (num / 5) * 5;
                }
               
                if ( num / 1 <= 3)
                {
                   for(int i = 0; i < num / 1; i++)
                    {
                        result += 'I';
                    }
                }
                else if (num / 1 == 4)
                {
                    result += "IV";
                }
                else if (num / 1 == 9)
                {
                    result += "IX";
                }


                return result;
    }
}
