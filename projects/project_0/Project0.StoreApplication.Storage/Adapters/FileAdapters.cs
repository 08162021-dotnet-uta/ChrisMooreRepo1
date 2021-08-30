
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Project0.StoreApplication.Storage.Adapters
{
  /// <summary>
  /// The file adapter class to save and read data using generic methods to sort and manipulate List data.
  /// </summary>
  public class FileAdapter
  {
    /// <summary> 
    /// Reads from file to return list of objects; Deserializes the file.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public List<T> ReadFromFile<T>(string path) where T : class
    {
      if (!File.Exists(path))
      {
        return null;
      }

      // StreamReader() is a text reader that will convert(encode) text data(string/char) to byte[]
      // It will then write them down to the underlying stream
      var file = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<T>));
      var result = xml.Deserialize(file) as List<T>;
      return result;
    }

    /// <summary>
    /// Writes to a file instantiated from given path; Serializes the type of of file into in Xml data file.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void WriteToFile<T>(string path, List<T> data) where T : class
    {
      // Is a text writer implementation that writes to a file
      var file = new StreamWriter(path);
      // Serializes and Deserailizes objects into XML documents
      var xml = new XmlSerializer(typeof(List<T>));
      xml.Serialize(file, data);
    }
  }
}