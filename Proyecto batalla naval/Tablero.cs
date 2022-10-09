using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_batalla_naval
{
    public class Tablero
    {
        private String[,] mesa = new String[12, 12];
        private Barco[] barcos = new Barco[5];

        

        public string [,] Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }
        public Barco[] Barcos
        { 
            get { return barcos; } 
            set { barcos = value; }
        }
        
        public void llenarTablero()
        {
            String agua = "-";
            for (int i = 0; i <12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    bool respuesta = esPosicionDeUnBarco(i,j).Item1;
                    string caracter = esPosicionDeUnBarco(i,j).Item2;
                    if (respuesta)
                    {
                        this.mesa[i, j] = caracter;
                    }
                    else
                    {
                        this.mesa[i, j] = agua;
                    }
                }
            }
            
        }
        public void MostrarTablero()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if( this.mesa[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.Write(this.mesa[i, j]);
                        Console.ForegroundColor = ConsoleColor.White; 
                    }
                    else
                    {
                        Console.Write(this.mesa[i, j]);
                    }  
                }
                Console.WriteLine();
            }
        }

        public (bool, string) esPosicionDeUnBarco(int x, int y)
        {
            (bool, string) respuesta = (false, " ");
            for (int i=0; i<this.barcos.Length; i++)
            {
                respuesta = barcos[i].esPosicionDeUnBarco(x, y);
                if(respuesta.Item1)
                {
                    return respuesta;
                }   
            }
            return respuesta;
        }
        
    }
}
