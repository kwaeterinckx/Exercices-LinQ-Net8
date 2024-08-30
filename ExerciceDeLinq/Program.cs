using LINQDataContext;

namespace ExerciceDeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext();

            #region Faites vos exos ici

            #region Exo 2.1
            Console.WriteLine();
            Console.WriteLine("Exo 2.1");
            Console.WriteLine("-------");
            var QueryResult2_1 = dc.Students.Select((s) => new
            {
                s.Last_Name,
                s.BirthDate,
                s.Login,
                s.Year_Result
            });

            foreach (var s in QueryResult2_1)
            {
                Console.WriteLine($"{s.Last_Name} - {s.BirthDate} - {s.Login} - {s.Year_Result}");
            }
            #endregion

            #region Exo 2.2
            Console.WriteLine();
            Console.WriteLine("Exo 2.2");
            Console.WriteLine("-------");
            var QueryResult2_2 = dc.Students.Select((s) => new
            {
                NomComplet = $"{s.Last_Name} {s.First_Name}",
                s.Student_ID,
                s.BirthDate
            });


            foreach (var s in QueryResult2_2)
            {
                Console.WriteLine($"{s.NomComplet} - {s.Student_ID} - {s.BirthDate}");
            }
            #endregion

            #region Exo 2.3
            Console.WriteLine();
            Console.WriteLine("Exo 2.3");
            Console.WriteLine("-------");
            IEnumerable<string> QueryResult2_3 = dc.Students.Select((s) => $"{s.Student_ID}" +
                                                                        $" | " +
                                                                        $"{s.First_Name}" +
                                                                        $" | " +
                                                                        $"{s.Last_Name}" +
                                                                        $" | " +
                                                                        $"{s.BirthDate}" +
                                                                        $" | " +
                                                                        $"{s.Login}" +
                                                                        $" | " +
                                                                        $"{s.Section_ID}" +
                                                                        $" | " +
                                                                        $"{s.Year_Result}" +
                                                                        $" | " +
                                                                        $"{s.Course_ID}");
            foreach (string s in QueryResult2_3) {
                Console.WriteLine(s);
            }
            #endregion

            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}