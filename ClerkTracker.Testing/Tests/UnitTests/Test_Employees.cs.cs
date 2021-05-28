// [I]. HEAD
//  A] Libraries

using System;
using System.Collections.Generic;
using Xunit;

using ClerkTracker.Domain.Abstracts;
using ClerkTracker.Domain.Models.Employees;
using ClerkTracker.Domain.Models.Scheduling;

///
namespace ClerkTracker.Testing.UnitTests
{
  /// Tests for stores
  public class Test_Employees
  {
    //  B] Fields & Properties
    /// checks if the employees can be gathered in a container
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new Clerk() },
      new object[] { new Csm() }
    };

    /// 
    [Fact]
    public void Test_Clerk()
    {
      // arrange
      var sut = new Clerk("Pete","Bingham");

      // act
      var actual = "Pete Bingham";

      // assert
      Assert.True(actual == sut.FullName);
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_ExpressPizzaStore()
    {
      var sut = new ExpressPizzaStore();

      Assert.True(sut.Name.Equals("ExpressPizzaStore"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="store"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_StoreName(AStore store)
    {
      Assert.NotNull(store.Name);
      Assert.Equal(store.Name, store.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="storeName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("FamilyPizzaStore")]
    [InlineData("ExpressPizzaStore")]
    public void Test_StoreNameSimple(string storeName)
    {
      Assert.NotNull(storeName);
    }

  }// /cla
}// /ns
// EoF