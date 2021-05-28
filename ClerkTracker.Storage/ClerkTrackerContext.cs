// [I]. HEAD
//  A] Libraries
using System; // for enum
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using ClerkTracker.Domain.Abstracts;

using ClerkTracker.Domain.Models;
using ClerkTracker.Domain.Models.Employees;
using ClerkTracker.Domain.Models.Scheduling;
using ClerkTracker.Domain.Models.Breaks;

///
namespace ClerkTracker.Storage
{
  public class ClerkTrackerContext : DbContext
  {
    //  B] Properties
    private const int INDEX_FOR_UNSUPPORTED = -1;


    public readonly GroceryStore ourStore = new GroceryStore(){
      Name = "Kroger",
      StoreNumber = 463
    };
    public DbSet<Clerk> Clerks { get; set; }

    public DbSet<Csm> Csms { get; set; }

    public Csm Captain {get; set;}

    public DailyClerkSchedule todaysClerkSchedule { get; set; }
    public DbSet<CoffeeBreak> CoffeeBreaks { get; set; }
    public DbSet<LunchBreak> LunchBreaks { get; set; }
    public DbSet<CartTime> CartTimes { get; set; }
    public DbSet<RestroomCheckTime> RestroomCheckTimes { get; set; }
    public DbSet<FloorSweepTime> FloorSweepTime { get; set; }

    public DbSet<SpillAlert> SpillAlerts { get; set; }
    
    //  C]
    ///
    private readonly IConfiguration _configuration;

    public ClerkTrackerContext(DbContextOptions options) : base(options) { }


    // [II]. BODY
    /// 
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(_configuration["mssql"]);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      EstablishGenerics(builder);
      EstablishEntities(builder);
      EstablishRelationships(builder);
      SeedInitialData(builder);
    }

    ///
    private void EstablishGenerics(ModelBuilder builder)
    {
      builder.Entity<GroceryEmployer>().HasBaseType<AnEmployer>();
      builder.Entity<GroceryStore>().HasBaseType<AStore>();
      builder.Entity<AnEmployee>().HasBaseType<APerson>();
      builder.Entity<GroceryEmployee>().HasBaseType<AnEmployee>();
      builder.Entity<Clerk>().HasBaseType<GroceryEmployee>();
      builder.Entity<Csm>().HasBaseType<GroceryEmployee>();
      builder.Entity<GroceryStore>().HasBaseType<AStore>();
    }

    ///
    private void EstablishEntities(ModelBuilder builder)
    {
      EstablishEmployer(builder);
      EstablishEmployees(builder);
    }

    private void EstablishEmployer(ModelBuilder builder)
    {
      builder.Entity<GroceryEmployer>().HasKey(e => e.EntityId);
      builder.Entity<GroceryStore>().HasKey(e => e.EntityId);
    }

    private void EstablishEmployees(ModelBuilder builder)
    {
      builder.Entity<Csm>().HasKey(e => e.EntityId);
      builder.Entity<Clerk>().HasKey(e => e.EntityId);
    }

    
    //  B]
    ///
    private void EstablishRelationships(ModelBuilder builder)
    { //<!> fix this shit
      builder.Entity<GroceryEmployer>().HasMany<GroceryStore>(employer => employer.Stores).WithOne(store => store.Employer);
      builder.Entity<GroceryStore>().HasMany<GroceryEmployee>(store => store.Employees).WithOne(employee => employee.Store);
    }// /ax 'EstablishRelationships'


    //  C]
    /// the initial seed data for the enitity tables
    private void SeedInitialData(ModelBuilder builder)
    {
      SeedEmployer(builder);
      SeedCsms(builder);
      SeedClerks(builder);
    }// /ax 'SeedInitalData'


    private void SeedEmployer(ModelBuilder builder)
    {
      builder.Entity<GroceryEmployer>().HasData(new GroceryEmployer[]
      {
        new GroceryEmployer() {EntityId = 342617402} //34-2617-402
      });
      builder.Entity<GroceryStore>().HasData(new GroceryStore[]
      {
        new GroceryStore() {EntityId = 463}
      });
    }// /ax 'SeedEmployer'

    ///
    private void SeedCsms(ModelBuilder builder)
    {
      builder.Entity<Csm>().HasData(new Csm[]
      {
        new Csm("Margie","Kowalski") {EntityId = 001},
        new Csm("Dorothy","Dubacheq") {EntityId = 002},
        new Csm("Leia","Figureli") {EntityId = 004},
      });
    }// /ax 'SeedCsms'

