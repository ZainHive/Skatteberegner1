using System;

public class Beregning
{
    private const decimal SkattefriGrænse = 1200m; // Skattefri grænse for gaver i 2021
    private const decimal JulegaveGrænse = 900m; // Skattefri grænse for julegaver

    public double SkatVedJulegave(decimal julegave, decimal andreGaver)
    {
        decimal samletGavebeløb = julegave + andreGaver;

        if (samletGavebeløb <= SkattefriGrænse)
        {
            return 0;
        }
        else
        {
            decimal skattepligtigtBeløb = samletGavebeløb - SkattefriGrænse;
            if (julegave <= JulegaveGrænse)
            {
                skattepligtigtBeløb -= julegave;
            }
            return (double)skattepligtigtBeløb;
        }
    }

    public static void Main(string[] args)
    {
        Beregning beregning = new Beregning();