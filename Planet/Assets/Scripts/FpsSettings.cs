using UnityEngine;

public class FpsSettings : MonoBehaviour
{
    private int fps = 30;
    void Start()
    {
        Application.targetFrameRate = fps;
    }


}
