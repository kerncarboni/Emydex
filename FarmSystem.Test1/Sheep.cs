using System;

namespace FarmSystem.Test1
   {
   public class Sheep: BaseFarmAnimal
      {
      public override void Talk()
         {
         Console.WriteLine("Sheep says baa!");
         }

      public void Run()
         {
         Console.WriteLine("Sheep is running");
         }

  
      }
   }