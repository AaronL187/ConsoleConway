// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Kérem az oszlopok számát!");
var columnsSting = Console.ReadLine();
Console.WriteLine("Kérem az sorok számát!");
var rowsSting = Console.ReadLine();
Console.WriteLine("Kérem az elemek/sejtek számát!");
var cellsSting = Console.ReadLine();


try
{
    var columns = Convert.ToInt32(columnsSting);
    var rows = Convert.ToInt32(rowsSting);
    var cells = Convert.ToInt32(cellsSting);
}
catch (Exception ex)
{
    Console.WriteLine("Nem megfelelő értékek!");
	return;
}
