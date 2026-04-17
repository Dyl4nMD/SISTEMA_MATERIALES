// Versión 2: Banner de Sistema
Console.WriteLine ("-------------------------------------------------------");
Console.WriteLine ("++++++++++++++++++ 3D SERVICES S.A. +++++++++++++++++++");
Console.WriteLine ("++++++++++ SISTEMA DE CÁLCULO DE MATERIALES +++++++++++");
Console.WriteLine ("-------------------------------------------------------");
Console.Write("Ingrese el volumen de la pieza (ml): ");
double volumen = double.Parse(Console.ReadLine());
Console.Write("Ingrese el costo de la resina por ml ($): ");
double costo_ml = double.Parse(Console.ReadLine());
double costo_total = volumen * costo_ml;
Console.WriteLine($"\nEl costo total de manufactura es: ${costo_total:F2}");
