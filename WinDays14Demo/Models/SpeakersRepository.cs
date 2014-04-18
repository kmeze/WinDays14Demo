using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;
using System.IO;

namespace WinDays14Demo.Models
{
    public class SpeakersRepository
    {
        public IList<Speaker> GetAllSpeakers() 
        {
            XDocument doc = XDocument.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Speakers.xml"));
            var speakers = doc.Descendants("speakers").Descendants("speaker")
                            .Select(speaker =>
                               new Speaker
                               {
                                   Id = Int32.Parse(speaker.Element("Id").Value),
                                   FirstName = speaker.Element("FirstName").Value,
                                   LastName = speaker.Element("LastName").Value
                               });

            return speakers.ToList();
        }
    }
}