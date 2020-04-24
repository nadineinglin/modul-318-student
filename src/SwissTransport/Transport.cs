﻿using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            query = System.Uri.EscapeDataString(query);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id, DateTime date)
        {
            station = System.Uri.EscapeDataString(station);
            id = System.Uri.EscapeDataString(id);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&id=" + id + "&date" + date);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStation, DateTime date)
        {
            fromStation = System.Uri.EscapeDataString(fromStation);
            toStation = System.Uri.EscapeDataString(toStation);
            string datestring = date.ToString("yyyy-MM-dd");
            string timestring = date.ToString("hh:mm");
        //    string datestring = System.Uri.EscapeDataString(date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString());
         //   string timestring = System.Uri.EscapeDataString(date.Hour.ToString() + ":" + date.Minute.ToString());

            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation + "&date=" + datestring + "&time="+timestring);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            throw new NotImplementedException();
        }
    }
}
