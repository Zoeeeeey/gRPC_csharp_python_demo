using System;


namespace gRPCDemo_cs_client
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateTestSuite testSuit = new GenerateTestSuite();
            string path = "okkkkk";
            string number = testSuit.Protocol(path);
            Console.WriteLine(number);
        }
    }
}
