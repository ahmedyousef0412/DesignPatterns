


using Adapter_Pattern.Core;
using System.Text;
using System.Text.Json;

var payrollCalcualatorUrl = "https://localhost:7026/api/PayrollCalculator";

var reader = new EmployeeDataReader();

var employees = reader.GetEmployees();  


var client = new HttpClient();

foreach (var employee in employees)
{

    var employeeAdapter = new PayrollSystemEmployeeAdapter(employee);

    var request = new HttpRequestMessage(HttpMethod.Post, payrollCalcualatorUrl)
    {
        Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json")
    };

    var response = client.SendAsync(request).Result;

    var responseJson = await response.Content.ReadAsStringAsync();

    var salary= decimal.Parse(responseJson);

    Console.WriteLine($"Salary for employee : {employee.FullName} as of today is :{salary}");


}
Console.ReadKey();  