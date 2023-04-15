using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
// Progrmación asíncrona - Hilos que trabajan en paralelo
Stopwatch sw = Stopwatch.StartNew();

// Task 1 
var task1 = new Task(() => {
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Tast 1: {crono.Elapsed}");
});


var task2 = new Task(() => {
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 2: {crono.Elapsed}");
});

var task3 = new Task(() => {
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Tast 3: {crono.Elapsed}");
});

var task4 = new Task(async () =>
{
    var str = await RandomAsync(); // En un caso real async Task puede tardar mili/segundos
    Console.WriteLine(str);
});


task1.Start();
task2.Start();
task3.Start();
task4.Start();

await task1;
await task2;
await task3;
await task1;


sw.Stop();
Console.WriteLine($"Todo Main: {sw.Elapsed}");

// End Main
static async Task<string> RandomAsync(){
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    Thread.Sleep(1000);
    sw.Stop();
    var str = $"Task desde una funcion: {num.ToString()} calculado en: {sw.Elapsed}";
    return str;    
}