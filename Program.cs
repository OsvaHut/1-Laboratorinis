//--------------------------------------------------------------------
// Užduotis:
// * Sukurkite klasę Medis, kuri turėtų kintamuosius amžiui ir
// aukščiui saugoti. Sode auga trys skirtingos liepos.
// Raskite, koks aukščiausios liepos aukštis ir koks seniausios
// liepos amžius.
// * Papildykite klasę Medis kintamuoju, skirtu medžio lajos
// skersmeniui saugoti. Sukurkite klasę Sodas, kuris turėtų
// kintamuosius parko ilgiui ir pločiui saugoti. Kiek sode gali augti
// kiekvieno amžiaus skirtingo dydžio liepų?
// * Papildykite klasę Sodas metodu Dėti(), kuris leistų keisti sodo
// dydį. Ar sodo plotą padidinus dvigubai jame tilps tiek didžiausios
// lajos liepų, kiek mažesniame sode tilpo mažiausios lajos liepų?
//--------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Klasė medžio duomenims saugoti
/// </summary>
class Medis
{
    private double amžius,        // Medžio amžius
                   aukštis,       // Medžio aukštis (metrais)
                   lajosSkersmuo; // Medžio lajos skersmuo (metrais)

    /// <summary>
    /// Sukuria naują medį ir suteikia jam išmatavimus
    /// </summary>
    /// <param name="amžiausReikšmė">Medžio amžiaus reikšmė</param>
    /// <param name="aukščioReikšmė">Medžio aukščio reikšmė</param>
    /// <param name="lajosSkersmensReikšmė">Medžio lajos skermens 
    /// reikšmė</param>
    public Medis(double amžiausReikšmė, double aukščioReikšmė,
                 double lajosSkersmensReikšmė)
    {
        amžius = amžiausReikšmė;
        aukštis = aukščioReikšmė;
        lajosSkersmuo = lajosSkersmensReikšmė;
    }

    /// <summary>
    /// Paimamas medžio amžius
    /// </summary>
    /// <returns></returns>
    public double ImtiAmžių() { return amžius; }

    /// <summary>
    /// Paimamas medžio aukštis
    /// </summary>
    /// <returns></returns>
    public double ImtiAukštį() { return aukštis; }

    /// <summary>
    /// Paimamas medžio lajos skersmuo
    /// </summary>
    /// <returns></returns>
    public double ImtiSkersmenį() { return lajosSkersmuo; }
}

/// <summary>
/// Klasė sodo duomenims saugoti
/// </summary>
class Sodas
{
    private double ilgis,    // Sodo ilgis (metrais)
                   plotis;   // Sodo plotis (metrais)
    /// <summary>
    /// Sukuria naują sodą ir suteikia jam išmatavimus
    /// </summary>
    /// <param name="ilgioReikšmė">Sodo ilgio reikšmė</param>
    /// <param name="pločioReikšmė">Sodo pločio reikšmė</param>
    public Sodas(double ilgioReikšmė, double pločioReikšmė)
    {
        ilgis = ilgioReikšmė;
        plotis = pločioReikšmė;
    }

    /// <summary>
    /// Paimamas sodo ilgis
    /// </summary>
    /// <returns></returns>
    public double ImtiIlgį() { return ilgis; }

    /// <summary>
    /// Paimamas sodo plotis
    /// </summary>
    /// <returns></returns>
    public double ImtiPlotį() { return plotis; }

    /// <summary>
    /// Pakeičia objekto ilgį ir plotį
    /// </summary>
    /// <param name="naujasIlgis">Naujas objekto ilgis</param>
    /// <param name="naujasPlotis">Naujas objekto plotis</param>
    public void Dėti(double naujasIlgis, double naujasPlotis)
    {
        ilgis = naujasIlgis;
        plotis = naujasPlotis; 
    }
}

