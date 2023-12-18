using BusinessLayer.Abstract;
using DtoLayer.BookingDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices)
        {
            _bookingServices = bookingServices;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
           var value= _bookingServices.GetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreatBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Date = DateTime.Now,
                Mail = createBookingDto.Mail,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,
            };
            _bookingServices.Add(booking);
            return Ok("Rezervasyon Yapıldı");

        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingServices.GetById(id);
            _bookingServices.Delete(value);
            return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult BookingUpdate(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                Date = DateTime.Now,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,

            };
            _bookingServices.Update(booking);
            return Ok("Güncellendi");
        }
    }
}
