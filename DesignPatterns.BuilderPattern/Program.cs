// See https://aka.ms/new-console-template for more information

using DesignPatterns.BuilderPattern.Method1;
using DesignPatterns.BuilderPattern.Method2;
using System.Text;

var sb = new StringBuilder();
sb.Append("Melih Ömer");
sb.Append(" Kamar");
var fullName = sb.ToString();

var eb = new EndpointBuilder("https://localhost");

eb.Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("userName","Salih");
var url = eb.Build();
Console.WriteLine("Final Url : " + url);

var builder = new EmployeeBuilderM1();

var employee =  builder.SetFullName("Melih Kamar")
    .SetUseNamel("kamar")
    .SetEmail("asdasfaf@gmail.com")
    .BuildEmployee();

Console.WriteLine(employee.FirstName +" "+ employee.LastName + " Email : "+employee.EmailAdress);

IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();
employeeBuilder.SetEmailAdress("melih@gmail.com");
employeeBuilder.SetFullName("melih ömer");
var emp = employeeBuilder.BuildEmployee();
Console.WriteLine("Employee mail adress : "+emp.EmailAdress);

EmployeeM2 GenerateEmployee(string fullName,string emailAdress,int empType)
{
    IEmployeeBuilderM2 employeBuilder;
    if(empType == 0)
        employeBuilder = new InternalEmployeeBuilder();
    else
        employeBuilder = new ExternalEmployeeBuilder();
    employeBuilder.SetFullName(fullName);
    employeBuilder .SetEmailAdress(emailAdress);

    return employeBuilder.BuildEmployee();
}

var _emp = GenerateEmployee("melih kamar", "kamar", 0);
Console.WriteLine(_emp.FirstName+" "+_emp.LastName+" "+_emp.EmailAdress);