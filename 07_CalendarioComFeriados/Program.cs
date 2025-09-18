using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CalendarioComFeriados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            for (int mes = 1; mes <= 12; mes++)
            {
                int diasDoMes = DateTime.DaysInMonth(ano, mes);

                DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
                int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

                int[,] calendario = new int[6, 7];

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

                Console.WriteLine($"\nCalendário de " +
                    $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

                Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

                Feriado[] diasFeriados = RetornaFeriados(mes, ano);
                //bool ehFeriado;

                for (int semana = 0; semana < 6; semana++)
                {
                    for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                    {
                        if (calendario[semana, diaSemana] != 0)
                        {
                           /* ehFeriado = false;

                            for(int posicaoFeriados = 0; posicaoFeriados < diasFeriados.Length; posicaoFeriados++)
                            {
                                if (diasFeriados[posicaoFeriados] != null && diasFeriados[posicaoFeriados].Dia == calendario[semana, diaSemana])
                                {
                                    ehFeriado = true;
                                    break;
                                }
                            }*/

                            //if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                            if (diasFeriados.Any( feriado => feriado.Dia == calendario[semana, diaSemana]) || diaSemana == 0)
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
                /*for (int i = 0; i < diasFeriados.Length; i++)
                {
                    if (diasFeriados[i] > 0)
                    {
                        Console.Write($"{diasFeriados[i].ToString("D2")}\t");
                    }
                }*/

                foreach (Feriado diaFeriado in diasFeriados)
                {
                    if(diaFeriado != null)
                        Console.Write($"{diaFeriado.Dia:D2}{diaFeriado.Descricao}\t");
                }

                Console.ReadKey();
            }

        }

        public static Feriado[] RetornaFeriados(int mes, int ano)
        {
            Feriado[] feriados = new Feriado[15];

            int indice = 0;
            if (mes == 1) feriados[indice++] = new Feriado(1,"Confraternização Universal");
            else if (mes == 4)
            {
                feriados[indice++] = new Feriado(4, "Aniversário de Cidade");
                feriados[indice++] = new Feriado(21, "Tiradentes");
            }
            else if (mes == 5) feriados[indice++] = new Feriado(1, "Dia do Trabalhador");
            else if (mes == 7) feriados[indice++] = new Feriado(9, "Revolução Constitucionalista de SP");
            else if (mes == 9) feriados[indice++] = new Feriado(7, "Independência do Brasil");
            else if (mes == 10) feriados[indice++] = new Feriado(12, "Nossa Senhora Aparecida");
            else if (mes == 11)
            {
                feriados[indice++] = new Feriado(2, "Finados");
                feriados[indice++] = new Feriado(15, "Proclamação da República");
                feriados[indice++] = new Feriado(20, "Consciência Negra");
            }
            else if (mes == 12)
            {
                feriados[indice++] = new Feriado(8, "Padroeira da Cidade");
                feriados[indice++] = new Feriado(25, "Natal");
            }
            DateTime domingoDePascoa = DomingoDePascoa(ano);

            DateTime carnaval = domingoDePascoa.AddDays(-47);
            DateTime sextaFeiraSanta = domingoDePascoa.AddDays(-2);
            DateTime CorpuChrist = domingoDePascoa.AddDays(60);

            if (domingoDePascoa.Month == mes)
                feriados[indice++] = new Feriado(domingoDePascoa.Day, "Páscoa");

            if (carnaval.Month == mes)
                feriados[indice++] = new Feriado(carnaval.Day, "Carnaval");

            if (sextaFeiraSanta.Month == mes)
                feriados[indice++] = new Feriado(sextaFeiraSanta.Day, "Sexta-Feira Santa");

            if (CorpuChrist.Month == mes)
                feriados[indice++] = new Feriado(CorpuChrist.Day, "Corpus Christ");

            Array.Sort(feriados);

            return feriados;
        }

        public static DateTime DomingoDePascoa(int ano)
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
