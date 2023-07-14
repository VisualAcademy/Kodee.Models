using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kodee.One.Models.AppointmentsTypes
{
    /// <summary>
    /// IAppointmentsTypeRepository 인터페이스는 예약 종류 관련 데이터 액세스 작업을 정의합니다.
    /// </summary>
    public interface IAppointmentsTypeRepository
    {
        /// <summary>
        /// 모든 예약 종류를 반환합니다.
        /// </summary>
        /// <returns>예약 종류 목록을 나타내는 비동기 작업</returns>
        Task<IEnumerable<AppointmentsType>> GetAllAsync();

        /// <summary>
        /// 지정된 ID에 해당하는 예약 종류를 반환합니다.
        /// </summary>
        /// <param name="id">검색할 예약 종류의 ID입니다.</param>
        /// <returns>예약 종류를 나타내는 비동기 작업</returns>
        Task<AppointmentsType> GetByIdAsync(int id);

        /// <summary>
        /// 새로운 예약 종류를 추가합니다.
        /// </summary>
        /// <param name="model">추가할 예약 종류를 나타내는 AppointmentsType 객체입니다.</param>
        /// <returns>작업이 성공적으로 완료되었는지 여부를 나타내는 비동기 작업</returns>
        Task<bool> AddAsync(AppointmentsType model);

        /// <summary>
        /// 지정된 예약 종류를 업데이트합니다.
        /// </summary>
        /// <param name="model">업데이트할 예약 종류를 나타내는 AppointmentsType 객체입니다.</param>
        /// <returns>작업이 성공적으로 완료되었는지 여부를 나타내는 비동기 작업</returns>
        Task<bool> UpdateAsync(AppointmentsType model);

        /// <summary>
        /// 지정된 ID에 해당하는 예약 종류를 삭제합니다.
        /// </summary>
        /// <param name="id">삭제할 예약 종류의 ID입니다.</param>
        /// <returns>작업이 성공적으로 완료되었는지 여부를 나타내는 비동기 작업</returns>
        Task<bool> DeleteAsync(int id);
    }
}
