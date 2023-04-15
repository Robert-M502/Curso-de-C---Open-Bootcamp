using System;
using System.Diagnostics;
using System.Threading;

// Sin multithreading
/*
Stopwatch crono = new Stopwatch();
crono.Start();

// Tarea 1
Thread.Sleep(1000); // Esta tarea dura un segundo
// Tarea 2
Thread.Sleep(1000); // Esta tarea dura un segundo
// Tarea 3
Thread.Sleep(1000); // Esta tarea dura un segundo

crono.Stop();
Console.WriteLine($"Este programa ha tardado: {crono.Elapsed} segundos");

// Main Thread o Hilo Principal

// Assinganr nombre del Mian Thread
Thread hiloPrincipal = Thread.CurrentThread;
hiloPrincipal.Name = "Hilo Principal";
Console.WriteLine($"Estamos en el hilo {hiloPrincipal.Name}");
*/

Stopwatch crono = Stopwatch.StartNew();

// Task 1
var task1 = new Task(() => {
    var crono = Stopwatch.StartNew();
    Thread.Sleep(2000); // para este hilo 1 segund
    crono.Stop();
    Console.WriteLine($"1. El hilo ha tardado: {crono.Elapsed} segundos");
});

// Task 2
var task2 = new Task(() => {
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000); // para este hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"2. El hilo ha tardado: {crono.Elapsed} segundos");
});

// Task 3
var task3 = new Task(() => {
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000); // para este hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"3. El hilo ha tardado: {crono.Elapsed} segundos");
});


// Iniciamos los tasks o tareas
task1.Start();
task2.Start();
task3.Start();

// Recibir las tareas
/*
// Recibir las tareas de forma individual
await task1;
await task2;
await task3;
*/
// recibr todas las tareas de forma colectiva
Task.WaitAll(task1, task2, task3); // Recibimos todos las tareas iniciadas cuando se completan
crono.Stop();
Console.WriteLine($"Todo el programa ha durado: {crono.Elapsed}");

/* Iniciamos hilo
// Pasamos referencia con TreadStart -> refHilo: = método que ejecutamos al iniciar nuevo hilo
Stopwatch crono2 = new Stopwatch();
crono2.Start();
ThreadStart refHilo = new ThreadStart(IniciarHilos);
Thread hiloSecundario = new Thread(refHilo);
hiloSecundario.Start();
Thread.Sleep(1000);
crono2.Stop();
Console.WriteLine($"El hilo 2 ha tardado: {crono2.Elapsed} segundos");

// Task 
Stopwatch crono3 = new Stopwatch();
crono3.Start();
Thread hilo3= new Thread(refHilo);
hilo3.Start();
Thread.Sleep(1000);
crono3.Stop();
Console.WriteLine($"El hilo 3 ha tardado: {crono3.Elapsed} segundos");
*/

// Recolectamos la task completados

// Finalizamos el programa


/*
// Descomentar toda la sección para usar el método del principio
static void IniciarHilos() {
    Console.WriteLine($"Iniciando hilo nuevo...");
    Console.WriteLine($"Finalizando tareas");
}
*/
