using System.Text;

// O(n+m)
namespace leetcode;

public class MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new StringBuilder();
        int j = 0;
        for (int i = 0; i < word1.Length; i++)
        {
            result.Append(word1[i]);
            if (i < word2.Length)
            {
                result.Append(word2[i]);
                j++;
            }
        }

        while (j < word2.Length)
        {
            result.Append(word2[j]);
            j++;
        }

        return result.ToString();
    }
}