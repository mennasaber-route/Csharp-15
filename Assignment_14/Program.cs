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

            List<string> gradeDescriptions = grades
            .Select(g => $"Grade: {g}")
            .ToList();
            Console.WriteLine("Grade Descriptions:");
            foreach (string description in gradeDescriptions)
            {
                Console.WriteLine(description);
            }

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
