using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace HelloService
{
    public class ConsoleWriter : IWriter
    {
        bool IWriter.Write(string Output)
        {
            Debug.WriteLine(Output);
            return true;
        }
    }
}
