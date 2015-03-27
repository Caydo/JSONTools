using JsonFx.Json;
using UnityEngine;

/// <summary>
/// Calls the JSON util to get the data then presumably will do whatever is desired with it and/or stores the data.
/// </summary>

public class DataRetriever : MonoBehaviour
{
  string dataTypeOneDataPath;
  string dataTypeTwoDataPath;
  JSONUtil jsonUtil;
  JsonReader reader;

  JSONFileDataPiece[] dataTypeOneEntities;
  JSONFileDataPiece[] dataTypeTwoEntities;

  void Awake()
  {
    jsonUtil = gameObject.GetComponent<JSONUtil>();
    dataTypeOneDataPath = string.Format("{0}/data/JSON/dataTypeOneEntities.json", Application.dataPath);
    dataTypeTwoDataPath = string.Format("{0}/data/JSON/dataTypeTwoEntities.json", Application.dataPath);
  }

  public void Start()
  {
    dataTypeOneEntities = jsonUtil.GetJSONObjectsFromFile(dataTypeOneDataPath, JSONUtil.JSONDataType.DataType1);
    dataTypeTwoEntities = jsonUtil.GetJSONObjectsFromFile(dataTypeTwoDataPath, JSONUtil.JSONDataType.DataType2);

    Debug.Log("****** DATA SET 1 ENTITIES ******");

    foreach(DataEntityToGetFromJSON entity in dataTypeOneEntities)
    {
      Debug.Log("Entity Name " + entity.EntityName);
      Debug.Log("Entity Image Name " + entity.EntityImageName);
      Debug.Log("Entity HP " + entity.EntityHP);
    }

    Debug.Log("****** DATA SET 2 ENTITIES ******");

    foreach (DataEntityToGetFromJSON entity in dataTypeTwoEntities)
    {
      Debug.Log("Entity Name " + entity.EntityName);
      Debug.Log("Entity Image Name " + entity.EntityImageName);
      Debug.Log("Entity HP " + entity.EntityHP);
    }
  }
}