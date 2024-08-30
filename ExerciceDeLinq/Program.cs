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
            //Console.WriteLine();
            //Console.WriteLine("Exo 2.1");
            //Console.WriteLine("-------");
            //var QueryResult2_1 = dc.Students.Select((s) => new
            //{
            //    s.Last_Name,
            //    s.BirthDate,
            //    s.Login,
            //    s.Year_Result
            //});

            //foreach (var s in QueryResult2_1)
            //{
            //    Console.WriteLine($"{s.Last_Name} - {s.BirthDate} - {s.Login} - {s.Year_Result}");
            //}
            #endregion

            #region Exo 2.2
            //Console.WriteLine();
            //Console.WriteLine("Exo 2.2");
            //Console.WriteLine("-------");
            //var QueryResult2_2 = dc.Students.Select((s) => new
            //{
            //    NomComplet = $"{s.Last_Name} {s.First_Name}",
            //    s.Student_ID,
            //    s.BirthDate
            //});


            //foreach (var s in QueryResult2_2)
            //{
            //    Console.WriteLine($"{s.NomComplet} - {s.Student_ID} - {s.BirthDate}");
            //}
            #endregion

            #region Exo 2.3
            //Console.WriteLine();
            //Console.WriteLine("Exo 2.3");
            //Console.WriteLine("-------");
            //IEnumerable<string> QueryResult2_3 = dc.Students.Select((s) => $"{s.Student_ID}" +
            //                                                            $" | " +
            //                                                            $"{s.First_Name}" +
            //                                                            $" | " +
            //                                                            $"{s.Last_Name}" +
            //                                                            $" | " +
            //                                                            $"{s.BirthDate}" +
            //                                                            $" | " +
            //                                                            $"{s.Login}" +
            //                                                            $" | " +
            //                                                            $"{s.Section_ID}" +
            //                                                            $" | " +
            //                                                            $"{s.Year_Result}" +
            //                                                            $" | " +
            //                                                            $"{s.Course_ID}");
            //foreach (string s in QueryResult2_3) {
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Exo 3.1
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.1");
            //Console.WriteLine("-------");
            //var QueryResult3_1 = dc.Students.Where((s) => s.BirthDate.Year < 1955)
            //    .Select((s) => new
            //    {
            //        s.Last_Name,
            //        s.Year_Result,
            //        Statut = (s.Year_Result >= 12) ? "OK" : "KO"
            //    }); ;

            //foreach (var s in QueryResult3_1)
            //{
            //    Console.WriteLine($"{s.Last_Name} - {s.Year_Result} - {s.Statut}");
            //}
            #endregion

            #region Exo 3.2
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.2");
            //Console.WriteLine("-------");
            //var QueryResult3_2 = dc.Students.Where((s) => (s.BirthDate.Year >= 1955) && (s.BirthDate.Year <= 1965))
            //    .Select((s) => new
            //    {
            //        s.Last_Name,
            //        s.Year_Result,
            //        Categorie = (s.Year_Result < 10) ? "inférieur" :
            //                    (s.Year_Result == 10) ? "neutre" :
            //                    "supérieur"
            //    });

            //foreach (var s in QueryResult3_2) {
            //    Console.WriteLine($"{s.Last_Name} - {s.Year_Result} - {s.Categorie}");
            //}
            #endregion

            #region Exo 3.3
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.3");
            //Console.WriteLine("-------");
            //var QueryResult3_3 = dc.Students.Where((s) => s.Last_Name.Substring(s.Last_Name.Length - 1, 1) == "r")
            //    .Select((s) => new { s.Last_Name, s.Section_ID });

            //foreach (var s in QueryResult3_3)
            //{
            //    Console.WriteLine($"{s.Last_Name} - {s.Section_ID}");
            //}
            #endregion

            #region Exo 3.4
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.4");
            //Console.WriteLine("-------");
            //var QueryResult3_4 = dc.Students.Where((s) => s.Year_Result <= 3)
            //    .Select((s) => new { s.Last_Name, s.Year_Result })
            //    .OrderByDescending((s) => s.Year_Result);

            //foreach (var s in QueryResult3_4)
            //{
            //    Console.WriteLine($"{s.Last_Name} - {s.Year_Result}");
            //}
            #endregion

            #region Exo 3.5
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.5");
            //Console.WriteLine("-------");
            //var QueryResult3_5 = dc.Students.Where((s)=> s.Section_ID == 1110)
            //    .Select((s) => new
            //    {
            //        FullName = $"{s.Last_Name} {s.First_Name}",
            //        s.Year_Result
            //    });

            //foreach (var s in QueryResult3_5)
            //{
            //    Console.WriteLine($"{s.FullName} - {s.Year_Result}");
            //}
            #endregion

            #region Exo 3.6
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.6");
            //Console.WriteLine("-------");
            //var QueryResult3_6 = dc.Students.Where((s) => s.Section_ID == 1010 || s.Section_ID == 1020)
            //    .Where((s) => s.Year_Result < 12 || s.Year_Result > 18)
            //    .Select((s) => new { s.Last_Name, s.Section_ID, s.Year_Result })
            //    .OrderBy((s) => s.Section_ID);

            //foreach (var s in QueryResult3_6)
            //{
            //    Console.WriteLine($"{s.Last_Name} - {s.Section_ID} - {s.Year_Result}");
            //}
            #endregion

            #region Exo 3.7
            //Console.WriteLine();
            //Console.WriteLine("Exo 3.7");
            //Console.WriteLine("-------");
            //var QueryResult3_7 = dc.Students.Where((s) => s.Section_ID.ToString().Substring(0, 2) == "13")
            //    .Where((s) => (s.Year_Result * 5) <= 60)
            //    .Select((s) => new
            //    {
            //        s.Last_Name,
            //        s.Section_ID,
            //        result_100 = s.Year_Result * 5
            //    });

            //foreach (var s in QueryResult3_7)
            //{
            //    Console.WriteLine($"{s.Last_Name} - {s.Section_ID} - {s.result_100}");
            //}
            #endregion

            #region Exo 4.1
            //Console.WriteLine();
            //Console.WriteLine("Exo 4.1");
            //Console.WriteLine("-------");
            //double ResultatMoyen = dc.Students.Average((s) => s.Year_Result);
            //Console.WriteLine($"Le résultat annuel moyen est : {ResultatMoyen}");
            #endregion

            #region Exo 4.2
            //Console.WriteLine();
            //Console.WriteLine("Exo 4.2");
            //Console.WriteLine("-------");
            //int MeilleurResultat = dc.Students.Max((s) => s.Year_Result);
            //Console.WriteLine($"Le plus haut résultat annuel est : {MeilleurResultat}");
            #endregion

            #region Exo 4.3
            //Console.WriteLine();
            //Console.WriteLine("Exo 4.3");
            //Console.WriteLine("-------");
            //int SommeResultats = dc.Students.Sum((s) => s.Year_Result);
            //Console.WriteLine($"La somme des résultats annuels est : {SommeResultats}");
            #endregion

            #region Exo 4.4
            //Console.WriteLine();
            //Console.WriteLine("Exo 4.4");
            //Console.WriteLine("-------");
            //int ResultatLePlusFaible = dc.Students.Min((s) => s.Year_Result);
            //Console.WriteLine($"Le résultat annuel le plus faible est : {ResultatLePlusFaible}");
            #endregion

            #region Exo 4.5
            //Console.WriteLine();
            //Console.WriteLine("Exo 4.5");
            //Console.WriteLine("-------");
            //int ResultatsImpair = dc.Students.Count((s) => s.Year_Result % 2 == 1);
            //Console.WriteLine($"Le nombre d'étudiants ayant obtenu un résultat annuel impair est : {ResultatsImpair}");
            #endregion

            #region Exo 5.1
            Console.WriteLine();
            Console.WriteLine("Exo 5.1");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.2
            Console.WriteLine();
            Console.WriteLine("Exo 5.2");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.3
            Console.WriteLine();
            Console.WriteLine("Exo 5.3");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.4
            Console.WriteLine();
            Console.WriteLine("Exo 5.4");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.5
            Console.WriteLine();
            Console.WriteLine("Exo 5.5");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.6
            Console.WriteLine();
            Console.WriteLine("Exo 5.6");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.7
            Console.WriteLine();
            Console.WriteLine("Exo 5.7");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.8
            Console.WriteLine();
            Console.WriteLine("Exo 5.8");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.9
            Console.WriteLine();
            Console.WriteLine("Exo 5.9");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.10
            Console.WriteLine();
            Console.WriteLine("Exo 5.10");
            Console.WriteLine("-------");
            #endregion

            #region Exo 5.11
            Console.WriteLine();
            Console.WriteLine("Exo 5.11");
            Console.WriteLine("-------");
            #endregion

            #endregion

            #region Console.ReadKey(true)
            Console.ReadKey(true);
            #endregion
        }
    }
}