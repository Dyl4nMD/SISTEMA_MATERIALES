// Versión 4: Gestor de Lotes de Producción
Console.WriteLine ("-------------------------------------------------------");
Console.WriteLine ("++++++++++++++++++ 3D SERVICES S.A. +++++++++++++++++++");
Console.WriteLine ("++++++++++ SISTEMA DE CÁLCULO DE MATERIALES +++++++++++");
Console.WriteLine ("-------------------------------------------------------");
Console.Write("¿Cuántas piezas distintas componen el lote?: ");
int cantidad_piezas = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el costo de la resina por ml ($): ");
double costo_ml = double.Parse(Console.ReadLine());
double volumen_total_lote = 0.0;
for (int i = 0; i < cantidad_piezas; i++) {
Console.Write($"Ingrese el volumen de la pieza {i + 1} (ml): ");
double volumen_pieza = double.Parse(Console.ReadLine());
volumen_total_lote += volumen_pieza; // Acumulador
}
double costo_total_lote = volumen_total_lote * costo_ml;
Console.WriteLine("\n--- Resumen de Producción ---");
Console.WriteLine($"Total de piezas: {cantidad_piezas}");
Console.WriteLine($"Volumen total requerido: {volumen_total_lote:F2} ml");
Console.WriteLine($"Costo total del lote: ${costo_total_lote:F2}");
