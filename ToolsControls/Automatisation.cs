using System;
using System.Configuration;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;


namespace Hebreux11AppServer.ToolsControls
{
    public class Automatisation
    {
        private static string Date = DateTime.UtcNow.ToString("yyyy-MM-dd");
        public static async Task XmlDocAsync()
        {

            XNamespace ns = "http://www.sitemaps.org/schemas/sitemap/0.9";

            var urlset = new XElement(ns + "urlset",
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "1.0")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/Apps"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/Photos"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/Videos"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/Formations"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/IT"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Evenements/Events"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/Quotation"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               ),
               new XElement(ns + "url",
                   new XElement(ns + "loc", "https://www.hebreux11.com/Services/Tarif"),
                   new XElement(ns + "lastmod", Date),
                   new XElement(ns + "changefreq", "weekly"),
                   new XElement(ns + "priority", "0.8")
               )
           );

            var doc = new XDocument(
                new XDeclaration("1.0", "UTF-8", null),
                urlset
            );

            // Écrit le fichier sitemap.xml dans le dossier courant
            doc.Save("wwwroot/sitemap.xml");

        }
        public static void XmlDoc()
        {

            XNamespace ns = "http://www.sitemaps.org/schemas/sitemap/0.9";

            var urlset = new XElement(ns + "urlset",
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "1.0")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/Apps"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/Photos"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/Videos"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/Formations"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/IT"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Evenements/Events"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/Quotation"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                ),
                new XElement(ns + "url",
                    new XElement(ns + "loc", "https://www.hebreux11.com/Services/Tarif"),
                    new XElement(ns + "lastmod", Date),
                    new XElement(ns + "changefreq", "weekly"),
                    new XElement(ns + "priority", "0.8")
                )
            );

            var doc = new XDocument(
                new XDeclaration("1.0", "UTF-8", null),
                urlset
            );

            using var sw = new StringWriter();
            using var xw = XmlWriter.Create(sw, new XmlWriterSettings { Encoding = Encoding.UTF8 });
            doc.WriteTo(xw);
            xw.Flush();
            // return Results.Content(sw.ToString(), "application/xml");


            // Écrit le fichier sitemap.xml dans le dossier courant
            doc.Save("wwwroot/sitemap.xml");
        }

    }

}
