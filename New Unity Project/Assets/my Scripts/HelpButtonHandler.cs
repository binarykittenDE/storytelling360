using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelpButtonHandler : MonoBehaviour
{
    public void ShowSprite(GameObject targetFinderSprite)
    {
        targetFinderSprite.SetActive(true);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("0_TrackerSelectionScene");
    }
}
