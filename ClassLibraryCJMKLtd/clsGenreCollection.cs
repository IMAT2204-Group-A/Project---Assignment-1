using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class clsGenreCollection
{
    clsDataConnection Genres = new clsDataConnection();

    public clsGenreCollection()
    {
        Genres.Execute("sproc_tblDVDGenre_SelectAll");
    }
    public Int32 Count
    {
        get
        {
            return Genres.Count;
        }
    }
  
    public List<clsGenre> clsGenres
    {
        get
        {
            List<clsGenre> mAllGenres = new List<clsGenre>();
            Int32 Index = 0;
            while (Index < Genres.Count)
            {
                clsGenre NewGenre = new clsGenre();
                NewGenre.GenreID = Convert.ToInt32(Genres.DataTable.Rows[Index]["GenreID"]);
                NewGenre.
            }
        }
    }
}
    

   
    

