using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class boothcanvas : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject videoplane,boothbtn, can;
    bool  videoplay = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void videoplays()
    {
        videoplane.SetActive(true);
        boothbtn.SetActive(false);
        videoplay = false;
        videoo();
    }
    public void booths()
    {
        videoplane.SetActive(false);
        boothbtn.SetActive(true);
        videoo();

    }
    public void xbtnclick()
    {
        can.SetActive(false);
    }
    public void videoo()
    {
        if (videoplay == true)
            video.Play();
        else
            video.Pause();
    }
    public void playvideo()
    {
        videoplay = true;
        videoo();
    }
    public void stopvideo()
    {
        videoplay = false;
        videoo();
    }
}
