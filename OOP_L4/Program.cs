using System;

namespace OOP_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaperBook book = new PaperBook
            { _text = "Видача чужого твору за своє чи незаконне опублiкування чужого твору пiд своїм iм'ям, лiтературний крадiжка.",
                _fontName = "Times new Roman",
                _fontSize = 18,
                _textColor = "Red"

            };
            book.PageCount();
            book.ShowInfo();
            book.SymbolCount();
            Console.WriteLine();
            Console.WriteLine();
            ElectrinicBook electrinicBook = new ElectrinicBook
            {
                _text = "Нiхто не хоче вставати о 4-й ранку i йти бiгати, коли ще зовсiм темно, але це необхiдно.",
                _fontName = "Arial",
                _fontSize = 12

            };
            electrinicBook.PageCount();
            electrinicBook.ShowInfo();
            electrinicBook.SymbolCount();

            Console.WriteLine();
            Console.WriteLine();

            Graffiti graffiti = new Graffiti
            {
                _text = "puTiN h#ylo!",
                _fontName = "Calibri",
                _fontSize = 56
            };
            graffiti.PageCount();
            graffiti.ShowInfo();
            graffiti.SymbolCount();



        }
    }
}
