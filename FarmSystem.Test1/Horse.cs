using System;

namespace FarmSystem.Test1
   {
   public class Horse: BaseFarmAnimal
      {
      public void Run()
         {
         Console.WriteLine("Horse is running");
         }

      public override void Talk()
         {
         Console.WriteLine("Horse says Neigh!");
         }
      }
   }