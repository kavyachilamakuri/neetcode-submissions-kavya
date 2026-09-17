public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        int x = 0;

        if (s2.Length < s1.Length)
            return false;

        var freq1 = new int[26];

        // Frequency of characters in s1
        for (int i = 0; i < s1.Length; i++)
        {
            freq1[s1[i] - 'a']++;
        }

        while (x <= s2.Length - s1.Length)
        {
            // First character itself doesn't exist in s1
            if (freq1[s2[x] - 'a'] <= 0)
            {
                x++;
            }
            else
            {
                // We found a possible window
                int start = x;
                int end = x + s1.Length - 1;

                var seen = new int[26];
                bool validWindow = true;

                for (int t = start; t <= end; t++)
                {
                    int index = s2[t] - 'a';

                    // Character doesn't exist in s1
                    if (freq1[index] == 0)
                    {
                        validWindow = false;
                        break;
                    }

                    seen[index]++;

                    // Character appeared more times than allowed
                    if (seen[index] > freq1[index])
                    {
                        validWindow = false;
                        break;
                    }
                }

                // Entire window was valid
                if (validWindow)
                    return true;

                // Try next window
                x++;
            }
        }

        return false;
    }
}