using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    class menu
    {

        public int dato { get; set; }

        
        public void desicion()
        {
           
            Console.WriteLine("Tipo de orden: ");
            Console.WriteLine("1) Hamburguesa");
            Console.WriteLine("2) Cajita feliz");
            Console.WriteLine("3) Postre");
            Console.WriteLine("4) Bebida");
            

        }
        public void hambur()
        {   

            Console.WriteLine("TIPO DE HAMBURGUESA :");
            Console.WriteLine("1)big mac");
            Console.WriteLine("2)Quarter Pounder with Cheese");
            Console.WriteLine("3)Double Quarter Pounder with Cheese");
            Console.WriteLine("4)Quarter Pounder Deluxe");
            Console.WriteLine("5)McDouble");
           

        }

        public void cajifeliz()
        {  

            Console.WriteLine(" PAPAS O NUGGETS? :");    

        }

       public void postre()
        {
            

            Console.WriteLine("TIPO DE POSTRE :"); 
            Console.WriteLine("1)SUNDAE CON TOPPING :");
            Console.WriteLine("2)BARQUILLA :");
            Console.WriteLine("3)MCFLURRY :");
            
       }


        public void bebida()
        {
            
            Console.WriteLine("TIPO DE BEBIDA :");
            Console.WriteLine("1)AGUA :");
            Console.WriteLine("2)REFRESCO :");
            Console.WriteLine("3)JUGO :");
        
         
        }


    }


   

















