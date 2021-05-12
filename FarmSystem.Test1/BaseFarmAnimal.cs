namespace FarmSystem.Test1
   {
   public abstract class BaseFarmAnimal 
      {
      public virtual string Id { get; set; }
      public virtual int NoOfLegs { get; set; }
      public abstract void Talk();
      }
   }