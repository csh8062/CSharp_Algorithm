using System;

public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = 0;

        if (0 < num1 && num1 <= 100) ;
        if (0 < num2 && num2 <= 100) ;

        double result;

        result = ((double)num1 / (double)num2) * 1000;
        answer = (int)result;

        return answer;
    }
}