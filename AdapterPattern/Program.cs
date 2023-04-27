using AdapterPattern.Core;
using System.Text;
using System.Text.Json;

var payRollCalulatorUrl = "https://localhost:7095/PayrollCalculator";
var reader = new EmployeesDataReader();
var employees = reader.GetEmployees();

var client = new HttpClient();
foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, payRollCalulatorUrl);
    var employeeAdapter = new PayrollSystemEmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");

    var response = await client.SendAsync(request);
    var responseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJson);
    Console.WriteLine($"Salary for employee `{employee.fullName}` as of today = {salary}");
}
Console.ReadKey();