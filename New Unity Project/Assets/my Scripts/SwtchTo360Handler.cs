using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwtchTo360Handler : MonoBehaviour
{
    private bool isIn360 = false;

    public void SwitchTo360(GameObject movieSphere)
    {
        //if (!isIn360)
        //{
        //    gameObject.GetComponent<Text>().text = "Zurück";
        //    movieSphere.SetActive(true);
        //    isIn360 = true;
        //} else if (isIn360)
        //{
        //    gameObject.GetComponent<Text>().text = "360";
        //    movieSphere.SetActive(false);
        //    isIn360 = false;
        //}

        //GameObject.Find("360Sphere").SetActive(true);
        //GameObject sphere = GameObject.Find("360Sphere").gameObject;
        movieSphere.SetActive(true);

        SceneManager.LoadScene("360_sphere_test");

        //GameObject button = GameObject.Find("360 Button");
        //button.GetComponent<Text>().text = "Zurück";
    }
}
