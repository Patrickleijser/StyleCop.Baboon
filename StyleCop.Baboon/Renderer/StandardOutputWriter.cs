﻿namespace StyleCop.Baboon.Renderer
{
    using System;

    public class StandardOutputWriter : IOutputWriter
    {
        public void WriteLine(string content)
        {
            System.Console.WriteLine(content);
        }

        public void WriteColoredLine(string content, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(content);
            System.Console.ResetColor();
        }

        public void WriteLineWithSeparator(string content, string separator)
        {
            System.Console.WriteLine(separator);
            System.Console.WriteLine(content);
        }
    }
}
