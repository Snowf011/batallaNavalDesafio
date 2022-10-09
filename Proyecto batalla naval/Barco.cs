using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_batalla_naval
{
    public class Barco
    {
        private int coordeanadaInicialFila;
        private int coordenadaInicialColumna;
        private bool hundido= false;
        private int tamanho;

        private string caracter="-";
        private int coordenadaFinalColumna;
        private (int fila, int columna)[] coordenadas = new (int fila, int columna)[0];
        private string[] listaDeCaracteres;
        public String Caracter
        {
            get { return caracter; }
            set { caracter = value; }
        }
        public int CoordenadaIncialFila
        {
            get { return coordeanadaInicialFila; }
            set { coordeanadaInicialFila = value; }
        }
        public int CoordenadaInicialColumna
        {
            get { return coordenadaInicialColumna; }
            set { coordenadaInicialColumna = value; }
        }
        public int CoordenadaFinalFila { get; set; }
        public (int fila, int columna)[] Coordenadas { get; set; }
        public int CoordenadaFinalColumna
        {
            get { return coordenadaFinalColumna; } 
            set {coordenadaFinalColumna= value; } 
        }

        public bool Hundido
        { get { return hundido; } set { hundido = value; } }
        public int Tamanho
        { get { return tamanho; } set { tamanho = value; } }

        public void crearBarco(string tipoDeBarco, (int, string)[] listaDeCoordenadas)
        {
            if (tipoDeBarco == "porta aviones")
            {
                tamanho = 5;
                coordenadas = new (int fila, int columna)[tamanho];
                caracter = "P";
            }
            if (tipoDeBarco == "acorazado")
            {
                tamanho = 4;
                coordenadas = new (int fila, int columna)[tamanho];
                caracter = "A";
            }
            if (tipoDeBarco == "crucero")
            {
                tamanho = 3;
                coordenadas = new (int fila, int columna)[tamanho];
                caracter = "C";
            }
            if (tipoDeBarco == "submarino")
            {
                tamanho = 3;
                coordenadas = new (int fila, int columna)[tamanho];
                caracter = "S";
            }
            if (tipoDeBarco == "destructor")
            {
                tamanho = 2;
                coordenadas = new (int fila, int columna)[tamanho];
                caracter = "D";
            }
            for(int i = 0; i < tamanho; i++)
            {
                coordenadas[i].Item1 = (listaDeCoordenadas[i].Item1)+2;
                coordenadas[i].Item2 = transformarLetraANumero(listaDeCoordenadas[i].Item2)+2;
            }
            listaDeCaracteres = new string[tamanho];
            for(int i=0; i<tamanho;i++)
            {
                listaDeCaracteres[i]=caracter;
            }
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
        public void mostrarCoordenadas()
        {
            for(int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(coordenadas[i].Item1 +" "+coordenadas[i].Item2);
            }
        }
         public (bool, string) esPosicionDeUnBarco(int x, int y)
        {
            int posicionXDelBarco;
            int posicionYDelBarco;
            (bool, string) respuesta = (false, " ");
            for(int i = 0; i<tamanho; i++)
            {
                posicionXDelBarco = this.coordenadas[i].Item1;
                posicionYDelBarco = this.coordenadas[i].Item2;
                if (x == posicionXDelBarco &&  y == posicionYDelBarco)
                {
                    respuesta = (true, this.listaDeCaracteres[i]);
                    return respuesta;
                }
            }    
            return respuesta;
        }

        public void marcarDanho(int i)
        {
            listaDeCaracteres[i]="X";
        }
    }
}
