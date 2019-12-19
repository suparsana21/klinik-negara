using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikBerseri
{
    class DoctorModel
    {
        private int id;
        private string name, address, phone, specialist;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Specialist
        {
            get
            {
                return specialist;
            }
            set
            {
                specialist = value;
            }
        }
    }
}
