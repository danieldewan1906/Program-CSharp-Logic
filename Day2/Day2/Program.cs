using static System.Console;
using Day2;

//ArraysCase.IntroArray();

//call method input array
/*int[] n = { 10, 20, 40, 50 };
var myArray = ArraysCase.InitArrayInt(n);

ArraysCase.DisplayArrayInt(myArray);

ArraysCase.InitArrayRandom(20);*/

/*var randArray = ArraysCase.InitArrayRandom(5);

ArraysCase.DisplayArrayInt(randArray);
WriteLine();
WriteLine($"Sum : {ArraysCase.SumAllElement(randArray)}");
WriteLine($"Max : {ArraysCase.FindLargestElement(randArray)}");

//copy array (cara 1)
int[] newArray = new int[randArray.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = randArray[i];
}
WriteLine();
Array.Sort(newArray);
ArraysCase.DisplayArrayInt(newArray);

//cara 2
var newArrayRandom = new int[randArray.Length];
Array.Copy(newArray, 0, newArrayRandom, 0, newArray.Length);
WriteLine();
Array.Reverse(newArrayRandom);
ArraysCase.DisplayArrayInt(newArrayRandom);*/

/*
 * latihan
 */

//declare
/*var nilai = new int[] { 15, 2, 30, 12, 10, 5 };
var randomIndex = QuizLogic.RandomArrayNo1(nilai);
Console.WriteLine("Number : ");
QuizLogic.DisplayArray(randomIndex);
Console.WriteLine();*/

//no 1
/*var random = QuizLogic.RandomIndexNo1(nilai);
Console.WriteLine("After Random : ");
QuizLogic.DisplayArray(random);*/

//no2
/*var geser = QuizLogic.ShiftingElementNo2(nilai);
Console.WriteLine("After Shifting :");
QuizLogic.DisplayArray(geser);*/

//no 3
//var leftShift = QuizLogic.LeftShiftingElementNo3(nilai);

//no 4
//var rightShift = QuizLogic.RightShiftingElementNo4(nilai);

//no5
/*var nilai = new int[] { 1, 5, 3, 7, 8, 5, 1 };
QuizLogic.CountNumberNo5(nilai);*/

//no6
/*var nilai = new int[] { 1, 5, 3, 7, 8, 5, 1 };
var randomIndex = QuizLogic.RandomArrayNo1(nilai);
Console.WriteLine("Number : ");
QuizLogic.DisplayArray(randomIndex);
Console.WriteLine();

Console.WriteLine("After Marker : ");
QuizLogic.ShiftingDuplicateNumberNo6(nilai);
Console.WriteLine();*/

// no 7
/*var number = new int[] { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
var nilai = QuizLogic.RandomArrayNo1(number);
Console.WriteLine("Number : ");
QuizLogic.DisplayArray(nilai);
Console.WriteLine();
var removeDuplicate = QuizLogic.RemoveDuplicateNo7(number);
Console.WriteLine("After Delete Duplicate : ");
for (int i = 0; i < removeDuplicate; i++)
{
    Console.Write($"{number[i]} ");
}*/

// no 8
/*var element = QuizLogic.SumDuplicateElementNo8(100);
QuizLogic.DisplayChar(element);*/

// no 9
/*var myMatrix = Matrix.MatrixDiagonalNo9(5, 5);
Matrix.DisplayMatrix(myMatrix);*/

// no 10
//var sum = Matrix.SumMatrixDiagonalNo10(5, 5);

// no 11
/*var empty = QuizLogic.EmptyMidMatrixNo11(7, 7);
QuizLogic.DisplayMatrix(empty);*/

// no 12
/*var sumMatriks = QuizLogic.SumMatriksNo12(8, 8);
QuizLogic.DisplayMatrix(sumMatriks);*/

// no 15
/*char[,] scors = new char[,] {
                              {'A', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'D', 'B', 'A', 'B', 'C', 'A', 'E', 'E', 'A', 'D'},
                              {'E', 'D', 'D', 'A', 'C', 'B', 'E', 'E', 'A', 'D'},
                              {'C', 'B', 'A', 'E', 'D', 'C', 'E', 'E', 'A', 'D'},
                              {'A', 'B', 'D', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'B', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'B', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'E', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                            };
char[] key = new char[] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
var temp = Matrix.ScorsStudentNo15(scors, key);*/

Console.ReadLine();