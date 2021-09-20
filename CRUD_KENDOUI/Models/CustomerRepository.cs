using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_KENDOUI.Models
{
    public class CustomerRepository
    {
        public List<CustomerModel> GetAllCustomer()
        {
            var customer = new List<CustomerModel>()
            {
                new CustomerModel{ Id = 1, Name = "Nguyễn Quốc Cường", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 2, Name = "Nguyễn Quốc Cường", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 3, Name = "Nguyễn Quốc Cường", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 4, Name = "Nguyễn Quốc Cường", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 5, Name = "Nguyễn Quốc Cường", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 6, Name = "Nguyễn Quốc Cường", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 7, Name = "Nguyễn Quốc Cường Duy", Address = "Thôn 8 xã Earal huyện Eahleo tỉnh Đak Lak", Phone = "0377077630"},
                new CustomerModel{ Id = 8, Name = "Nguyễn Quốc Cường Duy", Address = "Vãi Cả Đái", Phone = "0377077630"},
                new CustomerModel{ Id = 9, Name = "Cường Đẹp Trai", Address = "Vãi Cả Đái", Phone = "0377077630"},
                new CustomerModel{ Id = 10, Name = "Cường Đẹp Trai1", Address = "Vãi Cả Đái", Phone = "0377077630"},
                new CustomerModel{ Id = 11, Name = "Cường Đẹp Trai2", Address = "Vãi Cả Đái", Phone = "0377077630"},
            };
            return customer;
        }
    }
}
