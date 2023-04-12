using BTLWebVeXe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTLWebVeXe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        public List<KhachHang> khachHangs = new List<KhachHang>();
        DatabaseQLyVeXeContext xeContext = new DatabaseQLyVeXeContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(xeContext.KhachHangs.ToList());
        }
        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName(String name)
        {
            var Name = xeContext.KhachHangs.FirstOrDefault(x => x.HoTen == name);
            return Ok(Name);
        }
        [HttpPost]
        public IActionResult Create(KhachHang nhanVien)
        {
            if (nhanVien == null)
            {
                return BadRequest();
            }
            xeContext.KhachHangs.Add(nhanVien);
            xeContext.SaveChanges();
            return Ok(nhanVien);
        }
        [HttpPut]
        [Route("{name}")]
        public IActionResult Update(String name, KhachHang nhanVienUpdate)
        {
            var Name = xeContext.KhachHangs.FirstOrDefault(x => x.HoTen == name);
            if (Name == null)
            {
                return BadRequest();
            }
            Name.HoTen = nhanVienUpdate.HoTen;
            Name.DiaChi = nhanVienUpdate.DiaChi;
            xeContext.KhachHangs.Update(Name);
            xeContext.SaveChanges();
            return Ok(xeContext.KhachHangs.ToList());
        }
        [HttpDelete]
        [Route("{name}")]
        public IActionResult Delete(String name)
        {
            var Name = xeContext.KhachHangs.FirstOrDefault(x => x.HoTen == name);
            if (Name == null)
            {
                return BadRequest();
            }
            xeContext.KhachHangs.Remove(Name);
            xeContext.SaveChanges();
            return Ok();
        }


    }
}
