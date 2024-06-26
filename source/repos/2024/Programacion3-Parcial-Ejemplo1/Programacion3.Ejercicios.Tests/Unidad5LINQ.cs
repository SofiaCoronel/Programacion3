﻿using Programacion3.Ejercicios.Entidades;
using Programacion3.Ejercicios.Entidades.Interfaces;
using System.Linq;

namespace Programacion3.Ejercicios.Tests
{
    /// <summary>
    /// Unidad 5
    /// 
    /// </summary>
    public class Unidad5LINQ
    {
        [Fact]
        public void unidad5_test1_numerospares_utilizacion_any()
        {
            var numeros = new List<int> { 1, 3, 5, 7, 9 };

            //Utilizar el metodo Any de LINQ para determinar si la lista contiene algún número par
            bool contieneNumerosPares = 

            Assert.False(contieneNumerosPares); 

        }


        [Fact]
        public void unidad5_test2_numerosmaximo_utilizacion_max()
        {
             var numeros = new List<int> { 1, 3, 5, 7, 9, 37 };

            //Utilizar el metodo Max de LINQ
             int maximoNumero =

             Assert.Equal(37, maximoNumero);

        }


        [Fact]
        public void unidad5_test3_contarpalabrasquecomiencenconletraa_utilizacion_startWith()
        {
            var palabras = new List<string> { "Manzana", "Banana", "Pera", "Anana" };

            var cantidadPalabrasComienzanConA = 

             Assert.Equal(1, cantidadPalabrasComienzanConA); 

        }


        [Fact]
        public void unidad5_test4_obtenernumerosimpares_filtro_y_obtener_lista()
        {
             var numeros = new List<int> { 1, 2, 3, 4, 5 };

             //Se desea obtener una lista con los números impares utilizando LINQ
             var numerosImpares = 


             Assert.Equal(new List<int> { 1, 3, 5 }, numerosImpares); 

        }


        [Fact]
        public void unidad5_test5_preguntasitodaslaspalabrasterminancona_utilizacion_all()
        {
             var palabras = new List<string> { "Manzana", "Banana", "Pera", "Anana" };

            //Utilizar el metodo All de LINQ para determinar si todas las palabras terminan con la letra "a"
             var todasTerminanConA =

              Assert.True(todasTerminanConA);

        }


        [Fact]
        public void unidad5_test6_sumarl()
        {
              var numeros = new List<int> { 1, 2, 3, 4, 5 };

               //utilizar LINQ para sumar todos los números de la lista
              var suma = 

              Assert.Equal(15, suma); 
        }


        [Fact]
        public void unidad5_test7_obtenerlapalabramaslarga()
        {
             var palabras = new List<string> { "Kiwi", "Manzana", "Banana", "Pera", "Anana" };

             //Utilizar LINQ para obtener la palabra más larga
             ////(NOTA: string tiene una propiedad Length para comparar, TIP. Se puede ordenar descendentemente)
             var palabraMasLarga =

             Assert.Equal("Manzana", palabraMasLarga);

        }


        [Fact]
        public void unidad5_test8_ordenarlistaalfabeticamente()
        {

            var letras = new List<string> { "z", "a", "d", "c" };

            //Utilizar LINQ para ordenar la lista alfabéticamente

            //var letrasOrdenadas = letras.OrderBy(x => x).ToList();

            var letrasOrdenadas = from l in letras
                                  orderby l
                                  select l;


            Assert.Equal(new List<string> { "a", "c", "d", "z" }, letrasOrdenadas);
        }


        [Fact]
        public void unidad5_test9_ordenarlistaalfabeticamente()
        {

             var letras = new List<string> { "z", "a", "d", "c" };

             //Utilizar LINQ para ordenar la lista alfabéticamente
             var letrasOrdenadas =


             Assert.Equal(new List<string> { "a", "c", "d", "z" }, letrasOrdenadas);
        }



        [Fact]
        public void unidad5_test8_equipos()
        {
            var equipos = GenerarEquipos();


            //Obtener los nombres de equipos con el jugador con el nombre "J 1"
            var equiposConJ1 = from e in equipos
                               where e.Jugadores.Any(x => x.Nombre.Equals("J 1", StringComparison.OrdinalIgnoreCase))
                               select e.Nombre;


            Assert.Equal(new List<string> { "Equipo 1" }, equiposConJ1);
        }


        [Fact]
        public void unidad5_test9_golestotales()
        {
            var equipos = GenerarEquipos();


            //Obtener la cantidad de goles totales realizados

            //Version 1
            var demo1 = equipos.Sum(x => x.Jugadores.Sum(j => j.Goles));


            //Version 2
            var golesTotales = (from e in equipos
                                select e.Jugadores.Sum(x => x.Goles)).Sum();


            //Version 3
            var demo2_parte1 = from e in equipos
                               select e.Jugadores.Sum(x => x.Goles);

            var demo2_parte2 = demo2_parte1.Sum();



            Assert.Equal(5, demo1);
            Assert.Equal(5, golesTotales);
        }


        private List<Equipo> GenerarEquipos()
        {


            var equipos = new List<Equipo> {
                        new Equipo() { Nombre = "Equipo 1", Ranking = 3 },
                        new Equipo() { Nombre = "Equipo 2",  Ranking = 1},
                        new Equipo() { Nombre = "Equipo 3",  Ranking = 2},
            };

            var jugadoresEquipo1 = new List<Jugador> {
                        new Jugador("J 1", "A 1"){
                            Goles  = 3
                        },
                        new Jugador("J 2", "A 2"){
                            Goles = 2
                        }
            };

            var jugadoresEquipo2 = new List<Jugador> {
                        new Jugador("J 1 E2", "A 1 E2"){
                            Goles  = 4
                        },
                        new Jugador("J 2 E2", "A 2 E2"){
                            Goles = 0
                        }
            };

            var jugadoresEquipo3 = new List<Jugador> {
                        new Jugador("J 1 E3", "A 1 E3"){
                            Goles  = 4
                        },
                        new Jugador("J 2 E3", "A 2 E3"){
                            Goles = 0
                        },
                        new Jugador("J 3 E3", "A 3 E3"){
                            Goles = 8
                        },
                        new Jugador("Juan de los Palotes", "A 3 E3"){
                            Goles = 1
                        }
            };

            //equipos[0].Jugadores = jugadoresEquipo1;
            equipos[0].Jugadores.AddRange(jugadoresEquipo1);
            equipos[1].Jugadores.AddRange(jugadoresEquipo2);
            equipos[2].Jugadores.AddRange(jugadoresEquipo3);

            return equipos;
        }


        //10: Cuantos jugadores tiene el equipo que esta segundo en el ranking >> 2 jugadores
        //11: Cual es el Ranking del equipo con mas jugadores >> 2do ranking
        //12: Cual es el promedio de goles de jugadores que parte del nombre sea "J 1"

        //13: Cual de los equipos posee el nombre de jugador mas largo
    }
}