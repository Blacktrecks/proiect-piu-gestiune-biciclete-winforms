using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin_Biciclete
{
   // Clasa MagazinBicicleta reprezinta un magazin online ce vinde biciclete

   public class MagazinBicicleta
   {
      public List<Bicicleta> biciclete = new List<Bicicleta>(); //declaram o noua lista privata ce va contine bicicletele
     

      public MagazinBicicleta()
      {
        
      
      }

      //Adauga bicicleta 
      public void AdaugaBicicleta(Bicicleta bicicleta)
      {
         biciclete.Add(bicicleta);
      }

      //Afisare lista biciclete din magazin
      public List<Bicicleta> GetBicicleta()
      {
         return biciclete;
      }

      //Afisare stoc in magazinul de biciclete
      public List<Bicicleta> GetBicicleteDisponibile()
      {
         List<Bicicleta> bicicleteDisponibile = new List<Bicicleta>();

         foreach (Bicicleta bicicleta in biciclete)
         {
            if (bicicleta.Stoc)
            {
               bicicleteDisponibile.Add(bicicleta);
            }
         }
         return bicicleteDisponibile.Count > 0 ? bicicleteDisponibile : new List<Bicicleta>();

      }


      //Functie ce salveaza datele despre bicicleta int-un fisier text extern
      public void SalveazaBiciclete(string filePath)
      {
         try
         {
            using (StreamWriter sw = new StreamWriter(filePath, true)) //il deschizi si suprascrii continut prin true
            {
               foreach (Bicicleta bicicleta in biciclete)
               {
                 
                  sw.Write(bicicleta.ConversieFisier());
               }
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"A aparut o eroare la salvarea fisierului: {ex.Message}");
         }
      }
      //Cautare biciclete
      public List<Bicicleta> SearchBiciclete(string criteria)
      {
         var bicicleteGasite = biciclete.Where(b =>
             b.Brand.ToLower().Contains(criteria.ToLower()) ||
             b.Model.ToLower().Contains(criteria.ToLower()) ||
             b.Pret.ToString().ToLower().Contains(criteria.ToLower())
         ).ToList();

         return bicicleteGasite;
      }


      //Citire biciclete din fisier
      public List<Bicicleta> ReadBicyclesFromFile(string filePath)
      {
         biciclete = new List<Bicicleta>();

        
            using (var reader = new StreamReader(filePath))
            {
               string line;
               while ((line = reader.ReadLine()) != null)
               {
                
                  biciclete.Add(new Bicicleta(line));
               }
            }
         
         

         return biciclete;
      }

   }
}
