
using Proyecto_batalla_naval;
using System;


Jugador jugador1=new Jugador();
Jugador jugador2 = new Jugador();
Barco[] barcosDejugador1=new Barco[5];
jugador1.Nombre="jugador 1";


Juego juego1=new Juego();
Barco portaAviones = new Barco();
Barco acorazado = new Barco();
Barco crucero = new Barco();
Barco submarino = new Barco();
Barco destructor = new Barco();
Tablero tablero1=new Tablero();
Tablero tablero2 = new Tablero();


(int fila, string columna)[] coordenadasPortaAviones= new (int, string)[5];
coordenadasPortaAviones[0]=(2,"B");
coordenadasPortaAviones[1]=(2,"C");
coordenadasPortaAviones[2]=(2,"D");
coordenadasPortaAviones[3]=(2,"E");
coordenadasPortaAviones[4]=(2,"F");

(int fila, string columna)[] coordenadasAcorazado=new (int, string)[4];
coordenadasAcorazado[0]=(2,"H");
coordenadasAcorazado[1]=(3,"H");
coordenadasAcorazado[2]=(4,"H");
coordenadasAcorazado[3]=(5,"H");

(int fila, string columna)[] coordenadasCrucero=new (int, string)[3];
coordenadasCrucero[0]=(5,"B");
coordenadasCrucero[1]=(5,"C");
coordenadasCrucero[2]=(5,"D");

(int fila, string columna)[] coordenadasSubmarino=new (int, string)[3];
coordenadasSubmarino[0]=(7,"A");
coordenadasSubmarino[1]=(8,"A");
coordenadasSubmarino[2]=(9,"A");

(int fila, string columna)[] coordenadasDestructor=new (int, string)[2];
coordenadasDestructor[0]=(7,"F");
coordenadasDestructor[1]=(7,"G");


portaAviones.crearBarco("porta aviones",coordenadasPortaAviones);
acorazado.crearBarco("acorazado",coordenadasAcorazado);
crucero.crearBarco("crucero",coordenadasCrucero);
submarino.crearBarco("submarino",coordenadasSubmarino);
destructor.crearBarco("destructor",coordenadasDestructor);
barcosDejugador1[0]=portaAviones;
barcosDejugador1[1]=acorazado;
barcosDejugador1[2]=crucero;
barcosDejugador1[3]=submarino;
barcosDejugador1[4]=destructor;

destructor.marcarDanho(1);
tablero1.Barcos = barcosDejugador1;
tablero1.llenarTablero();
tablero1.MostrarTablero();

tablero2.Barcos = barcosDejugador1;
tablero2.llenarTablero();
tablero2.MostrarTablero();

