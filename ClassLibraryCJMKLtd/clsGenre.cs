using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable()]
public class clsGenre
{
    protected int genreid;
    protected string genrename;


    public int GenreID
    {
        get { return genreid; }
        set { value = genreid; }
    }
    public string GenreName;

}

