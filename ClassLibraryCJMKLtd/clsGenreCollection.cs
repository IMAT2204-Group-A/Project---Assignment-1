using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class clsGenreCollection
{
    clsDataConnection dbConnection = new clsDataConnection();

    public clsGenreCollection()
    {
        dbConnection.Execute("sproc_tblDVDGenre_SelectAll");
    }
    public Int32 Count
    {
        get
        {
            return dbConnection.Count;
        }
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

    public void FilterByGenreName(string GenreName)
    {
        dbConnection = new clsDataConnection();
        dbConnection.AddParameter("@GenreName", GenreName);
        dbConnection.Execute("sproc_tblGenre_FilterByGenreName");
    }
}
    

   
    

