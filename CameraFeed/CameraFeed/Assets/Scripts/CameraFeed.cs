using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Net.Sockets;

public class CameraFeed : MonoBehaviour {

    private WebCamTexture mCameraFeed;
    public double getal = 2.1;

    [SerializeField] private RawImage img;
    [SerializeField] private Button startbttn;
    [SerializeField] private Button stopBttn;
    
    // Use this for initialization
    void Start()
    {
        mCameraFeed = new WebCamTexture();

        startbttn.onClick.AddListener(() => StartFeed());
        stopBttn.onClick.AddListener(() => StopFeed());
    }

    private void StartFeed()
    {
        img.GetComponent<RawImage>().texture = mCameraFeed;
        mCameraFeed.Play();
    }

    private void StopFeed()
    {
        mCameraFeed.Stop();
        img.texture = null;
    }

    void Update()
    {
        Debug.Log("getal in double: " + getal + " in int: " + (int)getal);
    }
}