namespace _1_Laboratorinis
{
    /// <summary>
    /// Programos pagrindinė klasė
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*double liepa1Aukštis = 0,
                   liepa1Amžius = 0,
                   liepa1Skersmuo = 0,
                   liepa2Aukštis = 0,
                   liepa2Amžius = 0,
                   liepa2Skersmuo = 0,
                   liepa3Aukštis = 0,
                   liepa3Amžius = 0,
                   liepa3Skersmuo = 0,
                   sodasIlgis = 0,
                   sodasPlotis = 0;

            Medis Liepa1 = NaujaLiepaTestavimui(liepa1Aukštis,
                                                liepa1Amžius,
                                                liepa1Skersmuo);

            Medis Liepa2 = NaujaLiepaTestavimui(liepa2Aukštis,
                                                liepa2Amžius,
                                                liepa2Skersmuo);

            Medis Liepa3 = NaujaLiepaTestavimui(liepa3Aukštis,
                                                liepa3Amžius,
                                                liepa3Skersmuo);*/

           Medis Liepa1 = NaujaLiepa(1);
           Medis Liepa2 = NaujaLiepa(2);
           Medis Liepa3 = NaujaLiepa(3);


            Sodas Parkas1 = NaujasSodas(1);

            /*Sodas Parkas1 = NaujasSodasTestavimui(sodasIlgis,
                                                  sodasPlotis);*/

            double maxMedžių1 = MaxMedžių(SodoPlotas(Parkas1),
                            LajosPlotas(LajosSpindulys
                            (Liepa1.ImtiSkersmenį())));

            double maxMedžių2 = MaxMedžių(SodoPlotas(Parkas1),
                            LajosPlotas(LajosSpindulys
                            (Liepa2.ImtiSkersmenį())));

            double maxMedžių3 = MaxMedžių(SodoPlotas(Parkas1),
                             LajosPlotas(LajosSpindulys
                             (Liepa3.ImtiSkersmenį())));

            LiepųLentelė(Liepa1, Liepa2, Liepa3, Parkas1);
            SodoLentelė(Parkas1);
            MaxAukščioLentelė(Liepa1, Liepa2, Liepa3);
            MaxAmžiausLentelė(Liepa1, Liepa2, Liepa3);

            Console.WriteLine("Įveskite naują sodo ilgį");
            double naujasIlgis = double.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite naują sodo plotį");
            double naujasPlotis = double.Parse(Console.ReadLine());

            Parkas1.Dėti(naujasIlgis, naujasPlotis);

            SodoLentelė(Parkas1);
            LiepųLentelė(Liepa1, Liepa2, Liepa3, Parkas1);
            

