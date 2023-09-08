using System;
using System.IO;
using System.Text;
using System.Threading;
using Library;


namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ruta del archivo que contiene el patrón inicial
            string archivoPath = @"c:\Users\gusta\Desktop\AñoActual\ConwaysGameofLife\docs\board.txt"; // Reemplaza con la ruta correcta

            // Crea una instancia de la clase Archivo para cargar el patrón inicial
            Archivo archivo = new Archivo(archivoPath);

            // Crea una instancia de la clase Board usando el patrón inicial
            Board tablero = new Board(archivo);

            // Crea una instancia de la clase BoardPrinter para imprimir el tablero
            BoardPrinter printer = new BoardPrinter(tablero);

            // Inicia la impresión del tablero en un bucle infinito
        
            while(true)
            {
                printer.PrintBoard(); 
                tablero.UpdateBoard();    
                Thread.Sleep(300);                  
            }
            
        }
    }
}