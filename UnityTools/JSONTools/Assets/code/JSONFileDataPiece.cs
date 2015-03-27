/// <summary>
/// Base class for any class that'll be in a JSON data file. This way JSONUtil can return an array of any of these classes and it's still kosher
/// E.g. DataEntityToGetFromJSON[] can be pulled from the same JSONUtil function as another class that has this base
/// </summary>
[System.Serializable]
public class JSONFileDataPiece
{
}