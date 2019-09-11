using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwtchTo360Handler : MonoBehaviour
{
    public void SwitchTo360_1()
    {

        //if (!name.Equals("360 Button"))
        //{
            SceneManager.LoadScene("360_sphere_1");
        //}
        //else if (name.Equals("360 Back Button"))
        //{
        //    SceneManager.LoadScene("2_GroundPlaneScene_scenario1");
        //}
        
    }

    public void SwitchTo360_2()
    {

        //if (name.Equals("360 Button2"))
        //{
            SceneManager.LoadScene("360_sphere_2");
        //}
        //else if (name.Equals("360 Back Button2"))
        //{
        //    SceneManager.LoadScene("2_GroundPlaneScene_scenario2");
        //}
    }

    public void BackToScene1()
    {
        SceneManager.LoadScene("2_GroundPlaneScene_scenario1");
    }

    public void BackToScene2()
    {
        SceneManager.LoadScene("2_GroundPlaneScene_scenario2");
    }
}
