using UnityEngine;

public class SwitchCamScript : MonoBehaviour
{

    public Camera arCam;
    public Camera stationaryCam;
    private int g;

    public void SwitchCam()
    {
        arCam.gameObject.SetActive(false);
        stationaryCam.gameObject.SetActive(true);
    }
}
