using DesignPatterns.BuilderPattern.Method1;

namespace DesignPatterns.BuilderPattern.Method2
{
    public abstract class EmployeeBuilderM2 : IEmployeeBuilderM2
    {
        public EmployeeM2 employee { get; set; }
        public EmployeeBuilderM2()
        {
            employee = new EmployeeM2();
        }
        public abstract void SetFullName(string fullName);
        public abstract void SetEmailAdress(string emailAdress);
        public abstract void SetUserName(string userName);
        public EmployeeM2 BuildEmployee() => employee;
    }
}
