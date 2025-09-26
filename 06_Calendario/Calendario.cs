using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Calendario
{
    internal class Calendario
    {
        private int ano;
        private int mes;
        private DateTime primeiroDiaMes;
        private int[,] calendario;

        public Calendario(int ano, int mes)
        {
            this.ano = ano;
            this.mes = mes;
            primeiroDiaMes = new DateTime(ano, mes,1);
            calendario = new int[6, 7];
            gerarCalendario();
        }

        private void gerarCalendario()
        {
            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            //primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            //calendario = new int[6, 7];
            int dia = 1;

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
        }

        public void ImprimirCalendario()
        {
            Console.WriteLine($"\nCalendário de " +
                                $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");
                        
            int[] diasFeriados = RetornaFeriados();
            //impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nFeriados: ");
            for (int i = 0; i < diasFeriados.Length; i++)
            {
                if (diasFeriados[i] > 0)
                {
                    Console.Write($"{diasFeriados[i].ToString("D2")}\t");
                }
            }
        }

        private int[] RetornaFeriados()
        {
            int[] feriados = new int[15];

            int indice = 0;
                       
            if (mes == 1) feriados[indice++] = 1;
            else if (mes == 4)
            {
                feriados[indice++] = 4;
                feriados[indice++] = 21;
            }
            else if (mes == 5) feriados[indice++] = 1;
            else if (mes == 7) feriados[indice++] = 9;
            else if (mes == 9) feriados[indice++] = 7;
            else if (mes == 10) feriados[indice++] = 12;
            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }
            else if (mes == 12)
            {
                feriados[indice++] = 8;
                feriados[indice++] = 25;
            }
            DateTime domingoDePascoa = DomingoDePascoa();

            DateTime carnaval = domingoDePascoa.AddDays(-47);
            DateTime sextaFeiraSanta = domingoDePascoa.AddDays(-2);
            DateTime CorpuChrist = domingoDePascoa.AddDays(60);

            if (domingoDePascoa.Month == mes)
                feriados[indice++] = domingoDePascoa.Day;

            if (carnaval.Month == mes)
                feriados[indice++] = carnaval.Day;

            if (sextaFeiraSanta.Month == mes)
                feriados[indice++] = sextaFeiraSanta.Day;

            if (CorpuChrist.Month == mes)
                feriados[indice++] = CorpuChrist.Day;

            Array.Sort(feriados);

            return feriados;
        }

        private DateTime DomingoDePascoa()
        {
            DateTime domingoDePascoa;
            int X = 0, Y = 0, a, b, c, d, g, dia, mes;

            if (ano <= 1699)
            {
                X = 22;
                Y = 2;
            }
            else if (ano <= 1799)
            {
                X = 23;
                Y = 3;
            }
            else if (ano <= 1899)
            {
                X = 24;
                Y = 4;
            }
            else if (ano <= 2099)
            {
                X = 24;
                Y = 5;
            }
            else if (ano <= 2199)
            {
                X = 24;
                Y = 6;
            }
            else if (ano <= 2299)
            {
                X = 24;
                Y = 7;
            }

            a = ano % 19;
            b = ano % 4;
            c = ano % 7;
            d = (19 * a + X) % 30;
            g = (2 * b + 4 * c + 6 * d + Y) % 7;

            if ((d + g) > 9)
            {
                dia = (d + g - 9);
                mes = 4;
            }
            else
            {
                dia = (d + g + 22);
                mes = 3;
            }

            domingoDePascoa = new DateTime(ano, mes, dia);

            return domingoDePascoa;
        }
    }
}
