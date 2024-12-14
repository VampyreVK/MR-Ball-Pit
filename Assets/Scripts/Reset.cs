using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Reset : MonoBehaviour
{
    [SerializeField]
    public OVRInput.Button button1;
    public OVRInput.Button button2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button1) && OVRInput.GetDown(button2))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}