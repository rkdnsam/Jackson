using UnityEngine;
using UnityEngine.UI;

public class FrameRateDisplay : MonoBehaviour
{
    public Text frameRateText;

    void Update()
    {
        float currentFrameRate = 1.0f / Time.deltaTime;
        frameRateText.text = "FPS: " + Mathf.RoundToInt(currentFrameRate);
    }
}
