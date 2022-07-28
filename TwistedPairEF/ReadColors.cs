using Newtonsoft.Json;
using System;
using System.IO;

namespace TwistedPairEF
{
    //public class ReadColors : Colors
    //{
    //    public static string? fileName;

    //    public interface IReadColors 
    //    {
            
    //    }

    //    public static List<Colors> Read()
    //    {
    //        try
    //        {
    //            string fileName = "coloredPairs.json";

    //            var path = Path.Combine(Environment.CurrentDirectory, fileName);
    //           // using (StreamReader file = new StreamReader(fileName))
    //            //{
    //                string jsonFile =System.IO.File.ReadAllText(path);
    //                //file.ReadToEnd();

    //            return JsonConvert.DeserializeObject<List<Colors>>(jsonFile);
                    
    //            //}
    //        }
    //        catch (Exception ex)
    //        {
    //            ReportError(ex);
    //            throw;
    //        }

    //        static void ReportError(Exception ex)
    //        {
    //            throw new InvalidOperationException("File not found, please verify the location and name of the file. This is typically in TwistedPair\\bin\\Debug\\net5.0, or TwistedPair\\bin\\Release\\TwistedPair, and named coloredPairs.json. Program will close.");
    //        }
    //    }
    //}
}