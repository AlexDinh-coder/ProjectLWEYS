using BusinessObject;
using LWEYS.Services.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LWEYS.Controllers
{
    public class StaffController : Controller
    {
        private readonly IOrderService _orderService;
        public async Task<IActionResult> ListService()
        {
            var res = await _orderService.GetAllService();
            ViewBag.ListService = res.DataList;
            return View();
        }

        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> GetService(int id)
        {
            var res = await _orderService.GetService(id);
            return Json(res.Data);
        }
    }
}
