using UnityEngine;
using UnityEngine.UI;

public class DebugInfoDisplay : MonoBehaviour
{
    public Text debugText;

    void Start()
    {
        string debugInfo = $"VSync Count: {QualitySettings.vSyncCount}\n" +
                           $"Target Frame Rate: {Application.targetFrameRate}";
        debugText.text = debugInfo;
    }
}
