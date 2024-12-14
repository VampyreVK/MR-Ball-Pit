using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using UnityEngine.XR;

public class BallShot : MonoBehaviour
{
    [SerializeField]
    public GameObject ballTemplate;

    public OVRInput.Button button;
    public float shootPower = 10000f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button))
        {
            //creates a copy of the ball template and makes it show in the world.
            GameObject newBall = Instantiate(ballTemplate, transform.position, transform.rotation);
            newBall.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
        }
    }
}
