using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    public class clsSupplier
    {
        private Int32 supplierID;

        public Int32 SupplierID
        {
            get { return supplierID;}

            set { supplierID = value; }

        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }

            set { companyName = value; }

        }

        private string address;

        public string Address
        {
            get { return address; }

            set { address = value; }

        }

        private string phonenumber;

        public string PhoneNumber
        {
            get { return phonenumber; }

            set { phonenumber = value; }

        }

        private string postcode;

        public string PostCode
        {
            get { return postcode; }

            set { postcode = value; }

        }

        private string city;

        public string City
        {
            get { return city; }

            set { city = value; }

        }
    }



}
