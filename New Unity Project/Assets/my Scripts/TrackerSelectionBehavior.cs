using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TrackerSelectionBehavior : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if(name.Equals("Panel Poster"))
        {
            SceneManager.LoadScene("1_ImageTrackerScene");
        }

        else if (name.Equals("Panel Hof"))
        {
            SceneManager.LoadScene("2_GroundPlaneScene");
        }
    }
}
