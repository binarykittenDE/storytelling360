using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButtonHandler : MonoBehaviour
{
    public void ShowSprite(GameObject targetFinderSprite)
    {
        targetFinderSprite.SetActive(true);
    }
}
