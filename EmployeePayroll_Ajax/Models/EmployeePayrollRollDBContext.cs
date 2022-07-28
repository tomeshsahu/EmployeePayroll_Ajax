using Microsoft.EntityFrameworkCore;

namespace EmployeePayroll_Ajax.Models
{
    public class EmployeePayrollRollDBContext:DbContext
    {
        public EmployeePayrollRollDBContext(DbContextOptions<EmployeePayrollRollDBContext>Options):base(Options)
        {

        }
        public DbSet<EmployeeModel> Employee { get; set; }
    }
}
