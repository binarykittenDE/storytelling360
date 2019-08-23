using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioClip[] aClips;

    public AudioSource myAudioSource;

    string btnName;
   

    // Use this for initialization
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        
    }

    private void ButtonClick()
    {
        myAudioSource.Play();

    }

        

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "audioButton1":
                        myAudioSource.clip = aClips[0];
                        break;
                    case "audioButton2":
                        myAudioSource.clip = aClips[1];
                        break;
                    case "audioButton3":
                        myAudioSource.clip = aClips[2];
                        break;
                    case "audioButton4":
                        myAudioSource.clip = aClips[3];
                        break;
                    case "audioButton5":
                        myAudioSource.clip = aClips[4];
                        break;
                    case "audioButton6":
                        myAudioSource.clip = aClips[5];
                        break;
                    default:
                        break;
                }

                ButtonClick();
            }
        }
    }
}