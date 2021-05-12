using System;

namespace FarmSystem.Test1
   {
   public class Hen : BaseFarmAnimal
      {
      public override void Talk()
         {
         Console.WriteLine("Hen says CLUCKAAAAAWWWWK!");
         }

      public void Run()
         {
         Console.WriteLine("Hen is running");
         }
      }
   }