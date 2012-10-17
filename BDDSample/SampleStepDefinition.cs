using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDSample
{
    [Binding]
    public class SampleStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            var calc = (Calc) ScenarioContext.Current["calc"];
            calc.EnterValue(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            var calc = (Calc)ScenarioContext.Current["calc"];
            calc.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            var calc = (Calc)ScenarioContext.Current["calc"];
            Assert.That(calc.GetResult(), Is.EqualTo(result));
        }
    }
}
