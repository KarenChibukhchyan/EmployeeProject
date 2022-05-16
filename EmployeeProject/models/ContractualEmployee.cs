namespace EmployeeProject
{
    public class ContractualEmployeeDetails : Employee, IEmployeeDetails
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return GetProjectDetails(employeeId);
        }

        string GetProjectDetails(int employeeId)
        {
            return "Contractual EmployeeProject's Project";
        }
    }
}