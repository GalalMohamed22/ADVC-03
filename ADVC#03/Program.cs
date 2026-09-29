using System.Collections.Generic;

namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager

            //List<int> Grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //foreach (int Grade in Grades)
            //{
            //    Console.WriteLine(Grade);
            //}

            //Console.WriteLine(Grades.Count);
            //Console.WriteLine(Grades[0]);
            //Console.WriteLine(Grades[Grades.Count - 1]);
            //Grades.Sort();
            //foreach (int Grade in Grades)
            //{
            //    Console.WriteLine(Grade);
            //}
            //Console.WriteLine(Grades.Find(p => p > 90));
            //List<int> nums = Grades.FindAll(p => p < 75);
            //Grades.RemoveAll(p => p < 75);
            //Console.WriteLine(Grades.Find(p => p == 100));
            //List<string> strings = Grades.ConvertAll(p => $"Grade: {p}");
            //foreach (var Grade in strings)
            //{
            //    Console.WriteLine(Grade);
            //}

            #endregion


            #region Exercise 2: Leaderboard

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");


            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key} - Player: {entry.Value}");
            //}

            //Console.WriteLine(leaderboard.Keys.First());
            //Console.WriteLine(leaderboard.Values.First());
            //Console.WriteLine(leaderboard.ContainsKey(500));
            //Console.WriteLine(leaderboard.ContainsKey(500));

            //if (leaderboard.TryGetValue(999, out string player999))
            //{
            //    Console.WriteLine($"Player with score 999: {player999}");
            //}
            //else
            //{
            //    Console.WriteLine("No player found with score 999");
            //}

            //leaderboard.Remove(200);

            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key} - Player: {entry.Value}");
            //}



            #endregion



            #region Exercise 3: Phone Book

            //    Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    { "Ahmed", "01011111111" },
            //    { "Sara",  "01022222222" },
            //    { "Ali",   "01033333333" },
            //    { "Mona",  "01044444444" }
            //};


            //    foreach (var contact in phoneBook)
            //    {
            //        Console.WriteLine($"{contact.Key} : {contact.Value}");
            //    }

            //    phoneBook["Omar"] = "01055555555";   
            //    phoneBook["Ahmed"] = "01099999999";  

            //    Console.WriteLine("----- After -----");
            //    foreach (var contact in phoneBook)
            //    {
            //        Console.WriteLine($"{contact.Key} : {contact.Value}");
            //    }

            //    try
            //    {
            //        phoneBook.Add("Sara", "01000000000"); 
            //        Console.WriteLine("Contact added successfully.");
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }


            //    bool added = phoneBook.TryAdd("Ali", "01088888888"); 
            //    Console.WriteLine($"TryAdd succeeded? {added}");


            //    bool exists = phoneBook.ContainsKey("Khaled");
            //    Console.WriteLine($"Does 'Khaled' exist in the phone book? {exists}");


            //    string number = phoneBook.TryGetValue("Khaled", out string phone) ? phone : "Not Found";
            //    Console.WriteLine($"Khaled's number: {number}");


            //    Console.WriteLine("Keys   : " + string.Join(", ", phoneBook.Keys));
            //    Console.WriteLine("Values : " + string.Join(", ", phoneBook.Values));


            #endregion


            #region  Exercise 4: Unique Email Validator

            // HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            // set.Add("ahmed@test.com");
            // set.Add("AHMED@test.com");
            // set.Add("sara@test.com");
            // set.Add("Sara@Test.Com");
            // Console.WriteLine(set.Count); // 2 because hashset don't allowed duplicate and we used StringComparer.OrdinalIgnoreCase
            //HashSet<int> A = new() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new() { 4, 5, 6, 7, 8 };
            // HashSet<int> copy = A;
            // HashSet<int> sub = new() { 1, 2 };
            // //copy.UnionWith(B);
            // //copy.IntersectWith(B);
            // //copy.ExceptWith(B);
            // //foreach (var item in copy)
            // //{
            // //    Console.WriteLine(item);
            // //}
            // Console.WriteLine(sub.IsSubsetOf(A));



            #endregion


            #region Exercise 5: Print Queue Simulator

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Report.pdf");
            //queue.Enqueue("Invoice.pdf");
            //queue.Enqueue("Letter.docx");
            //queue.Enqueue("Resume.pdf");
            //queue.Enqueue("Photo.jpg");

            //Console.WriteLine(queue.Count);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine($"printing: [{queue.Dequeue()}]");
            //Console.WriteLine($"printing: [{queue.Dequeue()}]");
            //Console.WriteLine($"printing: [{queue.Dequeue()}]");
            //Console.WriteLine($"printing: [{queue.Dequeue()}]");
            //Console.WriteLine($"printing: [{queue.Dequeue()}]");

            //bool chek = queue.TryDequeue(out string file);
            //Console.WriteLine(chek);
            // return false because Queue is empty


            #endregion


            #region Exercise 6: Browser History (Undo)

            //Stack<string> stack = new Stack<string>();
            //stack.Push("google.com");
            //stack.Push("github.com");
            //stack.Push("stackoverflow.com");
            //stack.Push("youtube.com");
            //stack.Push("claude.ai");

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //bool check = stack.TryPop(out string website);
            //Console.WriteLine(check);
            //// return false because stack is empty

            #endregion




        }
    }
}
