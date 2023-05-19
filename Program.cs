int glicemia;
string diagnostico;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Diabetes Gestacional");

Console.Write("glicemia (em mg/dL)...: ");
glicemia = Convert.ToInt32(Console.ReadLine());

if (glicemia > 126)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
   diagnostico = "Diabetes Mellitus na gravidez";
}
else
{
    if (glicemia >= 92)
     {
        diagnostico = "Compativel com diabetes gestacional";
     }
     else
     {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        diagnostico = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
     }
}
 Console.WriteLine();
 Console.WriteLine(diagnostico);