using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MangaList
{
    class MangaInformation
    {
        // Field yang digunakan pada constructor
        private string mangaTitle;
        private string mangaCreator;
        private string mangaPrize;
        private string yearRelease;

        // Bagian constructor 
        public MangaInformation(string title, string creator, string prize, string release)
        {  
            this.mangaTitle = title;
            this.mangaCreator = creator;
            this.mangaPrize = prize;
            this.yearRelease = release;
        }

        static void Main(string[] args)
        {   
            ShowUserInput();
        }

        public static void ShowUserInput()
        {   
            MangaInformation mangaProfile = new MangaInformation(" Dragon Ball ", " Akira Toriyama ", " 30.000 ", " 1995 "); 
            string [] mangaConstructorList = {mangaProfile.mangaTitle, mangaProfile.mangaCreator, mangaProfile.mangaPrize, mangaProfile.yearRelease};

            string[] mangaTitle = {" Judul manga : ", " Tahun terbit : ", " Penulis : ", " Harga : "};

            Console.WriteLine(" === Informasi mengenai Manga === ");
            for(int increment = 0; increment < mangaTitle.Length; increment++)
            {   
                Console.WriteLine(mangaTitle[increment] + mangaConstructorList[increment]);
            }
        }
    }
}