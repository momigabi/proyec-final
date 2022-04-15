using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class montohambur 
    {

    private string nombre;
    private string apellido;
    private int cedula;
    private long telefo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Cedula { get => cedula; set => cedula = value; }
    public long Telefo { get => telefo; set => telefo = value; }

   

         public void calcuhambur()

         { 
        
             double iva =0.16;
             int total = 0;
             int lin = 0;
             double totaiva = 0;
        //____________________________________
              int CANB, CANH, CANP;
              int PRECIOB = 2;
              int PRECIOH = 2;
              int PRECIOP = 1;
     

             lin = Convert.ToInt32(Console.ReadLine());

               if (lin == 1)
               {
            Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
            CANH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS :");
            CANP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOH * CANH + PRECIOP * CANP;
       
            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
               }
               else if (lin == 2)
               {

            Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
            CANH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS :");
            CANP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOH * CANH + PRECIOP * CANP;          

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();


               }
               else if (lin == 3)
               {
            Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
            CANH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS :");
            CANP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOH * CANH + PRECIOP * CANP;          

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();

               }
              else if (lin == 4)
              {

            Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
            CANH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS :");
            CANP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOH * CANH + PRECIOP * CANP;         

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();

              }
             else
             {

            Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
            CANH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS :");
            CANP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOH * CANH + PRECIOP * CANP;

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();

             }


         }

        public void cliente()
    {    string nom="";
        string ape = "";
        int cedu = 0;
        long tele = 0;

        Nombre = nom;
        Apellido = ape;
        Cedula= cedu;
        Telefo= tele;

        Console.WriteLine("Datos del cliente");
        Console.Write("Nombre :"); nom = Console.ReadLine();
        Console.Write("Apellido :"); ape = Console.ReadLine();
        Console.Write("Cedula :"); cedu = Convert.ToInt32( Console.ReadLine());
        Console.Write("Telefono :"); tele = Convert.ToInt64(Console.ReadLine());
        }

    }




  public class montocajife : montohambur
  {
      public void CF()
      {
        double iva = 0.16;
        int total = 0;
        int lin = 0;
        double totaiva = 0;
        //____________________________________
        int CANB, CANCF, CANP, CANN;
        
        int PRECIOCF = 1;
        int PRECIOP = 1;
        int PRECION = 1;
        int PRECIOB = 1;


        lin = Convert.ToInt32(Console.ReadLine());
        if (lin == 1)
        {
            Console.WriteLine("CANTIDAD DE CAJITA FELIZ :");
            CANCF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS :");
            CANP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOCF * CANCF + PRECIOP * CANP;          

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }
        else
        {

            Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
            CANCF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE NUGGETS :");
            CANN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB + PRECIOCF * CANCF + PRECION * CANN;
           
            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();

        }

      }

  }


public class montopostre: montohambur
{


    public void postre()
    {

        double iva = 0.16;
        int total = 0;
        int lin = 0;
        double totaiva = 0;
        //____________________________________
        int CANB, CANS, CANM;

       
        int PRECIOM = 3;
        int PRECIOS = 2;
        int PRECIOB = 1;

        //______________________________
       

        lin = Convert.ToInt32(Console.ReadLine());
        if (lin == 1)
        {
            
            Console.Write("CANTIDAD DE SUNDAES :"); 
            CANS = Convert.ToInt32(Console.ReadLine());
            total = PRECIOS * CANS;

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }
        else if (lin == 2)
        {

            Console.Write("CANTIDAD DE BARQUILLAS :");
            CANB = Convert.ToInt32(Console.ReadLine());

            total = PRECIOB * CANB; 
           
            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }

        else
        {
            Console.Write("CANTIDAD DE MCFLURRY :");
            CANM = Convert.ToInt32(Console.ReadLine());

            total = PRECIOM * CANM;
           
            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }


    }


}
    

public class montobebida : montohambur
{


    public void bebida1()
    {

        double iva = 0.16;
        int total = 0;
        double totaiva = 0;
        //________________________
        string linea;
        int CANA,CANR,CANJ;
        int lin = 0;
        int PRECIOA = 1;
        int PRECIOR = 2;
        int PRECIOJ = 2;

        lin = Convert.ToInt32(Console.ReadLine());
        if (lin == 1)
        {
            Console.Write("CANTIDAD DE AGUAS :"); 
            CANA = Convert.ToInt32(Console.ReadLine());

            total = PRECIOA * CANA;

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }
        else if (lin == 2)
        {
            Console.Write("CANTIDAD DE REFRESCOS :"); 
            CANR = Convert.ToInt32(Console.ReadLine());
            total = PRECIOR * CANR;

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }
        else
        {

            Console.Write("CANTIDAD DE JUGOS :"); 
            CANJ = Convert.ToInt32(Console.ReadLine());
            total = PRECIOJ * CANJ;

            totaiva = total * iva;

            Console.WriteLine("El total con iva es de :" + totaiva);
            Console.WriteLine("Pulse cualquier tecla");
            Console.ReadKey();
        }



    }


}

    

