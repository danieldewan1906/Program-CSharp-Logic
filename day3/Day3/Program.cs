using static System.Console;
using Day3;

//MyCollections.InitList();
//MyCollections.InitStack();
//MyCollections.InitDictionary();
//MyCollections.InitHashSet();
//MyCollections.InitQueue();

/*
 * Declare Method List
 */

/*var list = new List<string>() {"Asep", "Budi", "Charlie" };
var students = MyCollections.GetStudent(ref list);

foreach (var item in students)
{
    Console.WriteLine($"{item}");
}*/

/*
 * LATIHAN
 */

// no 1
/*var list = new List<int>() {1, 2, 5, 6, 9};
var list2 = new List<int>() { 1, 2, 3, 4 };
QuizLogicDay3.Nomor1(ref list, ref list2);*/

// no 2
/*var list = new List<string>() { "A", "BB", "CCC", "DDDD" };
QuizLogicDay3.Reverse(ref list);*/

// no36
/*var list = new List<int>() {1, 1, 2, 3, 4, 1, 2, 3};
QuizLogicDay3.RemoveDuplicate(ref list);*/

// no 5
var list = new List<string>() { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun"};
var list2 = new List<string>() { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };
var different = QuizLogicDay3.ListSameDifferent(ref list, ref list2);
QuizLogicDay3.ShowList(different);



// no 7
/*var list = new List<int>() { 1, 2, 5, 6, 9 };
var list2 = new List<int>() { 1, 2, 3, 4 };
QuizLogicDay3.ListAddition(ref list, ref list2);*/