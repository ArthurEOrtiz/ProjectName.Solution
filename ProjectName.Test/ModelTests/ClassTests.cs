using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ProjectName.TestTools
{
  [TestClass]
  public class ClassTests : IDisposable
  {
    public void Dispose()
    {
      Class.ClearAll();
    }
    [TestMethod]
    public void NNameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      //Arrange

      //Act

      //Assert
    }

  }
}