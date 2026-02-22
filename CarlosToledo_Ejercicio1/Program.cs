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

Console.WriteLine("Nivel de dolor (0-10): ");
int niveldolor = int.Parse(Console.ReadLine());

Console.WriteLine("Presión Sistólica: ");
int pressistolica = int.Parse(Console.ReadLine());
