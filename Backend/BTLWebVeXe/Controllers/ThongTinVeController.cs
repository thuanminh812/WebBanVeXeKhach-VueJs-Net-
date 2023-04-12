using BTLWebVeXe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTLWebVeXe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongTinVeController : ControllerBase
    {
        public List<ThongTinVe> thongTinVes = new List<ThongTinVe>();
        DatabaseQLyVeXeContext xeContext = new DatabaseQLyVeXeContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(xeContext.ThongTinVes.ToList());
        }
        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName(Guid name)
        {
            var Name = xeContext.ThongTinVes.FirstOrDefault(x => x.MaVe == name);
            return Ok(Name);
        }
        [HttpPost]
        public IActionResult Create(ThongTinVe thongTinVe)
        {
            if (thongTinVe == null)
            {
                return BadRequest();
            }
            xeContext.ThongTinVes.Add(thongTinVe);
            xeContext.SaveChanges();
            return Ok(thongTinVe);
        }
        [HttpPut]
        [Route("{name}")]
        public IActionResult Update(Guid name, ThongTinVe thongTinVe)
        {
            var Name = xeContext.ThongTinVes.FirstOrDefault(x => x.MaVe == name);
            if(thongTinVe == null)
            {
                return BadRequest();
            }
            Name.MaVe = thongTinVe.MaVe;
            Name.TenKh = thongTinVe.TenKh;
            Name.SoDt = thongTinVe.SoDt;
            Name.Tuyen = thongTinVe.Tuyen;
            Name.ThoiGian = thongTinVe.ThoiGian;
            Name.LoaiVe = thongTinVe.LoaiVe;
            xeContext.ThongTinVes.Update(Name);
            xeContext.SaveChanges();
            return Ok(xeContext.ThongTinVes.ToList());
        }
        [HttpDelete]
        [Route("{name}")]
        public IActionResult Delete(Guid name)
        {
            var Name = xeContext.ThongTinVes.FirstOrDefault(x => x.MaVe == name);
            if (Name == null)
            {
                return BadRequest();
            }
            xeContext.ThongTinVes.Remove(Name);
            xeContext.SaveChanges();
            return Ok(Name);
        }

    }
}
