namespace Assignment_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager

            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            Console.WriteLine("Original Grades:");
            Console.WriteLine(string.Join(", ", grades));

            Console.WriteLine(grades.Count);

            Console.WriteLine(grades[0]);

            Console.WriteLine(grades[grades.Count - 1]);

            grades.Sort();
            Console.WriteLine("\nSorted Grades:");
            Console.WriteLine(string.Join(", ", grades));

            int result = grades.FirstOrDefault(g => g > 90);
            Console.WriteLine($"First Grade Above 90: {result}");

            List<int> failGrades = grades.Where(g => g < 75).ToList();
            Console.WriteLine("Failing Grades:");
            Console.WriteLine(string.Join(", ", failGrades));

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("Grades After Removing Failing Grades:");
            Console.WriteLine(string.Join(", ", grades));

            bool has100 = grades.Any(g => g == 100);
            Console.WriteLine($"Contains 100: {has100}");

            List<string> gradeDescriptions = grades. Select(g => $"Grade: {g}") .ToList();
            Console.WriteLine("Grade Descriptions:");
            foreach (string description in gradeDescriptions)
            {
                Console.WriteLine(description);
            }

            #endregion


            #region Exercise 2: Leaderboard
            SortedDictionary<int, string> leaderboard = new(){
                {500 , "Ahmed" },
                { 200 , "Sara" },
                { 800 , "Ali" },
                { 350 , "Mona" }
            };

            foreach(var player in leaderboard)
            {
                Console.WriteLine($"{player.Key} = {player.Value}");
            }

            Console.WriteLine(leaderboard.Keys.First());
            Console.WriteLine(leaderboard.Values.First());

            Console.WriteLine(leaderboard.ContainsKey(500)) ;

            if (leaderboard.TryGetValue(999, out string playerName))
                Console.WriteLine(playerName);
            else
                Console.WriteLine("Player not found");

            leaderboard.Remove(200);
            foreach (var player in leaderboard)
            {
                Console.WriteLine($"{player.Key} = {player.Value}");
            }

            #endregion


            #region Exercise 3:  Phone Book

            Dictionary<string, string> phoneBook = new()
            {
                { "Ahmed", "01011111111" },
                { "Sara", "01022222222" },
                { "Mona", "01033333333" },
                { "Ali", "01044444444" } 
            };

            phoneBook["Omar"] = "01055555555";

            try
            {
                phoneBook.Add("Ahmed", "01111111111");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            bool newPhone = phoneBook.TryAdd("Ahmed", "01222222222");
            Console.WriteLine(newPhone);

            Console.WriteLine(phoneBook.ContainsKey("Menna"));

            if (phoneBook.TryGetValue("Menna", out string phone))
                Console.WriteLine(phone);
            else
                Console.WriteLine("Not Found");

            Console.WriteLine(string.Join(" , " , phoneBook.Keys));
            Console.WriteLine(string.Join(" , ", phoneBook.Values));


            #endregion


            #region Exercise 4 :  Unique Email Validator

            HashSet<string> emails = new (StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine(emails.Count);

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> union = setA;
            union.UnionWith(setB);
            Console.WriteLine($"union: {string.Join(", ", union)}");

            HashSet<int> intersection =setA;
            intersection.IntersectWith(setB);
            Console.WriteLine($"intersection: {string.Join(", ", intersection)}");

            HashSet<int> difference = setA;
            difference.ExceptWith(setB);
            Console.WriteLine($"difference: {string.Join(", ", difference)}");

            HashSet<int> subset = new HashSet<int> { 1, 2 };
            Console.WriteLine($"is subset: {subset.IsSubsetOf(setA)}");


            #endregion


            #region Exercise 6: Browser History (Undo)

            Stack<string> history = new Stack<string>();

            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");

            Console.WriteLine($"Current Page: {history.Peek()}");

            for (int i = 0; i < 3; i++)
            {
                string leavingPage = history.Pop();
                Console.WriteLine($"Leaving Page: {leavingPage}");
            }

            Console.WriteLine($"Current Page After Back: {history.Peek()}");

            Stack<string> emptyHistory = new Stack<string>();
            bool success = emptyHistory.TryPop(out string page);
            Console.WriteLine($"TryPop succeeded: {success}");

            #endregion
        }
    }
}
