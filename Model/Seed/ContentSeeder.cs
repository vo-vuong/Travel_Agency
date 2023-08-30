using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Seed
{
    public class ContentSeeder
    {
        public static void Seed(Model.EF.TravelAgencyDbContext context)
        {
            context.CONTENTs.AddOrUpdate(
                content => content.ContentName,
                new CONTENT
                {
                    ContentName = "Top các địa điểm du lịch Nhật Bản đẹp.",
                    shortBody = "Danh sách các địa điểm du lịch Nhật Bản cực đẹp và nổi tiếng dưới đây hứa hẹn sẽ mang đến cho bạn thật nhiều trải nghiệm đáng nhớ khi ghé thăm đất nước mặt trời mọc xinh đẹp này!",
                    body = "1. Núi Phú Sĩ\r\nNúi Phú Sĩ vốn là biểu tượng của đất nước Nhật Bản, là địa điểm du lịch nổi tiếng hàng đầu mà bạn nhất định nên một lần đặt chân đến. Núi Phú Sĩ nằm cách trung tâm thủ đô Tokyo của Nhật Bản chỉ khoảng 100km và du khách hoàn toàn có thể di chuyển đến đây bằng xe buýt.\r\n\r\nNúi Phú Sĩ nổi bật với dạng hình nón được phủ đầy tuyết trắng xóa. Đây là một trong số 3 ngọn núi Thánh nổi tiếng tại Nhật Bản và đồng thời cũng chính là địa điểm hành hương quan trọng của những người theo Phật giáo và Thần đạo. Đến tham quan đỉnh núi Phú Sĩ trong hành trình du lich Nhat Ban, bạn sẽ có thể thỏa sức chiêm ngưỡng khung cảnh hùng vĩ và đắm chìm vào vẻ đẹp lãng mạn của ngọn núi xinh đẹp này.",
                    Image = "/Data/images/Seed/Content/nui_phu_si.jpg",
                    status = true,
                    views = 10,
                    dateShow = DateTime.Now
                },
                new CONTENT
                {
                    ContentName = "Khám phá địa điểm du lịch Lào Cai.",
                    shortBody = "Những phiên chợ vùng cao náo nhiệt, cảnh quan thiên nhiên núi rừng hùng vĩ và thơ mộng luôn là thứ hấp dẫn khách du lịch Lào Cai tìm đến khám phá.",
                    body = "Nếu đã quyết định đến du lịch Lào Cai, bạn nhất định phải một lần ghé qua SaPa để khám phá cảnh quan tuyệt đẹp nơi đây. Mặc dù đã trải qua rất nhiều năm tháng hình thành, thủ phủ sương mù này vẫn luôn giữ được vẻ đẹp quyến rũ vẹn nguyên như thuở ban đầu khiến bao người mê mẩn.\r\n\r\nTọa lạc tại độ cao khoảng 1500m - 1800m so với mực nước biển, thị trấn SaPa vừa sở hữu hệ thống rừng nguyên sinh hoang dã lại có thêm những công trình du lịch hiện đại. Đến du lịch Sapa, bạn có thể khám phá khung cảnh thiên nhiên tuyệt vời, được tham quan những bản làng cổ xưa quyến rũ và check in thật nhiều địa điểm du lịch đặc sắc tại thành phố sương mù vô cùng nổi tiếng này.",
                    Image = "/Data/images/Seed/Content/lao_cai.jpg",
                    status = true,
                    views = 11,
                    dateShow = DateTime.Now
                },
                new CONTENT
                {
                    ContentName = "Top những địa điểm du lịch Khánh Hòa.",
                    shortBody = "Đến tham quan du lịch Khánh Hòa thì du khách sẽ có vô vàn sự lựa chọn các điểm đến hấp dẫn dành cho mình. Mỗi địa điểm khác nhau đều có cho mình sự hấp dẫn riêng đối với từng du khách.",
                    body = "Khánh Hòa là một trong những tỉnh ven biển đẹp nhất Việt Nam với những bãi biển trải dài, nước biển trong xanh và không khí trong lành. Việc tìm kiếm các địa điểm du lịch Khánh Hòa là nhu cầu của các tín đồ mê du lịch. Ngoài các địa điểm du lịch Nha Trang, bạn còn có thể khám phá những địa điểm du lịch khác như đảo Bình Ba, đảo Yến, khu du lịch Tháp Bà Ponagar, Vạn Phúc, Hòn Chồng, chùa Long Sơn và rất nhiều địa điểm khác nữa. Hãy cùng Du Lịch Việt lưu lại Top các địa điểm du lịch hấp dẫn tại Khánh Hòa mà du khách không thể nào bỏ qua khi đặt chân đến đây nhé!",
                    Image = "/Data/images/Seed/Content/khanh_hoa.jpg",
                    status = true,
                    views = 12,
                    dateShow = DateTime.Now
                }
            );
        }
    }
}
