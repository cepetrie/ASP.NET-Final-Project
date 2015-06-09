using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FanLoginService" in code, svc and config file together.
public class FanLoginService : IFanLoginService
{
    ShowTrackerEntities db = new ShowTrackerEntities();
    public Boolean registerFan(FanData f, FanLoginData fl)
    {
        try
        {
       

            PasswordHash hash = new PasswordHash();

            Fan fan = new Fan();
            FanLogin login = new FanLogin();

            Random rand = new Random();

            int key = rand.Next(9999999);

            fan.FanName = f.fanName;
            fan.FanEmail = f.fanEmail;
            fan.FanDateEntered = DateTime.Now;

            db.Fans.Add(fan);

            login.FanLoginUserName = fl.fanLoginUserName;
            login.FanLoginPasswordPlain = fl.fanLoginPlainPassword;
            login.FanLoginHashed = hash.HashIt(fl.fanLoginPlainPassword, key.ToString());
            login.FanLoginDateAdded = DateTime.Now;
            login.Fan = fan;
            login.FanLoginRandom = (int)key;

            db.FanLogins.Add(login);

            db.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public int loginFan(string username, string password)
    {
        LoginClass log = new LoginClass(username, password);
        int key = log.ValidateLogin();
        return key;
    }

    public List<ShowInfo> GetShowsByVenue(string venueName)
    {
        var shws = from s in db.Shows
                   from d in s.ShowDetails
                   where s.Venue.VenueName.Equals(venueName)
                   select new
                   {
                       d.Artist.ArtistName,
                       s.ShowName,
                       s.ShowTime,
                       s.ShowDate,
                       s.ShowTicketInfo
                   };
        
        List<ShowInfo> shows = new List<ShowInfo>();
        foreach (var sh in shws)
        {
            ShowInfo sInfo = new ShowInfo();
            sInfo.ArtistName = sh.ArtistName;
            sInfo.ShowName = sh.ShowName;
            sInfo.ShowDate = sh.ShowDate.ToShortDateString();
            sInfo.ShowTime = sh.ShowTime.ToString();
            shows.Add(sInfo);
        }

        return shows;
    }

    public List<ArtistInfo> GetShowsByArtist(string artistName)
    {
        var artists = from a in db.Shows
                      from d in a.ShowDetails
                      where d.Artist.ArtistName.Equals(artistName)
                      select new
                      {
                          d.Artist.ArtistName,
                          a.ShowName,
                          a.ShowTime,
                          a.ShowDate,
                          a.ShowTicketInfo
                      };

        List<ArtistInfo> artistList = new List<ArtistInfo>();
        foreach (var a in artists)
        {
            ArtistInfo aInfo = new ArtistInfo();
            aInfo.ArtistName = a.ArtistName;
            aInfo.ShowName = a.ShowName;
            aInfo.ShowTime = a.ShowTime.ToString();
            aInfo.ShowDate = a.ShowDate.ToShortDateString();
            artistList.Add(aInfo);
           
        }
        return artistList;
    }
}
