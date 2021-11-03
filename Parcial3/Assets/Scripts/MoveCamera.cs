using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Camera1;

    public GameObject camera2;
    public GameObject camera3;

    // Start is called before the first frame update
    private void Start()
    {
        camera3.SetActive(true);
        camera2.SetActive(false);
        Camera1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camera3.SetActive(false);
            Camera1.SetActive(true);
        }

        if (Input.GetKey(KeyCode.L))
        {
            camera2.SetActive(true);
            Camera1.SetActive(false);
        }
        if (Input.GetKey(KeyCode.P))
        {
            camera2.SetActive(false);
            Camera1.SetActive(true);
        }
    }
}
