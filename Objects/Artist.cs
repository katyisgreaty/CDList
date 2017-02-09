using System.Collections.Generic;

namespace CdList.Objects
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<Cd> _cds;

    public Artist(string cdName)
    {
      _name = cdName;
      _instances.Add(this);
      _id = _instances.Count;
      _artists = new List<Artist>{};
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
