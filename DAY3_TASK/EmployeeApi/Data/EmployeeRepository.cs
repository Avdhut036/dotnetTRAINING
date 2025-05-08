using Dapper;
using EmployeeApi.Models;

namespace EmployeeApi.Data
{
    public class EmployeeRepository
    {
        private readonly DapperContext _context;

        public EmployeeRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            var query = "usp_GetAllEmployees";

            using var connection = _context.CreateConnection();
            var employees = await connection.QueryAsync<EmployeeDto>(query,
                commandType: System.Data.CommandType.StoredProcedure);
            return employees;
        }

    }
}
