using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCJMKLtd;

public class clsGenre
{
    private int genreid;
    private string genrename;



    public int GenreID
    {
        get { return genreid; }
        set { genreid = value; }
    }
    public string GenreName
    {
        get { return genrename; }
        set { genrename = value; }
    }

    public string GenreValid(string GenreName)
    {
        String ErrorMessage = "";
        //GenreName = less than 5, more than 25
        if (GenreName.Length < 5)
        {
            ErrorMessage = ErrorMessage + "The Name of the Genre Cannot be less than 5 characters";
        }
        else if (GenreName.Length > 25)
        {
            ErrorMessage = ErrorMessage + " The name of the Genre Cannot exceed 25 characters";
        }
        if (ErrorMessage == "")
        {
            return "";
        }
        else
        {
            return "There were the following Errors: " + ErrorMessage;
        }
    }
    public bool Find(int genreID)
    {
        clsDataConnection dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@GenreID", genreID);
        dBConnection.Execute("sproc_tblGenre_FilterByGenreID");
        if (dBConnection.Count == 1)
        {
            genreid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["GenreID"]);
            genrename = Convert.ToString(dBConnection.DataTable.Rows[0]["GenreName"]);
            return true;
        }
        else
        {
            return false;
        }
    }
}

