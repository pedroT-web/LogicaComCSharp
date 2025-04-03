using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_2_centimetros_por_ano
{
    internal class Program
    {
        static void Main(string[] args)
            //Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m
            //e cresce 3 centímetros por ano.Faça um algoritmo que calcule e imprima na tela em quantos anos serão necessários para que Francisco seja maior que Sara.
        {
            double alturaFrancisco = 1.50, alturaSara = 1.10, anos = 0, CrescimentoPorAnoF = 0.02, CrescimentoPorAnoS = 0.03, i=0 , calculoDiferenca;

            while (alturaFrancisco >= alturaSara)
            {
                alturaFrancisco += CrescimentoPorAnoF; // Francisco cresce
                alturaSara += CrescimentoPorAnoS;           // Sara cresce
                anos++;                                   // Incrementa anos
            }
                Console.WriteLine("Serão necessários " + anos + " Anos para sara ultrapassar francisco");
        }
            
        }
    }

