using DesignPatterns.BuilderPattern.Method1;

namespace DesignPatterns.BuilderPattern.Method2
{
    public interface IEmployeeBuilderM2
    {
        EmployeeM2 employee { get; set; }

        EmployeeM2 BuildEmployee();
        void SetEmailAdress(string emailAdress);
        void SetFullName(string fullName);
        void SetUserName(string userName);
    }
}