using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
   {
   public class EmydexFarmSystem
      {
      private readonly IList<BaseFarmAnimal> _mob;

      public event EventHandler FarmCleared;

      public EmydexFarmSystem()
         {
         _mob = new List<BaseFarmAnimal>();
         }

      protected virtual void OnFarmCleared(EventArgs e)
         {
         FarmCleared?.Invoke(this, e);
         }

      public void EnterMob(IEnumerable<BaseFarmAnimal> mob)
         {
         foreach (var animal in mob)
            {
            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");
            Enter(animal);
            }
         }

      //TEST 1
      //Hold all the animals so it is available for future activities
      public void Enter(BaseFarmAnimal animal)
         {
         _mob.Add(animal);
         }

      //TEST 2
      public void MakeNoise()
         {
         //Test 2 : Modify this method to make the animals talk
         foreach (var animal in _mob)
            {
            animal.Talk();
            }
         }

      //TEST 3
      public void MilkAnimals()
         {
         foreach (var animal in _mob.OfType<IMilkableAnimal>())
            {
            animal.ProduceMilk();
            }
         }

      //TEST 4
      public void ReleaseAllAnimals()
         {
         foreach (var animal in _mob)
            {
            Console.WriteLine($"{animal.GetType().Name} has left the Emydex farm");
            }
         _mob.Clear();
         OnFarmCleared(EventArgs.Empty);
         }
      }
   }