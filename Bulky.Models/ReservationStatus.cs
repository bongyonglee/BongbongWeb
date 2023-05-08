using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class ReservationStatus
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "이름을 입력하세요")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "핸드폰 번호를 입력해라")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "예약시간을 입력해라")]
        [Range(1, 24, ErrorMessage = "1부터 24까지의 숫자를 입력하숑")]
        public int ReservationTime { get; set; }

    }
}
