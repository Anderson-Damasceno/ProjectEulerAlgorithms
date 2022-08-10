// Multiples of 3 and 5
/* 
 If we list all the natural numbers below 10 that are multiples
 of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 Find the sum of all the multiples of 3 or 5 below 1000.
*/
namespace Problems.Sum_Of_Multiples_Of_3_And_5_Up_To_1000; 

public class Sum_Of_Multiples
{
    public int[] array = new int[1000];

    public void InitializingArray()
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        
    }

    public int SumOfMultiples()
    {
        int sum = 0;
        for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] % 3 == 0 || array[i] % 5 == 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
    
}


