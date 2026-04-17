// Versión 5(Reto adicional): Gestor de Lotes con Validaciones
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("++++++++++++++++++ 3D SERVICES S.A. +++++++++++++++++++");
Console.WriteLine("++++++++++ SISTEMA DE CÁLCULO DE MATERIALES +++++++++++");
Console.WriteLine("-------------------------------------------------------");

Console.Write("¿Cuántas piezas distintas componen el lote?: ");
int cantidad_piezas = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el costo de la resina por ml ($): ");
double costo_ml = double.Parse(Console.ReadLine());

double volumen_total_lote = 0.0;
double capacidad_maxima = 500.0; 
int piezas_validadas = 0;        

for (int i = 0; i < cantidad_piezas; i++) 
{
    Console.Write($"\nIngrese el volumen de la pieza {i + 1} (ml): ");
    double volumen_pieza = double.Parse(Console.ReadLine());

    if (volumen_pieza <= 0) 
    {
        Console.WriteLine("Dato inválido. El volumen debe ser mayor a 0. Pieza descartada.");
        continue; 
    }

    if (volumen_pieza > capacidad_maxima) 
    {
        Console.WriteLine($"Excede la capacidad de {capacidad_maxima}ml. Pieza descartada.");
        continue; 
    }

    volumen_total_lote += volumen_pieza; 
    piezas_validadas++;
    Console.WriteLine("Pieza agregada al lote.");
}

double costo_total_lote = volumen_total_lote * costo_ml;

Console.WriteLine("\n--- Resumen de Producción ---");
Console.WriteLine($"Total de piezas procesadas con éxito: {piezas_validadas} de {cantidad_piezas}");
Console.WriteLine($"Volumen total neto: {volumen_total_lote:F2} ml");
Console.WriteLine($"Costo total del lote: ${costo_total_lote:F2}");
