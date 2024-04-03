using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithmlab1_group10
{
    public class task_4
    {
        /* 
         * Pseudokod till uppgift 4

        FUNCTION replaceCharacters()    
            str beginning_word  //0(1) - tilldeldning av variabel
            str[] vowels // O(1) tilldeldning av variabel
            result_word = ""

            FOR EACH character c IN beginning_word  //O(n) iterera
                IF IndexOf(vowels, ToLower(c)) != -1    //O(1) jämförelse 
                    Append '*' to result_word   //O(1) artimetisk operation
                ELSE    
                    Append c to result_word //O(1) artimetisk operation

            Print result_word

        */
        public static void replaceCharacters()
        {
            string beginning_word = "Hello world!";  //O(1)
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };  //O(1)
            string result_word = "";

            foreach (char c in beginning_word) // O(n)
            {
                if (Array.IndexOf(vowels, char.ToLower(c)) != -1) // O(1)
                {
                    result_word += "*";   // O(1)
                }
                else result_word += c;  //O(1)
            }
            Console.WriteLine(result_word);
        }
    }
}
