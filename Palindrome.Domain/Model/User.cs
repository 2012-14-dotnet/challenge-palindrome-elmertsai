

namespace Palindrome.Domain.Models
{
  public class User
  {
    public string input { get; set; }


    public bool IsPalindrome(string s)
        {
            int length = s.Length;
            s = s.ToLower();
            for(int i=0; i<length/2; i++)
            {
                if(s[i] != s[length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
  }
}