    /// <summary> Seed the values for pizza sauces. </summary>
    private void SeedClerks(ModelBuilder builder)
    {
      builder.Entity<Csm>().HasData(new Csm[]
      {
        new Csm("Margie","Kowalski") {EntityId = 001},
        new Csm("Dorothy","Dubacheq") {EntityId = 002},
        new Csm("Leia","Figureli") {EntityId = 004},
      });
   
    }// /ax 'SeedSauces'

    /// <summary> Seed the values for pizza cheeses. </summary>
    private void SeedCheeses(ModelBuilder builder)
    {
      //  a) head
      List<PizzaToppingCheese> cheeses = new List<PizzaToppingCheese>();

      //  b) body
      foreach (int index in Enum.GetValues(typeof(PizzaToppingCheese.Choice)))
      {
        if (index == INDEX_FOR_UNSUPPORTED) continue;

        PizzaToppingCheese cheese = new PizzaToppingCheese(index);
        cheese.EntityId = index;
        cheeses.Add(cheese);
      }// next cheese 'index'

      //  c) foot
      /// Add the cheese choices collection to the context.
      builder.Entity<PizzaToppingCheese>().HasData(cheeses.ToArray());
    }// /ax 'SeedCheeses'

    private void SeedToppings(ModelBuilder builder)
    {
      SeedCheeses(builder);
      SeedVegetables(builder);
      SeedMeats(builder);
      SeedFruits(builder);
      SeedMiscelanous(builder);
    }

    /// <summary> Seed the values for pizza vegetables. </summary>
    private void SeedVegetables(ModelBuilder builder)
    {
      //  a) head
      List<PizzaToppingVegetable> vegetables = new List<PizzaToppingVegetable>();

      //  b) body
      foreach (int index in Enum.GetValues(typeof(PizzaToppingVegetable.Choice)))
      {
        if (index < 1) continue;
        if (index == INDEX_FOR_UNSUPPORTED) continue;

        vegetables.Add(new PizzaToppingVegetable(index));
      }// next vegetable 'index'

      //  c) foot
      /// Add the collection of vegetable choices to the context.
      builder.Entity<PizzaToppingVegetable>().HasData(vegetables.ToArray<PizzaToppingVegetable>());
    }// /ax 'SeedVegetables'

    /// <summary> Seed the values for pizza meats. </summary>
    private void SeedMeats(ModelBuilder builder)
    {
      //  a) head
      List<PizzaToppingMeat> meats = new List<PizzaToppingMeat>();

      //  b) body
      foreach (int index in Enum.GetValues(typeof(PizzaToppingMeat.Choice)))
      {
        if (index < 1) continue;
        if (index == INDEX_FOR_UNSUPPORTED) continue;

        meats.Add(new PizzaToppingMeat(index));
      }// next meat 'index' 

      //  c) foot
      /// Add the collection of meat choices to the context.
      builder.Entity<PizzaToppingMeat>().HasData(meats.ToArray<PizzaToppingMeat>());
    }// /ax 'SeedMeats'

    /// <summary> Seed the values for pizza fruits. </summary>
    private void SeedFruits(ModelBuilder builder)
    {
      //  a) head
      List<PizzaToppingFruit> fruits = new List<PizzaToppingFruit>();

      //  b) body
      foreach (int index in Enum.GetValues(typeof(PizzaToppingFruit.Choice)))
      {
        if (index < 1) continue;
        if (index == INDEX_FOR_UNSUPPORTED) continue;

        fruits.Add(new PizzaToppingFruit(index));
      }// next fruit 'index'

      //  c) foot
      /// Add the collection of fruit choices to the context.
      builder.Entity<PizzaToppingFruit>().HasData(fruits.ToArray<PizzaToppingFruit>());
    }// /ax 'SeedFruits'

