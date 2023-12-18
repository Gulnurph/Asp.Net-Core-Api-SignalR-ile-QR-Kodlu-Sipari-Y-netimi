using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookingManager : IBookingServices
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Add(Booking entity)
        {
           _bookingDal.AddAsync(entity);
        }

        public void Delete(Booking entity)
        {
            _bookingDal.DeleteAsync(entity);
        }

        public List<Booking> GetAll()
        {
            var result= _bookingDal.GetAllAsync();
            return result.ToList();
        }

        public Booking GetById(int id)
        {
           return _bookingDal.GetById(id);
        }

        public void Update(Booking entity)
        {
            _bookingDal.UpdateAsync(entity);
        }
    }
}
