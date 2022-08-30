using static System.Console;
using QuizOOP;

Console.WriteLine("===============LIST TRANSPORT===============");
ITransport transIntf = new TransportImpl();
var listTrans = transIntf.InitDataTransport();
transIntf.ShowDataTransport(ref listTrans);
Console.WriteLine();

Console.WriteLine("===============TOTAL TRANSPORT BY TYPE===============");
var transByType = transIntf.GetTransportByType(listTrans);
transIntf.ShowTransportByRole(transByType);
Console.WriteLine();

Console.WriteLine("===============TOTAL REVENUE BY TYPE===============");
var revenueByType = transIntf.GetRevenueTransportByType(listTrans);
transIntf.ShowRevenueTransportByRole(revenueByType);
Console.WriteLine();

Console.WriteLine("===============FIND REVENUE BY RANGE===============");
var find = transIntf.FindRevenueByRange(listTrans, 500_000, 600_000);
transIntf.ShowDataTransport(ref find);
Console.WriteLine();
