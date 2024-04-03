using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithmlab1_group10
{
    public class task_2
    {
        /* Pseudokod för uppgift 2

         FUNCTION findBiggestElement()  //O(1) - tilldeldning
            int[] array     // O(1) - tilldelning
            for i from 1 to lenght(array)   // O(n) iterera
                if array > array[bigIndex]  //O(1) jämförelse
                    bigIndex = i    //O(1) tilldeldning
            print("Det största talet är, array[bigIndex] och finns på indexet: [bigIndex]")
        */
        public static void findBiggestElement()
        {

            int[] array = { 1, 4, 3, 6, 5, 9, 8, 5, 6, 4 }; //O(1)
            int bigIndex = 0; //O(1)
            for (int i = 1; i < array.Length; i++) //O(n)
            {
                if (array[i] > array[bigIndex]) //O(1)
                {
                    bigIndex = i; //O(1)
                }
            }
            Console.WriteLine($"Det största talet är: {array[bigIndex]} och finns på indexet: {bigIndex}");
        }
    }
}
