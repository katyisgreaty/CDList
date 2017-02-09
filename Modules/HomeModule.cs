using Nancy;
using Todo.Objects;
using System.Collections.Generic;

namespace CDList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/artists"] = _ => {
          var allArtists = Artist.GetAll();
          return View["artists.cshtml", allArtists];
      };
      Get["/artists_form"] = _ => {
          return View["artist_form.cshtml"];
      };
      Post["/artists"] = _ => {
          var newArtist = new Artist(Request.Form["artist-name"]);
          var allArtists = Artist.GetAll();
          return View["artists.cshtml", allArtists];
      };
      Get["artists/{id}"] = parameters => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          var selectedArtist = Artist.Find(parameters.id);
          var artistCds = selectedArtist.GetCds();
          model.Add("artists", selectedArtist);
          model.Add("cds", artistCds);
          return View["artist.cshtml", model];
      };
      Get["/artists/{id}/cds/new"] = parameters => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          Artist selectedArtist = Artist.Find(paramenters.id);
          List<Cd> 
      }
    }
  }
}
