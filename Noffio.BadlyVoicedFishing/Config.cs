using System.Text.Json.Serialization;

namespace Noffio.BadlyVoicedFishing;

public class Config {
    [JsonInclude] public bool SomeSetting = true;
}
