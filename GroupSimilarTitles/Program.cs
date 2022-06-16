// See https://aka.ms/new-console-template for more information
using GroupSimilarTitles;

Console.WriteLine("Hello, World!");

string[] titles = { "duel", "dule", "speed", "spede", "deul", "cars" };

var gt = SolutionMain.GetTitles(titles);

string query = "spede";

// Searching for all titles
foreach (List<string> g in gt)
{
    if (g.Contains(query))
         Console.WriteLine("[{0}]", string.Join(", ", g));
}