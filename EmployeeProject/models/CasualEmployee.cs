namespace EmployeeProject
{
    public class CasualEmployee : Employee, IEmployeeDetails
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return GetCasualEmployeeDetails(employeeId);
        }

        public string GetCasualEmployeeDetails(int employeeId)
        {
            return "Casual EmployeeProject's Details";
        }
    }
}