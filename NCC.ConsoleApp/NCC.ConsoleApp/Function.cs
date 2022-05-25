namespace NCC.ConsoleApp
{
    public class Functions
    {
        public void FunctionOne(int i)
        {
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in ints)
            {
                if (i == item)
                {
                    return;
                }
            }
        }

        public void FunctionTwo(int a, string b)
        {
            //do something
        }

        public void FunctionThree(int[] a)
        {

        }

        public void FunctionFour(params int[] a)
        {

        }

        public int FunctionFive(int a, int b)
        {
            return a + b;
        }

        public int FunctionFiveV2(int a, int b) => a + b;

        public void FunctionSix(int a, int b, out int res)
        {
            a++;
            b++;
            res = a + b;
        }

        //in int a and in int b are readonly variable within the function scope. It cannot be changed.
        public void FunctionSeven(in int a, in int b, out int res)
        {
            //so a++ and b++ will show error.
            //a++; //not possible
            //b++; //not possible
            res = a + b;
        }

        public void FunctionEight(int a, int b, ref int res)
        {
            res = a + b;
        }
    }
}