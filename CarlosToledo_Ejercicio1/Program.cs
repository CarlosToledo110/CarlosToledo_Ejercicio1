// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido, ¿Que tipo de atención necesita?");
Console.WriteLine("1. Emergencia ");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatría");
Console.WriteLine("4. Traumatología");
int opciónmenú = int.Parse(Console.ReadLine());

Console.WriteLine("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Temperatura (grados centígrados): ");
double temp = double.Parse(Console.ReadLine());

Console.WriteLine ("Saturación de oxígeno (%): ");
int oxigeno = int.Parse(Console.ReadLine());    

Console.WriteLine("Nivel de dolor (0-10): ");
int niveldolor = int.Parse(Console.ReadLine());

Console.WriteLine("Presión Sistólica: ");
int pressistolica = int.Parse(Console.ReadLine());

if (edad < 0 || edad > 150)
{
    Console.WriteLine("Error: Edad fuera de rango");
    return;
}
else if (temp < 30 || temp > 50)
{
    Console.WriteLine("Error: Saturación fuera de rango");
    return;
}
else if (oxigeno < 0 || oxigeno > 50)
{
    Console.WriteLine("Error: Saturación fuera de rango");
    return;
}
else if (niveldolor < 0 || niveldolor > 10)
{
    Console.WriteLine("ERROR: Nivel de dolor inválido");
    return;
}
else if (pressistolica < 50 || pressistolica > 250) ;
{
    Console.WriteLine("ERROR: Presión sistólica fuera de rango");
}

int prioridad = 4; 

switch (opciónmenú)
{
    case 1:
        if (oxigeno < 90)
        {
            prioridad = 1;
        }
        else
        {
            if (temp >= 39 && niveldolor >= 8)
            {
                prioridad = 2;
            }
            else
            {
                prioridad = 3;
            }
        }
        break;

        case 2:
        if (niveldolor >= 7)
        {
            prioridad = 3;

        }
        else
        {
            prioridad = 4;
        }
        break;

        case 3:
        if (edad < 12)
        {
            if (temp >= 38.5)
            { 
                prioridad = 2;
            }
            else
            {
                prioridad = 3;
            }
        }
        else
        {
            prioridad = 4;
        }
        break;

        case 4:
        if (niveldolor  > 8) 
        {
            prioridad = 2;
        }
        else
        {
            prioridad = 3; 
        }
        break;

    default:
        Console.WriteLine("ERROR: tipo de atención inválido");
        return;
}