using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoPlayer : MonoBehaviour
{
    public MovieTexture movie;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        movie.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
