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
    protected int dvdlenght;
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

    public int DVDLenght
    {
        get { return dvdlenght; }
        set { dvdlenght = value; }
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



    public Int32 Add(clsDVD NewDVD)
    {

        /* Insert into [tblDVD]
        (DVDID,DVDName,DVDDescription,DVDDateOfRelease,DVDLength,DVDPrice,SupplierID,DVDImage)*/


        clsDataConnection NewDBDVD = new clsDataConnection();
        //Gather all the parameters, to add new ones in the right places
        NewDBDVD.AddParameter("@DVDName", NewDVD.DVDName);
        NewDBDVD.AddParameter("@DVDDescription", NewDVD.DVDDescription);
        NewDBDVD.AddParameter("@DVDDateOfRelease", NewDVD.DVDDateOfRelease);
        NewDBDVD.AddParameter("@DVDLength", NewDVD.DVDLenght);
        NewDBDVD.AddParameter("@DVDPrice", NewDVD.DVDPrice);
        NewDBDVD.AddParameter("@SupplierID", NewDVD.SupplierID);
        NewDBDVD.AddParameter("@DVDImage", NewDVD.DVDImage);
        //Run the procedure in order to add the attributes to the database.
        return NewDBDVD.Execute("sproc_tblDVD_Insert");

    }


    //Method to update available data in the database.
    public void Update(clsDVD ExistingFilm)
    {
        clsDataConnection ExistingDBDVD = new clsDataConnection();
        //Gather all the attributes
        ExistingDBDVD.AddParameter("@DVDID", ExistingFilm.DVDID);
        ExistingDBDVD.AddParameter("@DVDName", ExistingFilm.DVDName);
        ExistingDBDVD.AddParameter("@DVDDateOfRelease", ExistingFilm.DVDDateOfRelease);
        ExistingDBDVD.AddParameter("@DVDLenght", ExistingFilm.DVDLenght);
        ExistingDBDVD.AddParameter("@DVDPrice", ExistingFilm.DVDPrice);
        ExistingDBDVD.AddParameter("@SupplierID", ExistingFilm.SupplierID);
        ExistingDBDVD.AddParameter("@DVDImage", ExistingFilm.DVDImage);
        //Execute the procedure where it will look for given DVDID and exchange the data.
        ExistingDBDVD.Execute("sproc_tblDVD_Update");
    }

    /*
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
            dvdlenght = Convert.ToInt32(dBConnection.DataTable.Rows[0]["@DVDLenght"]);
            dvdprice = Convert.ToDecimal(dBConnection.DataTable.Rows[0]["@DVDPrice"]);
            supplierid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["@SupplierID"]);
            dvdimage = Convert.ToString(dBConnection.DataTable.Rows[0]["@DVDImage"]);

            try
            {
                dvdid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["@DVDID"]);
            }
            finally
            {

            }
            return DVDID;


        }
    }
    */

}