    /// <summary> Seed the values for pizza fruits. </summary>
    private void SeedMiscelanous(ModelBuilder builder)
    {
      //  a) head
      List<PizzaToppingMiscelaneous> items = new List<PizzaToppingMiscelaneous>();

      //  b) body
      foreach (int index in Enum.GetValues(typeof(PizzaToppingMiscelaneous.Choice)))
      {
        if (index < 1) continue;
        if (index == INDEX_FOR_UNSUPPORTED) continue;

        items.Add(new PizzaToppingMiscelaneous(index));
      }// next fruit 'index'

      //  c) foot
      /// Add the collection of fruit choices to the context.
      builder.Entity<PizzaToppingMiscelaneous>().HasData(items.ToArray<PizzaToppingMiscelaneous>());
    }// /ax 'SeedFruits'
     //........................................................................

    /// <summary> Seed the values for pizza spices. </summary>
    private void SeedSpices(ModelBuilder builder)
    {
      //  a) head
      List<PizzaSpice> spices = new List<PizzaSpice>();

      //  b) body
      foreach (int index in Enum.GetValues(typeof(PizzaSpice.Choice)))
      {
        if (index == INDEX_FOR_UNSUPPORTED) continue;

        PizzaSpice spice = new PizzaSpice(index);
        spice.EntityId = index;
        spices.Add(spice);
      }// next 'index'

      //  c) foot
      /// Add the collection of spice choices to the context.
      builder.Entity<PizzaSpice>().HasData(spices.ToArray());
    }// /ax 'SeedSpices'
     //------------------------------------------------------------------------

    /// 
    private void SeedOrders(ModelBuilder builder)
    {
      builder.Entity<PizzaOrder>().HasData(new PizzaOrder[] { });
    }// /ax 'SeedOrders'

    ///
    private void SeedStores(ModelBuilder builder)
    {
      builder.Entity<ExpressPizzaStore>().HasData(new ExpressPizzaStore[]
      {
        new ExpressPizzaStore() {EntityId = 1, Name = "Dominos"},
        new ExpressPizzaStore() {EntityId = 2, Name = "ModPizza"},
        new ExpressPizzaStore() {EntityId = 3, Name = "Subway"}
      });

      builder.Entity<FamilyPizzaStore>().HasData(new FamilyPizzaStore[]
      {
        new FamilyPizzaStore() {EntityId = 1, Name = "Pizza Hut"},
        new FamilyPizzaStore() {EntityId = 2, Name = "Tony's"},
        new FamilyPizzaStore() {EntityId = 3, Name = "Pizzapopolis"}
      });
    }// /ax 'SeedStores'

    private void SeedOwners(ModelBuilder builder)
    {
      builder.Entity<PizzaStoreOwner>().HasData(new PizzaStoreOwner[]
      {
          new PizzaStoreOwner() {EntityId = 1, Name = "Jackie Noid"},
          new PizzaStoreOwner() {EntityId = 2, Name = "Tom Tesla"},
          new PizzaStoreOwner() {EntityId = 3, Name = "Jared Cooper"},

          new PizzaStoreOwner() {EntityId = 4, Name = "Jared Cooper"},
          new PizzaStoreOwner() {EntityId = 5, Name = "Tony Phatt"},
          new PizzaStoreOwner() {EntityId = 6, Name = "Chicago Pete"}
      });
    }// /ax 'SeedOwners'

    /// <summary> Seed the customer data </summary>
    private void SeedClerks(ModelBuilder builder)
    {
      builder.Entity<Clerk>().HasData(new Clerk[]
     {
        new Clerk() { EntityId = 1, Name = "Uncle John" },
        new Clerk() { EntityId = 2, Name = "Uncle Buck" },
        new Clerk() { EntityId = 3, Name = "Bartholomew Mog" }
     });
    }// /ax 'SeedClerks'

    /// <summary> </summary>
    private void SeedCoupons(ModelBuilder builder)
    {
      builder.Entity<PizzaCoupon>().HasData(new PizzaCoupon[]
      {
        new PizzaCoupon() { EntityId = 1, Id=939934071,
          DiscountedWare = new PepperoniPizza()
          {
            Size = new PizzaSize(PizzaSize.Choice.LARGE)
          },
          AmountOff = 2, // = -$2
        },// /cpn

          new PizzaCoupon() { EntityId = 1, Id=533791774,
          DiscountedWare = new PepperoniPizza()
          {
            Size = new PizzaSize(PizzaSize.Choice.SHEET)
          },
          AmountOff = 5, // = -$5
        }// /cpn
      });
    }// /ax 'SeedCoupons'

  }// /cla 'ClerkTrackerContext'
}// /ns '..Storage'
 // EoF