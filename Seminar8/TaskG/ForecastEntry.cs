using System.Runtime.Serialization;

[DataContract]
public class ForecastEntry
{
    [DataMember]
    public int id;
    [DataMember]
    public string city;
    [DataMember]
    public int temperature;
    [DataMember]
    public int pressure;
    [DataMember]
    public bool isRaining;
    [DataMember]
    public double windSpeed;
}
