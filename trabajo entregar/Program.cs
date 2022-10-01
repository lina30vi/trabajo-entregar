namespace trabajoEntregar
{
    public class program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;
            Console.WriteLine("por favor ingrese un año");
            anyo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("por favor ingrese un mes");
            mes = Convert.ToInt32(Console.ReadLine());


            if (mes > 12)
            {
                while (mes > 12)
                {
                    Console.WriteLine(("el numero sobrepasa la cantidad posible de un mes por favor ingrese un dato correcto"));
                    mes = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("por favor ingrese un dia ");
            dia = Convert.ToInt32(Console.ReadLine());

            double bisiesto = anyo % 4;
            Convert.ToDouble(dia);
            Convert.ToDouble(mes);


            if (bisiesto == 0 && mes == 2 && dia > 29)
            {
                while (dia > 29)
                {
                    Console.WriteLine(("el numero sobrepasa la cantidad de dias posibles, por favor colocar valores validos"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (bisiesto != 0 && mes == 2 && dia > 28)
            {
                while (dia > 28)
                {
                    Console.WriteLine(("el numero sobrepasa la cantidad de dias del mes,por favor ingrese un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (mes == 4 
                || mes == 6 || 
                mes == 9 || mes == 11 && dia > 30)
            {
                while (dia > 30)
                {
                    Console.WriteLine(("el numero sobrepasa la cantidad de dias del mes, por favor ingrese un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (mes == 1 && mes == 3 || 
                mes == 5 || mes == 7 && mes == 
                8 || mes == 10 || mes ==
                12 && dia > 31)
            {
                while (dia > 31)
                {
                    Console.WriteLine(("el numero sobrepasa la cantidad de dias del mes, por favor ingrese un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }


            DateTime miFecha = new DateTime(anyo, mes, dia);
            miFecha = miFecha.AddDays(1);
            Console.WriteLine("el resultado final es");

            Console.WriteLine(miFecha);


        }
    }
}
