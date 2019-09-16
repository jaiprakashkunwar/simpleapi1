using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        
        ValuesController contoller=new ValuesController();

        [Fact]
        public void GetReurnMyName()
        {
            var returvalue=contoller.Get(1);
           
            Assert.Equal("JAI",returvalue.Value);
                
            
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
