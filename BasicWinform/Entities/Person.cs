using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    public class Person
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ngày sinh DOB = Date of Birth
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public EGioiTinh Sex{ get; set; }
        /// <summary>
        /// Quê quán
        /// </summary>
        public string HomeTown { get; set; } 

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }

        /// <summary>
        /// Lấy toàn bộ danh sách sinh viên trong CSDL
        /// (MockData)
        /// </summary>
        /// <returns>
        /// Danh sách sinh viên
        /// </returns>
        public static List<Person> GetList()
        {
            var ls = new List<Person>();
            ls.Add(new Person {
                Id = "1",
                FirstName = "Nguyễn", 
                LastName="Dũng",
                DOB = new DateTime(2000, 2,2),
                HomeTown = "Thừa Thiên Huế",
                Sex = EGioiTinh.Nam
            });
            ls.Add(new Person
            {
                Id = "2",
                FirstName = "Nguyễn",
                LastName = "Thị Thảo",
                DOB = new DateTime(2000, 5, 6),
                HomeTown = "Đà Nẵng",
                Sex = EGioiTinh.Nu
            });
            return ls;
        }
        /// <summary>
        /// Lấy một sinh viên từ CSDL
        /// </summary>
        /// <param name="id">Mã sinh viên cần lấy</param>
        /// <returns>
        /// Sinh viên có mã tương ứng hoặc null nếu không tìm thấy
        /// </returns>
        public static Person Get(string id)
        {
            var dbPerson = GetList();
            //Linq to SQL
            //Lamda expression
            var person = dbPerson.Where(p=>p.Id == id).FirstOrDefault();
            return person;
        }
        
    }
    public enum EGioiTinh
    {
        Nam, Nu, Khac
    }
}
