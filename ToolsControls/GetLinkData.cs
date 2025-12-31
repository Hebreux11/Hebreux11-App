using System;
using System.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;


namespace Hebreux11AppServer.ToolsControls
{
    public class GetLinkData
    {
        static string FoldPData
        {
            get
            {
                Directory.CreateDirectory(Path.Combine(AppContext.BaseDirectory, "AllDatas"));
                return Path.Combine(AppContext.BaseDirectory, "AllDatas");
            }
        }
        private static string LienGeneral(string nomString)
        {
            var builder = WebApplication.CreateBuilder();
            var connectionString = builder.Configuration.GetConnectionString(nomString);
            return connectionString;
        }

        private static string LienUtility(string nomString)
        {
            var builder = WebApplication.CreateBuilder();
            var connectionString = builder.Configuration.GetSection(nomString);
            return connectionString.Value;
        }

        public static List<string> LienUtilityList()
        {
            var builder = WebApplication.CreateBuilder();
            var config = builder.Configuration.GetChildren();
            List<string> output = new List<string>();
            foreach (var elment in config)
            {
                output.Add($"{elment.Key} {elment.Value}");
            }
            return output;
        }

        public static string ConMySQL
        {
            get
            {
                return LienUtility("LocalConMySQL"); //Development
                // return LienGeneral("ConMySQL"); //Production
            }
        }


        public static string FileStorage
        {
            get
            {
                return LienUtility("FileStorage");
            }
        }

        public static string WebStorageRoot
        {
            get
            {
                return LienUtility("WebStorageRoot");

            }
        }

        public static string DefaultCardID
        {
            get
            {
                return LienUtility("DefaultCardID");
            }
        }


        public static string FichierClient
        {
            get
            {
                return "wwwroot/MessagesData/FichierClient.json";

            }
        }



        public static async Task CreateFold()
        {
            string foldName = "./wwwroot/my-new-fold";
            Directory.CreateDirectory(foldName);
        }


        public static string CreateWebPath(string relativePath)
        {
            return Path.Combine(WebStorageRoot!, relativePath);
        }

        public static async Task CreateFileLocal(IBrowserFile file, long maxFileSize, string path)
        {
            Directory.CreateDirectory(Path.Combine(FileStorage!,
                "PieceIdentiteClient"));

            await using FileStream fs = new(path, FileMode.Create);

            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);

        }
    }
}
