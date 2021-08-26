
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Project0.StoreApplication.Storage.Adapters
{
  /// <summary>
  /// 
  /// </summary>
  
  public class FileAdapter
  {
    /// <summary>
    /// Takes file path 
    /// Returns list of objects
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
    /// Takes the path to a file and a list of objects
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
  
  // Still Learning how to implement Serialization: 
  // public class FileAdapter
  // {
  //   public List<Store> ReadFromFile()
  //   {
  //       // file path
  //       var path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/project_0.stores.xml";
        
  //       // open path
  //       var file = new StreamReader(path);
        
  //       // serialize object
  //       var xml = new XmlSerializer(typeof(List<Store>));
        
  //       // write file
  //       var stores = xml.Deserialize(file) as List<Store>;

  //       return stores;
  //   }


  //   public void WriteToFile(List<Store> stores)
  //   {
  //     // file path
  //     var path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/project_0.stores.xml";
      
  //     // open path
  //     var file = new StreamWriter(path);
      
  //     // serialize object
  //     var xml = new XmlSerializer(typeof(List<Store>));
      
  //     // write file
  //     xml.Serialize(file, stores);
     
  //   }
  // }
}