using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSimilarTitles
{
    public class SolutionMain
    {
        public static List<List<string>> GetTitles(string[] titles)
        {
            if (titles.Length == 0)
            {
                return new List<List<string>>();

            }

            Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

            foreach (var title in titles)
            {
                int[] count = new int[26];
                foreach (var c in title.ToCharArray())
                {
                    var index = c - 'a';
                    count[index]++;
                }

                var key = string.Join(" ", count);
                if (!res.ContainsKey(key))
                {
                    res[key] = new List<string>();
                }

                res[key].Add(title);

            }

            return (res.Values.ToList());
        }

       
    }
}
