// Versión 3: Validador de Impresión 3D V2
Console.WriteLine ("-------------------------------------------------------");
Console.WriteLine ("++++++++++++++++++ 3D SERVICES S.A. +++++++++++++++++++");
Console.WriteLine ("++++++++++ SISTEMA DE CÁLCULO DE MATERIALES +++++++++++");
Console.WriteLine ("-------------------------------------------------------");
Console.WriteLine("--- Validador de Impresión 3D V2 ---");
double capacidad_maxima = 500.0;
Console.Write("Ingrese el volumen de la pieza (ml): ");
double volumen = double.Parse (Console.ReadLine());
if (volumen > capacidad_maxima) {
Console.WriteLine("¡Error! La pieza excede la capacidad máxima de la impresora(500 ml).");
Console.WriteLine("Sugerencia: Divida el modelo en partes más pequeñas.");
} else {
Console.Write("Ingrese el costo de la resina por ml ($): ");
double costo_ml = double.Parse(Console.ReadLine());
double costo_total = volumen * costo_ml;
Console.WriteLine("Estado: ¡Aprobado para impresión!");
Console.WriteLine($"El costo total será: ${costo_total:F2}");
}
