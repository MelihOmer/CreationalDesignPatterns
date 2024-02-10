namespace DesignPatterns.BuilderPattern.Method2
{
    internal class InternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEmailAdress(string emailAdress)
        {
            var arr = emailAdress.Split('@');
            employee.EmailAdress = arr[0] + "@company.com.tr";
        }

        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[] {' ','_','.'});
            employee.FirstName = arr[0];
            employee.LastName = arr[1];
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
