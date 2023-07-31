using System;

namespace netx
{
    public enum LifeStage 
    {
        Prenatal,
        Infant,
	    Toddler,
	    EarlyChild,
	    MiddleChild,
	    Adolescent,
	    EarlyAdult,
	    MiddleAdult,
	    LateAdult
    }

    public class RelationalPattern
    {
        public RelationalPattern()
        {

        }

        public void ClassicMethod(int edad) 
        {
            switch (edad)
            {
                case > 0 and <= 3:
                    Console.WriteLine("Infante");
                    break;
                case >= 4 and <= 12:
                    Console.WriteLine("Niño");
                    break;
                case >= 13 and <= 17:
                    Console.WriteLine("Puberto");
                    break;
                case >= 18 and <= 30:
                    Console.WriteLine("Joven");
                    break;
                case >= 30 and <= 65:
                    Console.WriteLine("Adulto");
                    break;
                case > 65:
                    Console.WriteLine("Tercera Edad");
                    break;
            }

            Console.ReadLine();
        }

        public void NewMethod(int edad)
        {
            LifeStage ls = NewProperty(edad);            

            switch (Convert.ToInt32(ls))
            {
                case 0:
                    Console.WriteLine("Prenatal");
                    break;
                case 1:
                    Console.WriteLine("Infante");
                    break;
                case 2:
                    Console.WriteLine("Niño pequeño");
                    break;
                case 3:
                    Console.WriteLine("Niño medio");
                    break;
                case 4:
                    Console.WriteLine("Puberto");
                    break;
                case 5:
                    Console.WriteLine("Adolescente");
                    break;
                case 6:
                    Console.WriteLine("Joven Adulto");
                    break;
                case 7:
                    Console.WriteLine("Adulto promedio");
                    break;
                case 8:
                    Console.WriteLine("Adulto mayor");
                    break;
            }

            Console.ReadLine();
        }

        public static LifeStage NewProperty(int age)
        {
            return age switch
            {
                < 0 => LifeStage.Prenatal,
                < 2 => LifeStage.Infant,
                < 4 => LifeStage.Toddler,
                < 6 => LifeStage.EarlyChild,
                < 12 => LifeStage.MiddleChild,
                < 20 => LifeStage.Adolescent,
                < 40 => LifeStage.EarlyAdult,
                < 65 => LifeStage.MiddleAdult,
                _ => LifeStage.LateAdult
            };
        }
    }
}
