using System;

namespace ArrayMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]dizi={23,12,4,86,72,3,11,17};
            //sırasız dizi
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            //sıralı dizi
            Array.Sort(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
            //clear

            Array.Clear(dizi,2,2); //ikinci indeksten başlayarak 2 elemanı sil
            foreach (var item in dizi)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();

            //reverse
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();

            //indexOf
            Array.IndexOf(dizi,23);
            System.Console.WriteLine(Array.IndexOf(dizi,23));

            //resize
            Array.Resize<int>(ref dizi,9);
            foreach (var item in dizi)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();


        }
    }
}
