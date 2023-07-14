using Dapper;
using Kodee.One.Models.AppointmentsTypes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Kodee.Models.AppointmentsTypes
{
    /// <summary>
    /// AppointmentsTypeRepository 클래스는 IAppointmentsTypeRepository 인터페이스를 구현하여 예약 종류 관련 데이터 액세스 작업을 처리합니다.
    /// </summary>
    public class AppointmentsTypeRepository : IAppointmentsTypeRepository
    {
        private readonly string _connectionString;

        /// <summary>
        /// AppointmentsTypeRepository 클래스의 생성자입니다. 데이터베이스 연결 문자열을 전달받습니다.
        /// </summary>
        /// <param name="connectionString">데이터베이스 연결 문자열입니다.</param>
        public AppointmentsTypeRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        private IDbConnection Connection => new SqlConnection(_connectionString);

        /// <inheritdoc/>
        public async Task<IEnumerable<AppointmentsType>> GetAllAsync()
        {
            using (var connection = Connection)
            {
                const string query = "SELECT * FROM AppointmentsTypes";
                return await connection.QueryAsync<AppointmentsType>(query);
            }
        }

        /// <inheritdoc/>
        public async Task<AppointmentsType> GetByIdAsync(int id)
        {
            using (var connection = Connection)
            {
                const string query = "SELECT * FROM AppointmentsTypes WHERE Id = @Id";
                return await connection.QuerySingleOrDefaultAsync<AppointmentsType>(query, new { Id = id });
            }
        }

        /// <inheritdoc/>
        public async Task<bool> AddAsync(AppointmentsType model)
        {
            using (var connection = Connection)
            {
                const string query = "INSERT INTO AppointmentsTypes (AppointmentTypeName, IsActive, DateCreated) VALUES (@AppointmentTypeName, @IsActive, @DateCreated)";
                return await connection.ExecuteAsync(query, model) > 0;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateAsync(AppointmentsType model)
        {
            using (var connection = Connection)
            {
                const string query = "UPDATE AppointmentsTypes SET AppointmentTypeName = @AppointmentTypeName, IsActive = @IsActive WHERE Id = @Id";
                return await connection.ExecuteAsync(query, model) > 0;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteAsync(int id)
        {
            using (var connection = Connection)
            {
                const string query = "DELETE FROM AppointmentsTypes WHERE Id = @Id";
                return await connection.ExecuteAsync(query, new { Id = id }) > 0;
            }
        }
    }
}
