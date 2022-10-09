using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_batalla_naval
{
    public class Jugador
    {
        private string nombre = "";
        private int puntaje = 0;
        private int[,] tablero = new int[12, 12];
        private Barco portaAviones = new Barco();
        private Barco acorazado = new Barco();
        private Barco crucero = new Barco();
        private Barco submarino = new Barco();
        private Barco destructor = new Barco();

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {

                nombre = value;

            }
        }
        public int Puntaje
        {
            get
            {
                return puntaje;
            }
            set
            {

                puntaje = value;

            }

        }
        public int [,] Tablero
        {
            get
            {
                return tablero;
            }
            set
            {

                tablero = value;

            }
        }
        public Barco PortaAviones
        {
            get { return portaAviones; }
            set { portaAviones = value; }
        }
        public Barco Crucero
        { 
            get { return crucero; } 
            set { crucero = value; }
        }
        public Barco Acorazado
        {
            get { return acorazado; }
            set { acorazado = value; }
        }
        public Barco Submarino
        {
            get { return submarino; }
            set { submarino = value; }
        }
        public Barco Destructor
        {
            get { return destructor; }
            set
            {
                destructor = value;
            }
        }
        public void imprimirNombre()
        {
            Console.WriteLine(nombre);
        }

        //public void jugarTurno(Tablero tablero)
        //{
        //    Console.WriteLine("Inserte posicion X del disparo ");
        //    string coordenadaX;
        //    coordenadaX = Console.ReadLine();
        //    Console.WriteLine("Inserte posicionY del disparo ");
        //    string coordenadaY;
        //    coordenadaY = Console.ReadLine();
        //    int coordenadaXNumerica = Int32.Parse(coordenadaX);
        //    int coordenadaYNumerica = Int32.Parse(coordenadaY);
        //    if (tablero.verificarPosicion(coordenadaXNumerica, coordenadaYNumerica))
        //    {
        //        this.puntaje++;
        //    }
        //}
    }
}
