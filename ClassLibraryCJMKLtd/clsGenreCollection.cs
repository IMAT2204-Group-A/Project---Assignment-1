using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class clsGenreCollection
{
    clsDataConnection dbConnection = new clsDataConnection();
    clsGenre mThisGenre = new clsGenre();

    public clsGenre ThisGenre
    {
        get { return mThisGenre; }
        set { mThisGenre = value; }
    }
    public clsGenreCollection()
    {
        dbConnection.Execute("sproc_tblGenre_SelectAll");
    }

  
    public List<clsGenre> GenresList
    {
        get
        {
            List<clsGenre> mAllGenres = new List<clsGenre>();
            Int32 Index = 0;
            while (Index < dbConnection.Count)
            {
                clsGenre NewGenre = new clsGenre();
                NewGenre.GenreID = Convert.ToInt32(dbConnection.DataTable.Rows[Index][0]);
                NewGenre.GenreName = Convert.ToString(dbConnection.DataTable.Rows[Index][1]);
                mAllGenres.Add(NewGenre);
                Index++;
            }
            return mAllGenres;
        }
    }
    public Int32 Count
    {
        get
        {
            return dbConnection.Count;
        }
    }
    public void FilterByGenreName(string GenreName)
    {
        dbConnection = new clsDataConnection();
        dbConnection.AddParameter("@GenreName", GenreName);
        dbConnection.Execute("sproc_tblGenre_FilterByGenreName");
    }

    public void Update()
    {
        clsDataConnection ExistingDVDVD = new clsDataConnection();
        ExistingDVDVD.AddParameter("@GenreID", mThisGenre.GenreID);
        ExistingDVDVD.AddParameter("@GenreName", mThisGenre.GenreName);
        ExistingDVDVD.Execute("sproc_tblGenre_Update");
    }

    public Int32 Add()
    {
        clsDataConnection NewDBGenre = new clsDataConnection();

        NewDBGenre.AddParameter("@GenreName", ThisGenre.GenreName);
        return NewDBGenre.Execute("sproc_tblGenre_AddNew");
    }


    public Boolean Delete()
    {
        try
        {
            clsDataConnection MyDatabase = new clsDataConnection();
            MyDatabase.AddParameter("@GenreID", mThisGenre.GenreID);
            MyDatabase.Execute("sproc_tblGenre_Delete");
            return true;
        }
        catch
        {
            return false;
        }
    }
}
    

   
    

