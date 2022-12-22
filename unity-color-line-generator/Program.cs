try
{
    Console.WriteLine("Enter HEX value of color (without #)");
    string inputColor = Console.ReadLine();
    float firstValue = int.Parse(inputColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
    float secondValue = int.Parse(inputColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
    float thirdValue = int.Parse(inputColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber) / 255f;

    Console.WriteLine("Process Complete: ");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"new Color({firstValue.ToString("F3")}f, {secondValue.ToString("F3")}f, {thirdValue.ToString("F3")}f, 1.0f);");
}
catch
{
    Console.WriteLine("Some error occured. Retry again. Make sure the format is as follows: FFFFFF");
}
