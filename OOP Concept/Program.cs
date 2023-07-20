namespace OOP_Concept
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            ParameterType pt = new ParameterType();
            Console.WriteLine("Optional paramiter 1 : "+pt.OptionalParameter(10, 15));
            Console.WriteLine("Optional paramiter 2 : " + pt.OptionalParameter(20, 30, 10));
            Console.WriteLine("Named paramiter  : " + pt.NamedParameter(5,c:6,b:9));
            Console.WriteLine("Param parametr 2 : " + pt.ParamMultiply(5,5,5,5,5,9));
            */

            Date dt = new Date();
            dt.ShowDate(21, 07, 2023);
        }
    }
}