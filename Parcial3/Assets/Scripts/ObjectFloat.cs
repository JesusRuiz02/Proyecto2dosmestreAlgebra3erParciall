using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloat : MonoBehaviour
{
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
    void subida()
    {
        this.transform.Translate(new Vector3(0, 0.5f, 0) * Time.deltaTime * 1);

    }

    void bajada()
    {
        transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime * 1);
    }
}
