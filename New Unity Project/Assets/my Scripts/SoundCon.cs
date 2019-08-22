using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SoundCon : MonoBehaviour
{
    public VideoClip[] vClips;

    public VideoPlayer myVideoSource;

    string btnName;

    public GameObject imageTarget;
    public GameObject rawImageVideo;
    public GameObject videoPlayerObject;
   


    // Use this for initialization
    void Start()
    {
        myVideoSource = GetComponent<VideoPlayer>();
        
        imageTarget.SetActive(true);
        rawImageVideo.SetActive(false);
        videoPlayerObject.SetActive(false);
    }

    private void ButtonClick()
    {
        VideoPlayer vp = videoPlayerObject.GetComponent<VideoPlayer>();
        //myVideoSource.Play();
        vp.clip = myVideoSource.clip;
        rawImageVideo.SetActive(true);
        imageTarget.SetActive(false);
        videoPlayerObject.SetActive(true);
        vp.Play();

        vp.loopPointReached += EndReached;
        Debug.Log("VideoPlayer vp got initiated. Function EndReached is called.");
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
                    case "myButton1":
                        myVideoSource.clip = vClips[0];
                        break;
                    case "myButton2":
                        myVideoSource.clip = vClips[1];
                        break;
                    case "myButton3":
                        myVideoSource.clip = vClips[2];
                        break;
                    case "myButton4":
                        myVideoSource.clip = vClips[3];
                        break;
                    case "myButton5":
                        myVideoSource.clip = vClips[4];
                        break;
                    case "myButton6":
                        myVideoSource.clip = vClips[5];
                        break;
                    default:
                        break;
                }

                ButtonClick();
                Debug.Log("Button was triggered.");
            }
        }
    }

    public void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("Running function EndReached.");
        imageTarget.SetActive(true);
        rawImageVideo.SetActive(false);
        videoPlayerObject.SetActive(false);
    }
}