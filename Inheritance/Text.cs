﻿namespace CSharpInter
{
    public class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to "+ url);
        }
    }
}