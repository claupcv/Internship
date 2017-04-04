using System;


namespace HelloWorld
{
    class Delegates
    {
        [Flags]
        enum DayOfWeek : byte
        {
            Monday = 0x00,    //0, in hexa
            Tuesday = 0x01,   //2 la puterea 0, in hexa
            Wednesday = 0x02, //2 la puterea 1, in hexa
            Thursday = 0x04,  //2 la puterea 2, in hexa
            Friday = 0x08,    //2 la puterea 3, in hexa
            Saturday = 0x10,  //2 la puterea 4, in hexa
            Sunday = 0x20     //2 la puterea 5, in hexa
        }
        delegate void D(int value);

        public static void DelegatesTestMethod()
        {
            //D d = v => Console.WriteLine(v);
            D d = v => v--;
            d.Invoke(4);
            //Console.WriteLine((int)d(4));
            //int ii = (int)DayOfWeek.Friday;
            int wasd = 4;
            object o = wasd;
            // declararea unei matrici de dimensiune 3 x 3
            int[,] matrix = new int[3, 3]
                {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

            // va afisa 9 (numarul total de de elemente)
            Console.WriteLine(matrix.Length);
        }
    }
}
