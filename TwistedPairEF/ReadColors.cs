using Newtonsoft.Json;

namespace TwistedPairEF
{
    public class ReadColors : Colors
    {
        public static string fileName;

        public static List<Colors> Read()
        {
            try
            {
                string fileName = "coloredPairs.json";

                var path = Path.Combine(Environment.CurrentDirectory, fileName);
               
                    string jsonFile = File.ReadAllText(path);
                
                return JsonConvert.DeserializeObject<List<Colors>>(jsonFile);
                
            }
            catch (Exception ex)
            {
                ReportError(ex);
                throw;
            }

        }

        private static void ReportError(Exception ex)
        {
            throw new InvalidOperationException("File not found, please verify the location and name of the file. This is typically in C:\\Users\\Tony\\source\\repos\\TwistedPairEF\\TwistedPairEF, and named coloredPairs.json. Program will close.");
        }
    }
}