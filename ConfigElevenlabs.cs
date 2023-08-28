using UnityEngine;

[CreateAssetMenu(fileName = "ElevenLabsConfig", menuName = "ElvenLabs/ElvenLabs Configuration")]
public class ElevenLabsConfig : ScriptableObject
{
    public string apiKey = "ADD YOUR API KEY HERE";
    public string voiceId = "";
    public string ttsUrl = "https://api.elevenlabs.io/v1/text-to-speech/{0}/stream";

}

