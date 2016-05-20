using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExplodingJelly.SprayGenerator;
using ExplodingJelly.SprayGeneratorTests;


namespace what
{
    public class Class1
    {
        public Class1()
        {
        }

        static void Main(String arg[])
        {
            ExplodingJelly.SprayGeneratorTests Test = new ExplodingJelly.SprayGeneratorTests();
            Test.VTFGeneratorTests.StaticImage_NoFading_NoAlpha();

            Console.WriteLine("완료.");
        }
    }
}
