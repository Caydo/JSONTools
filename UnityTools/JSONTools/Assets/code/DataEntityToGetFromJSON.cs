/// <summary>
/// An example class that extends so that's serializable and you can combine lists of these if desired.
/// The JSON name corresponds to the string key for the item in the JSON file. Typically the key and variable name match.
/// </summary>

public class DataEntityToGetFromJSON : JSONFileDataPiece
{
  [JsonFx.Json.JsonName("EntityName")]
  public string EntityName;
  [JsonFx.Json.JsonName("EntityImageName")]
  public string EntityImageName;
  [JsonFx.Json.JsonName("EntityHP")]
  public int EntityHP;
}