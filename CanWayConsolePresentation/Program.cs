// See https://aka.ms/new-console-template for more information
using ConwayBusinessLogic;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, World!");
Console.WriteLine("Kérem az oszlopok számát!");
var columnsSting = Console.ReadLine();
Console.WriteLine("Kérem az sorok számát!");
var rowsSting = Console.ReadLine();
Console.WriteLine("Kérem az elemek/sejtek számát!");
var cellsSting = Console.ReadLine();

var columns = 0;
var rows = 0;
var cells = 0;
if (Int32.TryParse(columnsSting, out columns)
    && Int32.TryParse(rowsSting, out rows)
    && Int32.TryParse(cellsSting, out cells))
{
    var playArea = new PlayArea(columns,rows,cells);
    var shouldContinue = true;
    while (shouldContinue)
    {
        playArea.Randomize();
        playArea.Draw();
        var keyinfo = Console.ReadKey();
        if (keyinfo.KeyChar=='x')
        {
            shouldContinue = false;
        }
    }
}
else
{
    Console.WriteLine("Nem megfelelő értékek");
}