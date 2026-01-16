using Microsoft.AspNetCore.Mvc;
using Booking.Application.Interfaces;
using Booking.Application.DTOs;

namespace Booking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingsController(IBookingService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookingDto dto)
        {
            var Id = await _service.CreateAsync(dto);
            return Ok(Id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

    }
}
