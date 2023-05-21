using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin_Biciclete
{
   //Adaugare enum in clasa bicicleta
   public enum Culoare
   {
      Verde,
      Albastru,
      Alb
   }

   [Flags]
   public enum Tip
   {
      None = 0,
      Electrica = 1,
      Pliabila = 2,
      Mini = 4
   }
   public class Bicicleta
   {
        private const char SEPARATOR_DATE = '#';
        private static int idcurent = 0;
      public double Id { get; set; }
      public string Brand { get; set; }
      public string Model { get; set; }
      public double Pret { get; set; }
      public bool Stoc { get; set; }
      public Culoare Culoare { get; set; }
      public Tip TipBicicleta { get; set; }

      //Initializare constructor al clasei Bicicleta
      public Bicicleta( string brand, string model, double pret, bool stoc, Culoare culoare, Tip optiuni)
      {
         Id = idcurent++;
         Brand = brand;
         Model = model;
         Pret = pret;
         Stoc = stoc;
         Culoare = culoare;
         TipBicicleta = optiuni;
      }

        public Bicicleta(string stringSavedBicicleta)
        {
            string[] splits = stringSavedBicicleta.Split(SEPARATOR_DATE);

            this.Id = idcurent++;
            this.Brand = splits[0];
            this.Model = splits[1];
            this.Pret = double.Parse(splits[2]);
            this.Stoc = bool.Parse(splits[3]);
           
            Enum.TryParse(splits[4], out Culoare culoare);

            this.Culoare = culoare;

            Enum.TryParse(splits[5], out Tip optiuni);

            this.TipBicicleta = optiuni;
        }


        //Returnam variabilele clasei
        public override string ToString()
      {
         return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Pret: {Pret}RON, Disponibilitate: {(Stoc ? "DA" : "NU")}, Culoare: {Culoare}, Optiuni: {TipBicicleta}";
      }

      public string ConversieFisier()
        {
            return $"{Brand}{SEPARATOR_DATE}" +
                $"{Model}{SEPARATOR_DATE}" +
                $"{Pret}{SEPARATOR_DATE}" +
                $"{Stoc}{SEPARATOR_DATE}" +
                $"{Culoare}{SEPARATOR_DATE}" +
                $"{TipBicicleta}\n";

        }
   }
}