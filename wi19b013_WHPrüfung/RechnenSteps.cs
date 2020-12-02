using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b013_WHPrüfung
{
    [Binding]
    public class RechnenSteps
    {
        int number, number2, result;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            number = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            number2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = number + number2;
        }
        
        [When(@"the second number is substracted from the first number")]
        public void WhenTheSecondNumberIsSubstractedFromTheFirstNumber()
        {
            result = number - number2;
        }
        
        [When(@"the two numbers are multiplicated")]
        public void WhenTheTwoNumbersAreMultiplicated()
        {
            result = number * number2;
        }
        
        [When(@"the first number is divided by the second number")]
        public void WhenTheFirstNumberIsDividedByTheSecondNumber()
        {
            result = number / number2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            int expected = p0;
            int actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
