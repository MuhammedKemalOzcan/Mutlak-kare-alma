namespace Mutlak_kare_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aralarında boşluk bırakarak sayı giriniz:");
            var sayilar = Console.ReadLine();

            var parts = sayilar.Split(' ');

            int result = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                if (Convert.ToInt32(parts[i]) < 67)
                {
                    result += 67 - Convert.ToInt32(parts[i]);
                }
                else
                {
                    result += (67 - Convert.ToInt32(parts[i])) * -1;
                }
            }
            Console.WriteLine(result);

        }
    }
}
