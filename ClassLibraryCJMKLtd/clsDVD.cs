using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable()]
public class clsDVD : IComparable
{

    protected int dvdid;
    protected string dvdname;
    protected string dvddescription;
    protected DateTime dvddateofrelease;
    protected int dvdlength;
    protected decimal dvdprice;
    protected int supplierid;
    protected string dvdimage;


    public int DVDID
    {
        get { return dvdid; }
        set { dvdid = value; }
    }

    public string DVDName
    {
        get { return dvdname; }
        set { dvdname = value; }
    }
    public string DVDDescription
    {
        get { return dvddescription; }
        set { dvddescription = value; }
    }
    public DateTime DVDDateOfRelease
    {
        get { return dvddateofrelease; }
        set { dvddateofrelease = value; }
    }

    public int DVDLength
    {
        get { return dvdlength; }
        set { dvdlength = value; }
    }
    public decimal DVDPrice
    {
        get { return dvdprice; }
        set { dvdprice = value; }
    }
    public int SupplierID
    {
        get { return supplierid; }
        set { supplierid = value; }
    }
    public string DVDImage
    {
        get { return dvdimage; }
        set { dvdimage = value; }
    }
    public string FilmValid(string DVDName,
                             string DVDDescription,
                             DateTime DVDDateOfRelease,
                             int DVDLenght,
                             decimal DVDPrice,
                             Int32 SupplierID,
                             string DVDImage)
    {
        string ErrorMessage = "";
        if (DVDName.Length == 0)
        {
            ErrorMessage = ErrorMessage + "Name of the movie cannot be empty!";
        }
        if (ErrorMessage == "")
        {
            return "";
        }
        else
        {
            return "There were the following errors: " + ErrorMessage;
        }
    }
    public int CompareTo(object obj)
    {
        throw new NotImplementedException();
    }

    
    public Int32 Find(Int32 DVDID)
    {
        clsDataConnection dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@DVDID", DVDID);
        dBConnection.Execute("sproc_tblDVD_FilterByDVDID");
        if (dBConnection.Count == 1)
        {
            dvdid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["@DVDID"]);
            dvdname = Convert.ToString(dBConnection.DataTable.Rows[0]["@DVDName"]);
            dvddateofrelease = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["@DVDDateOfRelease"]);
            dvdlength = Convert.ToInt32(dBConnection.DataTable.Rows[0]["@DVDLenght"]);
            dvdprice = Convert.ToDecimal(dBConnection.DataTable.Rows[0]["@DVDPrice"]);
            supplierid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["@SupplierID"]);
            dvdimage = Convert.ToString(dBConnection.DataTable.Rows[0]["@DVDImage"]);
        }
        return DVDID;

    }


}


