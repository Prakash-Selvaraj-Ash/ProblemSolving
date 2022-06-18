using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Algorithms
{
    public class LongestSubstringKChar
    {
        public LongestSubstringKChar()
        {
        }

        static int MAX_CHARS = 26;

        // This function calculates number  
        // of unique characters  
        // using a associative array  
        // count[]. Returns true if  
        // no. of characters are less  
        // than required else returns  
        // false.  
        static bool isValid(int[] count,
                                       int k)
        {
            int val = 0;
            for (int i = 0; i < MAX_CHARS; i++)
            {
                if (count[i] > 0)
                {
                    val++;
                }
            }

            // Return true if k is greater 
            // than or equal to val  
            return (k >= val);
        }

        // Finds the maximum substring  
        // with exactly k unique chars  
        static void kUniques(String s, int k)
        {
            int u = 0;
            int n = s.Length;

            // Associative array to store  
            // the count of characters  
            int[] count = new int[MAX_CHARS];
            Array.Fill(count, 0);
            // Traverse the string, Fills  
            // the associative array  
            // count[] and count number  
            // of unique characters  
            for (int i = 0; i < n; i++)
            {
                if (count[s[i] - 'a'] == 0)
                {
                    u++;
                }
                count[s[i] - 'a']++;
            }

            // If there are not enough  
            // unique characters, show  
            // an error message.  
            if (u < k)
            {
                Console.WriteLine("Not enough unique characters");
                return;
            }

            // Otherwise take a window with 
            // first element in it.  
            // start and end variables.  
            int curr_start = 0, curr_end = 0;

            // Also initialize values for 
            // result longest window  
            int max_window_size = 1;
            int max_window_start = 0;

            // Initialize associative  
            // array count[] with zero  
            Array.Fill(count, 0);

            // put the first character  
            count[s[0] - 'a']++;

            // Start from the second character and add  
            // characters in window according to above  
            // explanation  
            for (int i = 1; i < n; i++)
            {
                // Add the character 's[i]'  
                // to current window  
                count[s[i] - 'a']++;
                curr_end++;

                // If there are more than k  
                // unique characters in  
                // current window, remove from left side  
                while (!isValid(count, k))
                {
                    count[s[curr_start] - 'a']--;
                    curr_start++;
                }

                // Update the max window size if required  
                if (curr_end - curr_start + 1 > max_window_size)
                {
                    max_window_size = curr_end - curr_start + 1;
                    max_window_start = curr_start;
                }
            }

            Console.WriteLine("Max sustring is : "
                    + s.Substring(max_window_start,
                        max_window_size)
                    + " with length " + max_window_size);
        }

        public void Run()
        {
            String s = "karappa";
            int k = 2;
            kUniques(s, k);
        }
    }

    public class LongestSubstring
    {
        public void Run()
        {
            String s = "karappa";
            int k = 2;

            kUniques(s, k);
            
        }

        void kUniques(string str, int k)
        {
            int start = 0;
            int end = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            int strLen = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    int value = dict[str[start]];
                    dict[str[i]] = value+1; 
                }
                else
                {
                    dict[str[i]] = 1;
                }

                end++;
                while (!IsValid(dict, k) && start < strLen)
                {
                    //if(start < strLen)
                    {
                        if (dict.ContainsKey(str[start]))
                        {
                            int value = dict[str[start]];
                            dict[str[start]] = value-1;
                        }
                        else
                        {
                            dict[str[start]] = 1;
                        }
                        start++;
                    }
                }
            }

            int endLength = end - start;

            Console.WriteLine("Max sustring is : "
                + str.Substring(start, endLength)
                + " with length " + endLength);
        }

        private bool IsValid(Dictionary<char, int> dict, int k)
        {
            return dict.Where(d => d.Value > 0).Count() <= k;
        }
    }
}
