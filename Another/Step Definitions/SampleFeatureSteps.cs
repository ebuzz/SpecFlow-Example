using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist; // Extension methods for Table class

namespace Another
{
    [Binding]
    class SampleFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            // ScenarioContext.Current.Pending();
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Add button pressed");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120) // Grab object which has value of 120
                Console.WriteLine("Passed");
            else
            {
                Console.WriteLine("Failed");
                throw new Exception("Wrong value");
            }
        }

        [When(@"i enter this numbers")]
        public void WhenIEnterThisNumbers(Table table)
        {
            IEnumerable<Employee> details = table.CreateSet<Employee>();


            foreach (Employee emp in details)
            {
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
            }
        }

        [When(@"i enter this details (.*) and (.*) and (.*)")]
        public void WhenIEnterThisDetailsErickAndAnd(string name, int age, int phone)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(phone);
        }

        [Given(@"I shall rull (.*) into the calculator")]
        public void GivenIShallRullIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
