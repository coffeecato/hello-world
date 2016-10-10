using UnityEngine;
using System.Collections;

public class switchCamera : MonoBehaviour {

    private GameObject MainCamera;
    private GameObject CameraLeft;
    private GameObject CameraRight;
	// Use this for initialization
	void Start () {
        MainCamera = GameObject.Find("Main Camera");
        CameraLeft = GameObject.Find("CameraLeft");
        CameraRight = GameObject.Find("CameraRight");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUILayout.Button("切换左侧", GUILayout.Height(50)))
        {
            MainCamera.SetActive(false);
            CameraLeft.SetActive(true);
            CameraRight.SetActive(false);
        }

        if (GUILayout.Button("切换右侧", GUILayout.Height(50)))
        {
            MainCamera.SetActive(false);
            CameraLeft.SetActive(false);
            CameraRight.SetActive(true);
        }

        if (GUILayout.Button("切换上方", GUILayout.Height(50)))
        {
            MainCamera.SetActive(true);
            CameraLeft.SetActive(false);
            CameraRight.SetActive(false);
        }
    }
}
