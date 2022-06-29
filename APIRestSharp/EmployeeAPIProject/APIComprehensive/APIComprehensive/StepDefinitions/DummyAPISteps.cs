using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using APIComprehensive.CommonMethodObjects;
using TechTalk.SpecFlow.Assist;

namespace APIComprehensive.StepDefinition
{
    [Binding]
    public class DummyAPISteps
    {
        DummyAPIObjects obj = new DummyAPIObjects();

        [When(@"User enters the valid Url and the valid body for the POST request")]
        public void WhenUserEntersTheValidUrlAndTheValidBodyForThePOSTRequest()
        {
            obj.CreateEmployeePOSTRequest();
        }

        [Then(@"User should be able to create new Employee")]
        public void ThenUserShouldBeAbleToCreateNewEmployee()
        {
            obj.VerifyCreateEmployeePostResult();
        }

        [When(@"User enters the valid Url for the GET request")]
        public void WhenUserEntersTheValidUrlForTheGETRequest()
        {
            obj.GetSpecificEmployee();
        }

        [Then(@"User should be able to view the newly created Employee")]
        public void ThenUserShouldBeAbleToViewTheNewlyCreatedEmployee()
        {
            obj.VerifyGetEmployee();
        }

        [When(@"User enters the valid Url for the GET request for Employee List Table")]
        public void WhenUserEntersTheValidUrlForTheGETRequestForEmployeeListTable(Table table)
        {
            var datas = table.CreateDynamicSet();

            foreach (var item in datas)
            {
                obj.url = item.Url;
            }
            obj.GetEmployeeList();
        }


        [Then(@"User should be able to view all Employees detail")]
        public void ThenUserShouldBeAbleToViewAllEmployeesDetail()
        {
            obj.VerifyGetEmployeeListResult();
        }

        [When(@"User enters the valid Url for the DELETE request")]
        public void WhenUserEntersTheValidUrlForTheDELETERequest()
        {
            obj.DeleteCreatedEmployee();
        }

        [Then(@"User should be able to delete newly created Employee")]
        public void ThenUserShouldBeAbleToDeleteNewlyCreatedEmployee()
        {
            obj.VerifyEmployeeDeleted();
        }
    }
}
