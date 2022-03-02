using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class clsDVDCollection
{
    //create the connection to the data connection class
    clsDataConnection dbConnection = new clsDataConnection();
    //Create connection to the clsDVD class to gather the attributes.
    clsDVD mThisDVD = new clsDVD();


    //Getter and Setter for class DVD
    public clsDVD ThisDVD
    {
        get { return mThisDVD; }
        set { mThisDVD = value; }
    }
    //Method to get all the DVDs in the list.
    public List<clsDVD> DVDs
    {
        get
        {
            List<clsDVD> mDVDList = new List<clsDVD>();
            Int32 Index = 0;
            while (Index < dbConnection.Count)
            {
                clsDVD NewDVD = new clsDVD();
                NewDVD.DVDID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["DVDID"]);
                NewDVD.DVDName = Convert.ToString(dbConnection.DataTable.Rows[Index]["DVDname"]);
                NewDVD.DVDDescription = Convert.ToString(dbConnection.DataTable.Rows[Index]["DVDDescription"]);
                NewDVD.DVDDateOfRelease = Convert.ToDateTime(dbConnection.DataTable.Rows[Index]["DVDDateOfRelease"]);
                NewDVD.DVDLength = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["DVDLength"]);
                NewDVD.DVDPrice = Convert.ToDecimal(dbConnection.DataTable.Rows[Index]["DVDPrice"]);
                NewDVD.SupplierID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["SupplierID"]);
                NewDVD.DVDImage = Convert.ToString(dbConnection.DataTable.Rows[Index]["DVDImage"]);
                mDVDList.Add(NewDVD);
                Index++;
            }
            return mDVDList;
        }
    }
    //Method to count the data rows
    public Int32 Count
    {
        get
        {
            return dbConnection.Count;
        }
    }

    //Add method
    public Int32 Add()
    {

        /* Insert into [tblDVD]
        (DVDID,DVDName,DVDDescription,DVDDateOfRelease,DVDLength,DVDPrice,SupplierID,DVDImage)*/


        clsDataConnection NewDBDVD = new clsDataConnection();
        //Gather all the parameters, to add new ones in the right places
        NewDBDVD.AddParameter("@DVDName", ThisDVD.DVDName);
        NewDBDVD.AddParameter("@DVDDescription", ThisDVD.DVDDescription);
        NewDBDVD.AddParameter("@DVDDateOfRelease", ThisDVD.DVDDateOfRelease);
        NewDBDVD.AddParameter("@DVDLength", ThisDVD.DVDLength);
        NewDBDVD.AddParameter("@DVDPrice", ThisDVD.DVDPrice);
        NewDBDVD.AddParameter("@SupplierID", ThisDVD.SupplierID);
        NewDBDVD.AddParameter("@DVDImage", ThisDVD.DVDImage);
        //Run the procedure in order to add the attributes to the database.
        return NewDBDVD.Execute("sproc_tblDVD_Insert");

    }
    //Method to update available data in the database.
    public void Update()
    {
        clsDataConnection ExistingDBDVD = new clsDataConnection();
        //Gather all the attributes
        ExistingDBDVD.AddParameter("@DVDID", mThisDVD.DVDID);
        ExistingDBDVD.AddParameter("@DVDName", mThisDVD.DVDName);
        ExistingDBDVD.AddParameter("@DVDDateOfRelease", mThisDVD.DVDDateOfRelease);
        ExistingDBDVD.AddParameter("@DVDLenght", mThisDVD.DVDLength);
        ExistingDBDVD.AddParameter("@DVDPrice", mThisDVD.DVDPrice);
        ExistingDBDVD.AddParameter("@SupplierID", mThisDVD.SupplierID);
        ExistingDBDVD.AddParameter("@DVDImage", mThisDVD.DVDImage);
        //Execute the procedure where it will look for given DVDID and exchange the data.
        ExistingDBDVD.Execute("sproc_tblDVD_Update");
    }


    public Boolean Delete()
    {
        try
        {
            clsDataConnection MyDatabase = new clsDataConnection();
            MyDatabase.AddParameter("@DVDID", mThisDVD.DVDID);
            MyDatabase.Execute("sproc_tblFilm_Delete");
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public void FilterByGenre(int genreId)
    {
        

            dbConnection = new clsDataConnection();
            dbConnection.AddParameter("@GenreId", genreId);
            dbConnection.Execute("sproc_tblDVD_FilterByGenreId");
    }

    public void GetAll()
    {


        dbConnection = new clsDataConnection();
        dbConnection.Execute("sproc_tblDVD_SelectAll");
    }


}