            Console.Read();

        }

        /// <summary>
        /// Sukuria naują medį ir suteikia jam numerį
        /// </summary>
        /// <param name="numeris">Medžio numeris</param>
        /// <returns></returns>
        static Medis NaujaLiepa(double numeris)
        {
            double amžius,
                   aukštis,
                   lajosSkersmuo;

            Console.WriteLine("Įveskite {0} liepos amžių: ", numeris);
            amžius = double.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite {0} liepos aukštį (metrais): "
                              , numeris);

            aukštis = double.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite {0} liepos lajos skersmenį " +
                "(metrais): ",numeris);

            lajosSkersmuo = double.Parse(Console.ReadLine());

            Medis Liepa;
            Liepa = new Medis(amžius, aukštis, lajosSkersmuo);

            return Liepa;


        }

        static Medis NaujaLiepaTestavimui(double aukštis, 
                                          double amžius,
                                          double skersmuo)
        {

            Medis Liepa;
            Liepa = new Medis(amžius, aukštis, skersmuo);

            return Liepa;


        }

        /// <summary>
        /// Sukuria nauja sodą ir suteikia jam numerį
        /// </summary>
        /// <param name="numeris">Sodo numeris</param>
        /// <returns></returns>
        static Sodas NaujasSodas(double numeris)
        {
            double ilgis,
                   plotis;

            Console.WriteLine("Įveskite {0} sodo ilgį (metrais): ", 
                               numeris);
            ilgis = double.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite {0} sodo plotį (metrais): ", 
                               numeris);
            plotis = double.Parse(Console.ReadLine());

            Sodas Parkas;
            Parkas = new Sodas(ilgis, plotis);

            return Parkas;
        }

        static Sodas NaujasSodasTestavimui(double ilgis, 
                                           double plotis)
        {

            Sodas Parkas;
            Parkas = new Sodas(ilgis, plotis);

            return Parkas;
        }


        /// <summary>
        /// Ieškoma aukščiausia liepa
        /// </summary>
        /// <param name="Liepa1">Pirmos liepos duomenys</param>
        /// <param name="Liepa2">Antros liepos duomenys</param>
        /// <param name="Liepa3">Trečios liepos duomenys</param>
        /// <returns></returns>
        static double AukščiausiaLiepa(Medis Liepa1,
                                    Medis Liepa2,
                                    Medis Liepa3)
        {
            double maxAukštis = 0;

            if (Liepa1.ImtiAukštį() >= Liepa2.ImtiAukštį() &&
                Liepa1.ImtiAukštį() >= Liepa3.ImtiAukštį())
            {
                maxAukštis = Liepa1.ImtiAukštį();
            }
            if (Liepa2.ImtiAukštį() >= Liepa1.ImtiAukštį() &&
                Liepa2.ImtiAukštį() >= Liepa3.ImtiAukštį())
            {
                maxAukštis = Liepa2.ImtiAukštį();
            }
            if(Liepa3.ImtiAukštį() >= Liepa1.ImtiAukštį() &&
                Liepa3.ImtiAukštį() >= Liepa2.ImtiAukštį())
            {
                maxAukštis = Liepa3.ImtiAukštį();
            }
            
            return maxAukštis;

        }

        /// <summary>
        /// Ieškoma seniausia liepa
        /// </summary>
        /// <param name="Liepa1">Pirmos liepos duomenys</param>
        /// <param name="Liepa2">Antros liepos duomenys</param>
        /// <param name="Liepa3">Trečios liepos duomenys</param>
        /// <returns></returns>
        static double SeniausiaLiepa(Medis Liepa1,
                                  Medis Liepa2,
                                  Medis Liepa3)
        {
            double maxAmžius = 0;

            if (Liepa1.ImtiAmžių() >= Liepa2.ImtiAmžių() &&
                Liepa1.ImtiAmžių() >= Liepa3.ImtiAmžių())
            {
                maxAmžius = Liepa1.ImtiAmžių();
            }
            if (Liepa2.ImtiAmžių() >= Liepa1.ImtiAmžių() &&
                Liepa2.ImtiAmžių() >= Liepa3.ImtiAmžių())
                {
                    maxAmžius = Liepa2.ImtiAmžių();
                }
            if (Liepa3.ImtiAmžių() >= Liepa1.ImtiAmžių() &&
                Liepa3.ImtiAmžių() >= Liepa2.ImtiAmžių())

                {
                    maxAmžius = Liepa3.ImtiAmžių();
                }
            
            return maxAmžius;
        }

        /// <summary>
        /// Apskaičiuoja koks yra didžiausias liepos lajos skersmuo
        /// </summary>
        /// <param name="Liepa1">Pirmos liepos duomenys</param>
        /// <param name="Liepa2">Antros liepos duomenys</param>
        /// <param name="Liepa3">Trečios liepos duomenys</param>
        /// <returns></returns>
        static double MaxLajosSkermuo(Medis Liepa1,
                                   Medis Liepa2,
                                   Medis Liepa3)
        {
            double maxSkersmuo;

            if (Liepa1.ImtiSkersmenį() > Liepa2.ImtiSkersmenį() &&
                Liepa1.ImtiSkersmenį() > Liepa3.ImtiSkersmenį())
            {
                maxSkersmuo = Liepa1.ImtiSkersmenį();
            }
            else
            {
                if (Liepa2.ImtiSkersmenį() > Liepa1.ImtiSkersmenį() &&
                    Liepa2.ImtiSkersmenį() > Liepa3.ImtiSkersmenį())
                {
                    maxSkersmuo = Liepa2.ImtiSkersmenį();
                }
                else
                {
                    maxSkersmuo = Liepa3.ImtiSkersmenį();
                }
            }
            return maxSkersmuo;
        }

        /// <summary>
        /// Apskaičiuoja sodo plotą
        /// </summary>
        /// <param name="Parkas">Parko duomenys</param>
        /// <returns></returns>
        static double SodoPlotas(Sodas Parkas)
        {
            double sodoPlotas;

            sodoPlotas = Parkas.ImtiIlgį() * Parkas.ImtiPlotį();

            return sodoPlotas;
        }

        /// <summary>
        /// Apskaičiuoja lajos spindulį
        /// </summary>
        /// <param name="MaxLajosSkersmuo">Didžiausios lajos 
        /// skersmuo</param>
        /// <returns></returns>
        static double LajosSpindulys(double MaxLajosSkersmuo)
        {
            double lajosSpindulys;

            lajosSpindulys = MaxLajosSkersmuo / 2;

            return lajosSpindulys;
        }

        /// <summary>
        /// Apskaičiuoja lajos plotą
        /// </summary>
        /// <param name="lajosSpindulys">lajos spindulys</param>
        /// <returns></returns>
        static double LajosPlotas(double lajosSpindulys)
        {
            double lajosPlotas;

            lajosPlotas = Math.PI * Math.Pow(lajosSpindulys, 2);

            return lajosPlotas;
        }

        /// <summary>
        /// Apskaičiuoja kiek daugiausiai medžių telpa sode
        /// </summary>
        /// <param name="sodoPlotas">Sodo plotas</param>
        /// <param name="lajosPlotas">Lajos skersmens plotas</param>
        /// <returns></returns>
        static double MaxMedžių(double sodoPlotas, double lajosPlotas)
        {
            double maxMedžių;

            maxMedžių = (int)(sodoPlotas / lajosPlotas);

            return maxMedžių;
        }

        /// <summary>
        /// Atspausdina liepų duomenų lentelę
        /// </summary>
        /// <param name="Liepa1">Pirmos liepos duomenys</param>
        /// <param name="Liepa2">Antros liepos duomenys</param>
        /// <param name="Liepa3">Trečios liepos duomenys</param>
        /// <param name="Parkas">Parko duomenys</param>
        static void LiepųLentelė(Medis Liepa1, Medis Liepa2, 
                                 Medis Liepa3, Sodas Parkas)
        {
            Console.WriteLine();
            Console.WriteLine("Liepos:");

            for (int i = 0; i < 57; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8} |{2, 7} |{3, 15} |{4,11}", 
                "Objektas", "Aukštis", "Amžius", "Lajos skersmuo", 
                "Sode telpa");
                for (int i = 0; i < 57; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                
            Console.WriteLine
                ("{0, 9} |{1, 8} |{2, 7} |{3, 15} |{4,11}", "Liepa1", 
                Liepa1.ImtiAukštį(), Liepa1.ImtiAmžių(), 
                Liepa1.ImtiSkersmenį(), MaxMedžių(SodoPlotas(Parkas), 
                LajosPlotas(LajosSpindulys(Liepa1.ImtiSkersmenį()))));

            for (int i = 0; i < 57; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8} |{2, 7} |{3, 15} |{4,11}", "Liepa2", 
                Liepa2.ImtiAukštį(), Liepa2.ImtiAmžių(), 
                Liepa2.ImtiSkersmenį(), MaxMedžių(SodoPlotas(Parkas), 
                LajosPlotas(LajosSpindulys(Liepa2.ImtiSkersmenį()))));

            for (int i = 0; i < 57; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8} |{2, 7} |{3, 15} |{4,11}", "Liepa3", 
                Liepa3.ImtiAukštį(), Liepa3.ImtiAmžių(), 
                Liepa3.ImtiSkersmenį(), MaxMedžių(SodoPlotas(Parkas), 
                LajosPlotas(LajosSpindulys(Liepa3.ImtiSkersmenį()))));

            for (int i = 0; i < 57; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }

        /// <summary>
        /// Atspausdina sodo duomenų lentelę
        /// </summary>
        /// <param name="Parkas">Parko duomenys</param>
        static void SodoLentelė(Sodas Parkas)
        {
            Console.WriteLine();
            Console.WriteLine("Sodas:");
            for (int i = 0; i < 27; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8} |{2, 7}",
                "Objektas", "Ilgis", "Plotis");

            for (int i = 0; i < 27; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8} |{2, 7}", 
                "Parkas", Parkas.ImtiIlgį(), Parkas.ImtiPlotį());

            for (int i = 0; i < 27; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }

        /// <summary>
        /// Atspausdina didžiausios arba didžiausių liepų lentelę
        /// </summary>
        /// <param name="Liepa1">Pirmos liepos duomenys</param>
        /// <param name="Liepa2">Antros liepos duomenys</param>
        /// <param name="Liepa3">Trečios liepos duomenys</param>
        static void MaxAukščioLentelė(Medis Liepa1, Medis Liepa2, 
            Medis Liepa3)
        {
            Console.WriteLine();
            Console.WriteLine("Aukščiausia/-os liepa/-os:");

            for (int i = 0; i < 18; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8}",
                "Objektas", "Aukštis");

            double aukštisMax = AukščiausiaLiepa(Liepa1, Liepa2,
                                                 Liepa3);

            bool liepa1Max = false;
            bool liepa2Max = false;
            bool liepa3Max = false;

            if(Liepa1.ImtiAukštį() == aukštisMax)
            {
                liepa1Max = true;
            }

            if(Liepa2.ImtiAukštį() == aukštisMax)
            {
                liepa2Max = true;
            }

            if (Liepa3.ImtiAukštį() == aukštisMax)
            {
                liepa3Max = true;
            }

            if (liepa1Max)
            {
                for (int i = 0; i < 18; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.WriteLine
                    ("{0, 9} |{1, 8}",
                    "Liepa1", aukštisMax);
            }

            if (liepa2Max)
            {
                for (int i = 0; i < 18; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.WriteLine
                    ("{0, 9} |{1, 8}",
                    "Liepa2", aukštisMax);
            }

            if (liepa3Max)
            {
                for (int i = 0; i < 18; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.WriteLine
                    ("{0, 9} |{1, 8}",
                    "Liepa3", aukštisMax);
            }

        }

        /// <summary>
        /// Atspausdina seniausios arba seniausių liepų lentelę
        /// </summary>
        /// <param name="Liepa1">Pirmos liepos duomenys</param>
        /// <param name="Liepa2">Antros liepos duomenys</param>
        /// <param name="Liepa3">Trečios liepos duomenys</param>
        static void MaxAmžiausLentelė(Medis Liepa1, Medis Liepa2,
           Medis Liepa3)
        {
            Console.WriteLine();
            Console.WriteLine("Seniausia/-os liepa/-os:");

            for (int i = 0; i < 18; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.WriteLine
                ("{0, 9} |{1, 8}",
                "Objektas", "Amžius");

            double amžiusMax = SeniausiaLiepa(Liepa1, Liepa2,
                                              Liepa3);

            bool liepa1Max = false;
            bool liepa2Max = false;
            bool liepa3Max = false;

            if (Liepa1.ImtiAmžių() == amžiusMax)
            {
                liepa1Max = true;
            }

            if (Liepa2.ImtiAmžių() == amžiusMax)
            {
                liepa2Max = true;
            }

            if (Liepa3.ImtiAmžių() == amžiusMax)
            {
                liepa3Max = true;
            }

            if (liepa1Max)
            {
                for (int i = 0; i < 18; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.WriteLine
                    ("{0, 9} |{1, 8}",
                    "Liepa1", amžiusMax);
            }

            if (liepa2Max)
            {
                for (int i = 0; i < 18; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.WriteLine
                    ("{0, 9} |{1, 8}",
                    "Liepa2", amžiusMax);
            }

            if (liepa3Max)
            {
                for (int i = 0; i < 18; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.WriteLine
                    ("{0, 9} |{1, 8}",
                    "Liepa3", amžiusMax);
            }

        }



    }
}



