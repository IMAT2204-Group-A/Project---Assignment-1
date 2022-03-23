using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCJMKLtd
{
    public class clsDVDGenreCollection
    {
        clsDataConnection dbConnection = new clsDataConnection();
        clsDVDGenre mThisDVDGenre = new clsDVDGenre();


        public clsDVDGenre ThisDVDGenre
        {
            get { return mThisDVDGenre; }
            set { mThisDVDGenre = value; }
        }


        public List<clsDVDGenre> DVDGenres
        {
            get
            {
                List<clsDVDGenre> mDVDGenreList = new List<clsDVDGenre>();
                Int32 Index = 0;
                while (Index < dbConnection.Count)
                {
                    clsDVDGenre newDVDGenre = new clsDVDGenre();
                    newDVDGenre.DVDID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["DVDID"]);
                    newDVDGenre.GenreID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["GenreID"]);
                    mDVDGenreList.Add(newDVDGenre);
                    Index++;
                }
                return mDVDGenreList;
            }
        }

        public Int32 Count
        {
            get
            {
                return dbConnection.Count;
            }
        }

        public Int32 Add()
        {

            /* Insert into [tblDVD]
            (DVDID,DVDName,DVDDescription,DVDDateOfRelease,DVDLength,DVDPrice,SupplierID,DVDImage)*/


            clsDataConnection NewDBDVDGenre = new clsDataConnection();
            //Gather all the parameters, to add new ones in the right places
            NewDBDVDGenre.AddParameter("@DVDID", mThisDVDGenre.DVDID);
            NewDBDVDGenre.AddParameter("@GenreID", mThisDVDGenre.GenreID);
            //Run the procedure in order to add the attributes to the database.
            return NewDBDVDGenre.Execute("sproc_tblDVDGenre_Insert");
        }
    }
}
