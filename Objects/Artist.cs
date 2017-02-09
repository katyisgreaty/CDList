using System.Collections.Generic;

namespace CdList.Objects
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<Cd> _cds;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _cds = new List<Cd>{};
    }
    public string GetName()
    {
      return _name;
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
      _cds.Add(cd);
    }
    public static List<Artist> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
