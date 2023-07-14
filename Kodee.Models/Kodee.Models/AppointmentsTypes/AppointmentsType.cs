using System;

namespace Kodee.Models.AppointmentsTypes
{
    /// <summary>
    /// AppointmentType 모델 클래스는 예약 종류를 나타냅니다.
    /// </summary>
    public class AppointmentsType
    {
        /// <summary>
        /// 예약 종류의 고유 ID입니다.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 예약 종류의 이름을 나타냅니다. 예: "Scheduled", "Completed", "Canceled" 등
        /// </summary>
        public string AppointmentTypeName { get; set; } = "Scheduled";

        /// <summary>
        /// 예약 종류가 활성화되었는지 여부를 나타냅니다. 활성화된 경우 true, 아닌 경우 false입니다.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 예약 종류가 생성된 날짜 및 시간입니다.
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
