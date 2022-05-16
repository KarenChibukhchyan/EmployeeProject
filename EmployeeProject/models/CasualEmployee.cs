namespace EmployeeProject
{
    public class CasualEmployeeDetails : Employee, IEmployeeDetails
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