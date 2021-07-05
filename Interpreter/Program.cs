using System;
using System.IO;


namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\dev\c#\GoF Patterns\Interpreter\txt.txt";
            var testText = File.ReadAllText(path).Replace(Environment.NewLine, "\n");
            var interpreter = new BaseInterpreter(testText);
            
            interpreter.Interpret();
            var res = interpreter.GetResult();
            File.WriteAllText(path.Replace("txt.txt", "txt1.txt"), res);
        }
    }
}