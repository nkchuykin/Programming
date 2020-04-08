using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;

public class API
{

    List<ForecastEntry> data;

    public API()
    {
        using (FileStream fs = new FileStream("data.json", FileMode.Open))
        {
            var formatter = new DataContractJsonSerializer(typeof(List<ForecastEntry>));
            data = (List<ForecastEntry>)formatter.ReadObject(fs);
        }
    }

    public string Request(string request)
    {
        List<ForecastEntry> req = new List<ForecastEntry>(data);
        if (request.Contains("?"))
        {
            string[] inputs = request.Split('?')[1].Split('&');
            foreach (string param in inputs)
            {
                string[] cur = param.Split('=');
                switch (cur[0])
                {
                    case "city":
                        req = req.FindAll(x => x.city == cur[1]);
                        break;
                    case "temperature":
                        req = req.FindAll(x => x.temperature == int.Parse(cur[1]));
                        break;
                    case "pressure":
                        req = req.FindAll(x => x.pressure == int.Parse(cur[1]));
                        break;
                    case "isRaining":
                        req = req.FindAll(x => x.isRaining == bool.Parse(cur[1]));
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        string result;
        using (MemoryStream ms = new MemoryStream())
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<ForecastEntry>));
            formatter.WriteObject(ms, req);
            ms.Position = 0;
            using (StreamReader sr = new StreamReader(ms))
            {
                result = sr.ReadToEnd();
            }
        }
        return result;
    }

}

