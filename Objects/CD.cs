using System.Collections.Generic;

namespace CdList.Objects
{
  public class Cd
  {
    private static List<Cd> _instances = new List<Cd> {};
    private string _title;
    private string _artist;
    private int _year;
    private int _id;
    private List<Cd> _cds;

    public Cd(string cdTitle, string cdArtist, int cdYear)
    {
      _title = cdTitle;
      _artist = cdArtist;
      _year = cdYear;
      _instances.Add(this);
      _id = instances.Count;
      _cds = new List<Cd>{};
    }

    public string GetTitle()
    {
      return _title;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public int GetYear()
    {
      return _year;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Cd> GetCds()
    {
      return _cds;
    }
    public void AddCd(Cd cd)
    {
      cds.Add(cd);
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Cd Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
