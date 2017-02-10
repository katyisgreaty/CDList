using Nancy;
using CdList.Objects;
using System.Collections.Generic;

namespace CdList
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
      Get["/artist_form"] = _ => {
          return View["artist_form.cshtml"];
      };
      Post["/artists"] = _ => {
          var newArtist = new Artist(Request.Form["artist-name"]);
          var allArtists = Artist.GetAll();
          return View["artists.cshtml", allArtists];
      };
      Get["/artists/{id}"] = parameters => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          var selectedArtist = Artist.Find(parameters.id);
          var artistCds = selectedArtist.GetCds();
          model.Add("artist", selectedArtist);
          model.Add("cds", artistCds);
          return View["artist.cshtml", model];
      };
      Get["/artists/{id}/cds/new"] = parameters => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          Artist selectedArtist = Artist.Find(parameters.id);
          List<Cd> allCds = selectedArtist.GetCds();
          model.Add("artist", selectedArtist);
          model.Add("cds", allCds);
          return View["artist_cds_form.cshtml", model];
      };
      Post["/cds"] = _ => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          Artist selectedArtist = Artist.Find(Request.Form["artist-id"]);
          List<Cd> artistCds = selectedArtist.GetCds();
          string cdTitle = Request.Form["cd-title"];
          Cd newCd = new Cd(cdTitle);
          artistCds.Add(newCd);
          model.Add("cds", artistCds);
          model.Add("artist", selectedArtist);
          return View["artist.cshtml", model];
      };
      Get["/artist_cds_form"] = _ => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          var selectedArtist = Artist.Find(parameters.id);
          model.Add("artist", selectedArtist);
          return View["artist_cds_form.cshtml"];
      };

    }
  }
}
