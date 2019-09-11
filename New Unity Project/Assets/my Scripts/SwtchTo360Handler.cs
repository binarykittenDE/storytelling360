using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwtchTo360Handler : MonoBehaviour
{
    public void SwitchTo360()
    {

        if (name.Equals("360 Button"))
        {
            SceneManager.LoadScene("360_sphere_1");
        }
        else if (name.Equals("360 Button2"))
        {
            SceneManager.LoadScene("360_sphere_2");
        }

        else if (name.Equals("360 Back Button"))
        {
            SceneManager.LoadScene("2_GroundPlaneScene_scenario1");
        }
        else if (name.Equals("360 Back Button2"))
        {
            SceneManager.LoadScene("2_GroundPlaneScene_scenario2");
        }
    }
}
