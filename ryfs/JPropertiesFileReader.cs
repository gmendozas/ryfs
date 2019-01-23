using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ryfs
{
    public class JPropertiesFileReader
    {
        private string pathProperties;
        private string filename;

        public JPropertiesFileReader(string filename)
        {
            this.pathProperties = AppDomain.CurrentDomain.BaseDirectory;
            this.filename = filename;
        }
        public Dictionary<string, string> ReadFileContent()
        {
            Dictionary<string, string> scripts = new Dictionary<string, string>();
            try
            {
                var text = File.ReadAllText(string.Format("{0}{1}", this.pathProperties, this.filename));
                var list = JsonConvert.DeserializeObject<IEnumerable<KeyValuePair<string, string>>>(text);
                scripts = list.ToDictionary(x => x.Key, x => x.Value);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return scripts;
        }
    }
}
