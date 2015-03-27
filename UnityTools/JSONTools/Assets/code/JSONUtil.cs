using System.IO;
using UnityEngine;
using JsonFx.Json;

/// <summary>
/// Gets the JSON file, parses it, then grabs the desired elements and puts them in array to do whatever you want with.
/// </summary>
public class JSONUtil : MonoBehaviour
{
  public enum JSONDataType
  {
    DataType1,
    DataType2
  }
  // Get the JSON file at the given path.
  // Note: This should be structured similar to:
  // string path = string.Format("{0}/data/FileName.json", Application.dataPath);

  public JSONFileDataPiece[] GetJSONObjectsFromFile(string path, JSONDataType dataType)
  {
    // open the stream reader to pass the file into data
    var streamReader = new StreamReader(path);
    string data = streamReader.ReadToEnd();
    streamReader.Close();

    // ** Crucial Step **
    // set the reader settings so that we can infer the type when casting later. This is the part that caused hours and hours of googling!
    JsonReaderSettings readerSettings = new JsonReaderSettings();
    readerSettings.TypeHintName = "__type";
    JsonReader reader = new JsonReader(data, readerSettings);

    return castAndGetJSONData(reader, dataType);
  }
    
   JSONFileDataPiece[] castAndGetJSONData(JsonReader reader, JSONDataType dataType)
   {
     JSONFileDataPiece[] jsonData = null;
     switch(dataType)
     {
       case JSONDataType.DataType1:
         // cast the data received as an array of the class you're expecting then set the array to be returned.
         DataEntityToGetFromJSON[] dataTypeOneEntities = reader.Deserialize<DataEntityToGetFromJSON[]>();
         jsonData = dataTypeOneEntities;
       break;
       
       case JSONDataType.DataType2:
         // cast the data received as an array of the class you're expecting then set the array to be returned.
        DataEntityToGetFromJSON[] dataTypeTwoEntities = reader.Deserialize<DataEntityToGetFromJSON[]>();
        jsonData = dataTypeTwoEntities;
       break;
     }

     return jsonData;
  }
}