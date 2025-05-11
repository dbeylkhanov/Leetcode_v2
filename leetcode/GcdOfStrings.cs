using System.Text;

namespace leetcode;

//O(n ⋅ (m + n))
public class GcdOfStrings
{
    public string Exec(string str1, string str2) {
        var result = new StringBuilder(str1.Length < str2.Length ? str1 : str2);
        while (result.Length > 0)
        {
            if (str1.Length % result.Length == 0 && str2.Length % result.Length == 0)
            {
                var strResult = result.ToString();
                if (str1.Split(strResult, StringSplitOptions.RemoveEmptyEntries).Length == 0
                    && str2.Split(strResult, StringSplitOptions.RemoveEmptyEntries).Length == 0)
                    return strResult;
            }
            result = result.Remove(result.Length - 1, 1);
        }
        return String.Empty;
    }
}