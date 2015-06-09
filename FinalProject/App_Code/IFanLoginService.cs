using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFanLoginService" in both code and config file together.
[ServiceContract]
public interface IFanLoginService
{
	[OperationContract]
    Boolean registerFan(FanData f, FanLoginData fl);

    [OperationContract]
    int loginFan(string username, string password);

    [OperationContract]
    List<ShowInfo> GetShowsByVenue(string venueName);

    [OperationContract]
    List<ArtistInfo> GetShowsByArtist(string artistName);
}


[DataContract]
public class FanData
{
    [DataMember]
    public string fanName { get; set; }

    [DataMember]
    public string fanEmail { get; set; }
}

[DataContract]
public class FanLoginData
{
    [DataMember]
    public string fanLoginUserName { get; set; }

    [DataMember]
    public string fanLoginPlainPassword { set; get; }
}

[DataContract]
public class ShowInfo
{
    [DataMember]
    public string ArtistName { get; set; }
    [DataMember]
    public string ShowName { get; set; }
    [DataMember]
    public string ShowDate { get; set; }
    [DataMember]
    public string ShowTime { get; set; }

    [DataMember]
    public string TicketInfo { get; set; }
}

[DataContract]
public class ArtistInfo
{
    [DataMember]
    public string ArtistName { get; set; }
    [DataMember]
    public string ShowName { get; set; }
    [DataMember]
    public string ShowDate { get; set; }

    [DataMember]
    public string ShowTime { get; set; }

    [DataMember]
    public string TicketInfo { get; set; }
    
}

