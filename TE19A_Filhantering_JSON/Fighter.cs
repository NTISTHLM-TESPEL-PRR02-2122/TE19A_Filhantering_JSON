using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Fighter
{

  [JsonPropertyName("is_default")]
  public bool IsDefault {get; set;}

  [JsonPropertyName("bajs")]
  public string Name {get; set;}
  [JsonPropertyName("nåtjox")]
  public int Caring {get; set;}
  public int Huggability {get; set;}
}