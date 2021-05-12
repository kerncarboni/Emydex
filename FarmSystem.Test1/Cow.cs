using System;

namespace FarmSystem.Test1
   {
   public class Cow: BaseFarmAnimal, IMilkableAnimal
      {
      public override void Talk()
         {
         Console.WriteLine("Cow says Moo!");
         }

      public void Walk()
         {
         Console.WriteLine("Cow is walking");
         }
      
      public void ProduceMilk()
         {
         Console.WriteLine("Cow produced milk");
         }

      public void Run()
         {
         Console.WriteLine("Cow is running");
         }
      }
   }