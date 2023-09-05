
Console.WriteLine("Ingrese su edad");
Console.WriteLine("----------------");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("*********************");

Console.WriteLine("Cuantas adivinanzas acerto?....");
float adivanza = float.Parse(Console.ReadLine());

float pago = 0f;
float pagototal = 0f;
float bono = 0f;

if (edad>18)
{
    if (adivanza < 3)
    {

        pago = 30;
        pagototal = pago + (adivanza + 2) + (edad * 5);

    }
    else
    {
        pago = 50;
        pagototal = pago + (adivanza + 2) + (edad * 5);
    }


}
else
{
    if (adivanza < 3)
    {
        pago = 50;
        pagototal = pago + (adivanza + 2) + (edad * 5);
        

    }
    else
    {
        pago = 80;

        pagototal = pago + (adivanza + 2) + (edad * 5);
    }
}
Console.WriteLine("Usted estaria ganando:!!!"+pagototal+"$");
       

