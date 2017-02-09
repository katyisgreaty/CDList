using System.Collections.Generic;

namespace CdList.Objects
{
  public class Cd
  {
    private static List<Cd> _instances = new List<Cd> {};
    private string _title;
    private int _id;

    public Cd(string cdTitle)
    {
      _title = cdTitle;
      _instances.Add(this);
      _id = instances.Count;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
        _title = newTitle;
    }
    public int GetId()
    {
      return _id;
    }

    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Cd Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
