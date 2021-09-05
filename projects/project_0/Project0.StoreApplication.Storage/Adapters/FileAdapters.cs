
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Project0.StoreApplication.Storage.Adapters
{
  /// <summary>
  /// The file adapter class to save and read data using generic methods to sort and manipulate object List data.
  /// </summary>
  public class FileAdapter
  {
    /// <summary> 
    /// Reads from file to return list of objects; Deserializes the file.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public List<T> ReadFromFile<T>(string path) where T : class
    {
      // The iteration checks for the file path existence
      if (!File.Exists(path))
      {
        return null;
      }
      // StreamReader() is a text reader that will convert(encode) text data(string/char) to byte[]
      // It will then write them down to the underlying stream
      var file = new StreamReader(path);
      // Instantiates the xml variable by giving the XmlSerializer a type of list<collection> 
      var xml = new XmlSerializer(typeof(List<T>));
       // Deserializes objects from XML file 
      var result = xml.Deserialize(file) as List<T>;
      return result;
    }//EoRFF Method

    /// <summary>
    /// Writes to a file instantiated from given path; Serializes the type of of file into in Xml data file.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void WriteToFile<T>(string path, List<T> data) where T : class
    {
      // Is a text writer implementation that writes to a file
      var file = new StreamWriter(path);
      // Instantiates the xml variable by giving the XmlSerializer a type of list<collection> 
      var xml = new XmlSerializer(typeof(List<T>));
      // Serializes objects with the Serialize method into XML documents
      xml.Serialize(file, data);
    }//EoWTF method
  }//EoC
}//EoN