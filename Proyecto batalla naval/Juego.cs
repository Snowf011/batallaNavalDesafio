using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_batalla_naval
{
    public class Juego
    {
        //acceso tipoDeVaraible nombreDeVariable = IniciailizacionDeLaVariable
        private Jugador jugador1 = new Jugador();
        private Jugador jugador2 = new Jugador();
        public Jugador Jugador1 { get { return jugador1; } }
        public Jugador Jugador2 { get { return jugador2; } }
        public Tablero tablero1 = new Tablero();
        public Tablero tablero2 = new Tablero();
        public void turnoInicial(Jugador jugador)
        {
            Console.WriteLine("Introduzca un texto");
            String nombreJugador;
            nombreJugador = Console.ReadLine();
            Console.WriteLine("El texto introducido es: " + nombreJugador);
            jugador.Nombre = nombreJugador;
        }

        public void ingresarBarco(string tipoDeBarco,int tamanhoDelBarco,Barco barco)
        {
            Console.WriteLine("Inserte posicion inicial X "+ tipoDeBarco+" de tamaño "+tamanhoDelBarco);
            string coordenadaLetras;
            int coordenadaInicialFila;
            coordenadaLetras = Console.ReadLine();
            coordenadaInicialFila = transformarLetraANumero(coordenadaLetras);
            Console.WriteLine("Inserte posicion inicial Y "+ tipoDeBarco+" de tamaño "+ tamanhoDelBarco);
            string coordenadaInicialColumna;
            coordenadaInicialColumna = Console.ReadLine();
            int coordenadasNumericasColumna = Int32.Parse(coordenadaInicialColumna);
            barco.CoordenadaIncialFila = coordenadaInicialFila;
            barco.CoordenadaInicialColumna = coordenadasNumericasColumna;

            Console.WriteLine("Inserte posicion final X " + tipoDeBarco + " de tamaño " + tamanhoDelBarco);
            string coordenadaLetrasFinal;
            int coordenadaFinalFila;
            coordenadaLetras = Console.ReadLine();
            coordenadaFinalFila = transformarLetraANumero(coordenadaLetras);
            Console.WriteLine("Inserte posicion final Y " + tipoDeBarco + " de tamaño " + tamanhoDelBarco);
            string coordenadaFinalColumna;
            coordenadaFinalColumna = Console.ReadLine();
            int coordenadasNumericasColumnaFinal = Int32.Parse(coordenadaFinalColumna);
            barco.CoordenadaFinalFila = coordenadaFinalFila;
            barco.CoordenadaFinalColumna = coordenadasNumericasColumnaFinal;
            barco.Tamanho = tamanhoDelBarco;
            barco.Hundido = false;
        }
        
        public int transformarLetraANumero(string letra)
        {
            switch (letra)
            {
                case "A":
                    return 0;
                case "B":
                    return 1;
                case "C":
                    return 2;
                case "D":
                    return 3;
                case "E":
                    return 4;
                case "F":
                    return 5;
                case "G":
                    return 6;
                case "H":
                    return 7;
                case "I":
                    return 8;
                case "J":
                    return 9;    
                default:
                    return -1;
            }

        }

        //public void jugar()
        //{
        //    while(jugador1.Puntaje <17 || jugador2.Puntaje < 17)
        //    {
        //        Console.Clear();
        //        jugador1.jugarTurno(tablero2);
        //        Console.Clear();
        //        jugador2.jugarTurno(tablero1);
        //    }
        //}

        public (int, int) pedirCoordenadas()
        {
            string datosIngresados;
            string[] coordenadas;
            string coordenadaXString;
            string coordenadaYString;
            int coordenadaX;
            int coordenadaY;
            Console.WriteLine("Ingrese las coordenadas del disparo Ej: A,1 ");
            datosIngresados = Console.ReadLine();
            coordenadas= datosIngresados.Split(",");
            coordenadaXString = coordenadas[0];
            coordenadaYString = coordenadas[0];
            coordenadaX = Int32.Parse(coordenadaXString);
            coordenadaY = Int32.Parse(coordenadaYString);
            return (coordenadaX,coordenadaY);
        }

        // public bool tiroAcertado(Jugador jugador, (int x, int y) coordenadasDelDisparo)
        // {
        //     int disparoX = coordenadasDelDisparo.x;
        //     int disparoY = coordenadasDelDisparo.y;
        //     if(jugador.Tablero.esPosicionDeUnBarco(disparoX, disparoY))
        //     {
        //         return true;
        //     }
        //     return false;
        // }
    }
}
