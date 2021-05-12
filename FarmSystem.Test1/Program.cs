using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
   {
   internal class Program
      {
      private static void Main(string[] args)
         {
         Exercise1();
         Exercise2();
         Exercise3();
         Exercise4();
         Console.ReadKey();
         }

      private static void OnFarmClearedHandler(object sender, EventArgs e)
         {
         Console.WriteLine("Emydex Farm is now empty");
         }

      /************************************************************************************************************
      Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
      modify the code to get the output below
      Cow has entered the farm
      Hen has entered the farm
      Horse has entered the farm
      Sheep has entered the farm
      ***************************************************************************************************************/
      private static void Exercise1()
         {
         Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");
         Console.ReadKey(true);

         var farm = new EmydexFarmSystem();
         farm.EnterMob
            (
            CreateMob()
            );

         Console.WriteLine();
         Console.ReadKey(true);
         }

      /***************************************************************************************************************
       Test Exercise 2
       If you have completed the first test excercise, you can continue with the second one
       Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
       Expected Test 2 Program Output
      
       Exercise 2 : Press any key to scare the animals in the farm
          Cow has entered the farm
          Hen has entered the farm
          Horse has entered the farm
          Sheep has entered the farm
          Cow says Moo!
          Hen says CLUCKAAAAAWWWWK!
          Horse says Neigh!
          Sheep says baa!
       *****************************************************************************************************************/
      private static void Exercise2()
         {
         Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
         Console.ReadKey(true);
          
         var farm = new EmydexFarmSystem();
         farm.EnterMob
            (
            CreateMob()
            );
         farm.MakeNoise();

         Console.WriteLine();
         Console.ReadKey(true);
         }

      /*****************************************************************************************************************
      Test Exercise 3
      If you have completed the previous test exercise, you can continue with this one 
      The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
      so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output
      
      Expected Test 3 Program Output
      
      Exercise 3 : Press any key when it is time to milk animals
      Cow has entered the farm
      Hen has entered the farm
      Horse has entered the farm
      Sheep has entered the farm
      Cow was milked!
      ************************************************************************************************************/
      private static void Exercise3()
         {
         Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
         Console.ReadKey(true);

         var farm = new EmydexFarmSystem();
         farm.EnterMob
            (
            CreateMob()
            );
         farm.MilkAnimals();

         Console.WriteLine();
         Console.ReadKey(true);
         }

      /****************************************************************************************************
      Test Exercise 4
      Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
      Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
      Subscribe to that event in the main to get the expected output
      
      Expected Test 4 Program Output
      
      Exercise 4: Press any key to free all animals
      Cow has entered the farm
      Hen has entered the farm
      Horse has entered the farm
      Sheep has entered the farm
      Cow has left the farm
      Hen has left the farm
      Horse has left the farm
      Sheep has left the farm
      Emydex Farm is now empty
      ********************************************************************************************************************/
      private static void Exercise4()
         {
         Console.WriteLine("Exercise 4: Press any key to free all animals");
         Console.ReadKey(true);

         var farm = new EmydexFarmSystem();
         farm.FarmCleared += OnFarmClearedHandler;

         farm.EnterMob
            (
            CreateMob()
            );
         farm.ReleaseAllAnimals();

         Console.WriteLine();
         Console.ReadKey(true);
         }

      private static IEnumerable<BaseFarmAnimal> CreateMob()
         {
         return new List<BaseFarmAnimal>
            {
            new Cow
               {
               Id = Guid.NewGuid().ToString(),
               NoOfLegs = 4,
               
               },
            new Hen
               {
               Id = Guid.NewGuid().ToString(),
               NoOfLegs = 2
               },
            new Horse
               {
               Id = Guid.NewGuid().ToString(),
               NoOfLegs = 4
               },
            new Sheep
               {
               Id = Guid.NewGuid().ToString(),
               NoOfLegs = 4
               }
            };
         }
      }
   }