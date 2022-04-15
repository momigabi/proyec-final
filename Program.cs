

int dato=0;


menu newmenu = new menu();
montohambur monto = new montohambur();
montocajife cajife = new montocajife();
montopostre postre = new montopostre();
montobebida bebida = new montobebida();

//__________________________________________

newmenu.desicion();
Console.WriteLine();

dato= Convert.ToInt32(Console.ReadLine());



int dat = 0;



if (dato == 1)
{
    monto.cliente();
    newmenu.hambur();
    monto.calcuhambur();

}

else if (dato == 2)
{
    cajife.cliente();
    newmenu.cajifeliz();
    cajife.CF();



}else if (dato == 3)
{
    postre.cliente();
    newmenu.postre();
    postre.postre();


}else
{
    bebida.cliente();
    newmenu.bebida();
    bebida.bebida1();

}