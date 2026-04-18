using System.Reflection.Metadata.Ecma335;

namespace Leetcode_Practice
{
    public class RandsomNote
    {
        private Dictionary<char, int> MakeCountMap(string s)
        {
            Dictionary<char, int> counts = new();
            foreach(char c in s)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                } else
                {
                    counts[c] = 1;
                }
            }
            return counts;
        }

        public bool CanConstruct(string randsomNote, string magazine)
        {
            if (randsomNote.Length > magazine.Length)
            {
                return false;
            }

            Dictionary<char, int> magazineCount = MakeCountMap(magazine);

            foreach (char c in randsomNote)
            {
                if(magazineCount.TryGetValue(c, out int countInMagazine))
                {
                    if (countInMagazine == 0)
                    {
                        return false;
                    } 

                    magazineCount[c] = countInMagazine - 1;
                } else
                {
                    return false;
                }
            }
            return true;
        }

         public bool CanConstruct2(string randsomNote, string magazine)
        {
            if (randsomNote.Length > magazine.Length)
            {
                return false;
            }

            Dictionary<char, int> magazineCount = MakeCountMap(magazine);

            foreach (char c in randsomNote)
            {   
                
                if(magazineCount.ContainsKey(c))
                {
                    int countInMagazine = magazineCount[c];
                    if (countInMagazine == 0)
                    {
                        return false;
                    } 

                    magazineCount[c] = countInMagazine - 1;
                } else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

// RandsomNote randsomNote = new();

// string randsomnote = "aa", magazine = "aab";

// bool result = randsomNote.CanConstruct(randsomnote, magazine);
// Console.WriteLine($"Can construct: {result}");