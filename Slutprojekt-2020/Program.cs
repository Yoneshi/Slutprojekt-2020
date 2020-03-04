using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt_2020
{

    class Dater //denna Dater klass har all information som krävs för att ge världen
    {
        public Gender gender; //enum

        public string name;// allt nedan är public för att dem skall nås utanför klassenn. 

        public int age;


        public String hobby;

        // En  kontruktor är en metod som körs när en klass instansieras tex kör (dater)
        public Dater(Gender gender, string name, int age, string hobby)
        {
            this.gender = gender; // detta kodstycke refererar till gender variabeln utanför metoden och ger ett värde till klassens gender istället för att loopa internt.
            this.name = name;
            this.age = age;
            this.hobby = hobby;


        }

        public void Print() //glöm inte att ha parenteser efter metoder
        {

            Console.WriteLine("Gender: " + gender.ToString() + "." + " " + "Name: " + name); // denna rad skriver ut kön och namn. för att convertera en enums måste man skriva ".ToString)
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hobby: " + hobby);

        }



    }

    enum Gender // enum byter ut siffor till bokstäver, typ som man gjorde i minecraft lol
    {
        neutral,
        Male,
        Female

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("jag lärde wood att använda git, nu testar jag bara om allt fungerar");

            Dater d = new Dater(Gender.neutral, "Sasha", 22, "Tumblr scrolling and cat videos");
     

            d.Print();


            Console.ReadLine();
        }
    }
}
