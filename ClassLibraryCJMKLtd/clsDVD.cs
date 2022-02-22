using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    [Serializable()]
    public class clsDVD : IComparable
    {

        protected int dvdid;
        protected string dvdname;
        protected string dvddescription;
        protected DateTime dvddateofrelease;
        protected int dvdlenght;
        protected int supplierid;
        protected string dvdimage;

        public clsDVD(int dvdID, string dvdName, string dvdDescription, DateTime dvdDateofrelease, int dvdLenght, int supplierID, string dvdImage)
        {
            this.dvdid = dvdID;
            this.dvdname = dvdName;
            this.dvddescription = dvdDescription;
            this.dvddateofrelease = dvdDateofrelease;
            this.dvdlenght = dvdLenght;
            this.supplierid = supplierID;
            this.dvdimage = dvdImage;
        }

        public int DVDID
        {
            get { return dvdid; }
            set { dvdid = value; }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }


}
