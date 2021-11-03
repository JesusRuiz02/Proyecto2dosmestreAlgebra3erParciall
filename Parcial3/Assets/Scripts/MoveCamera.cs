using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Camera1;

    public GameObject camera2;

    // Start is called before the first frame update
    private void Awake()
    {
        camera2.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
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
