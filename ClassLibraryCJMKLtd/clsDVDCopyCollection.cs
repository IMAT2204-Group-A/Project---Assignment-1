using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCJMKLtd;


public class clsDVDCopyCollection
{
    clsDataConnection dbConnection = new clsDataConnection();
    clsDVDCopy mThisDVDCopy = new clsDVDCopy();

    public clsDVDCopy thisDVDCopy
    {
        get { return mThisDVDCopy; }
        set { mThisDVDCopy = value; }
    }


    public clsDVDCopyCollection()
    {
        dbConnection.Execute("sproc_tblDVDCopy_SelectAll");
    }


    //List Creator
    public List<clsDVDCopy> DVDCopies
    {
        get
        {
            List<clsDVDCopy> mDVDCopyList = new List<clsDVDCopy>();
            Int32 Index = 0;
            while (Index < dbConnection.Count)
            {
                clsDVDCopy newDVDCopy = new clsDVDCopy();
                newDVDCopy.DVDCopyID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["DVDCopyID"]);
                newDVDCopy.DVDID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["DVDID"]);
                string condition_name = Convert.ToString(dbConnection.DataTable.Rows[Index]["Condition"]);
                if (condition_name == Convert.ToString(clsDVDCopy.Condition.poor))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.poor;
                }

                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.fair))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.fair;
                }

                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.good))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.fair;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.mint))
                {
                    newDVDCopy.Condition1 = clsDVDCopy.Condition.mint;
                }
                mDVDCopyList.Add(newDVDCopy);
                Index++;
            }
            return mDVDCopyList;
        }
    }



    public Int32 Count
    {
        get
        {
            return dbConnection.Count;
        }
    }


    // Methods, Add/Delete
    public int Add()
    {
        clsDataConnection NewDBDVDCopy = new clsDataConnection();

        NewDBDVDCopy.AddParameter("@DVDID", mThisDVDCopy.DVDID);
        NewDBDVDCopy.AddParameter("@Condition", mThisDVDCopy.Condition1);
        return NewDBDVDCopy.Execute("sproc_tblDVDCopy_Insert");
    }

    public void Update()
    {
        clsDataConnection ExistingDBDVD = new clsDataConnection();
        //Gather all the attributes
        ExistingDBDVD.AddParameter("@DVDCopyID", mThisDVDCopy.DVDCopyID);
        ExistingDBDVD.AddParameter("@DVDID", mThisDVDCopy.DVDID);
        ExistingDBDVD.AddParameter("@Condition", mThisDVDCopy.Condition1);
        //Execute the procedure where it will look for given DVDID and exchange the data.
        ExistingDBDVD.Execute("sproc_tblDVDCopy_Update");
    }

    public Boolean Delete()
    {
        try
        {
            clsDataConnection MyDatabase = new clsDataConnection();
            MyDatabase.AddParameter("@DVDCopyID", mThisDVDCopy.DVDCopyID);
            MyDatabase.Execute("sproc_tblDVDCopy_Delete");
            return true;
        }
        catch
        {
            return false;
        }
    }


}

