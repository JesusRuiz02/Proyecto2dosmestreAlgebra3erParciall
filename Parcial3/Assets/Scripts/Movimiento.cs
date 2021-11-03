using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private int speeed = 3;
    public int life = 2;
    private float timer = 0;
    public int points = 0;

   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward *Time.deltaTime*speeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left *Time.deltaTime*speeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right *Time.deltaTime*speeed);

        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-1,0 *Time.deltaTime * 1);  
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,1,0 *Time.deltaTime * 1);  
        }

      

        if (timer<=1)
        {
            subida();
         
        }

        if (timer>=1)
        {
            bajada();
            if (timer>=2)
            {
                timer = 0;
            }
        }
        
    Debug.Log(points);
    Debug.Log(life);

    }

    void subida()
    {
        this.transform.Translate(new Vector3(0,0.5f,0)*Time.deltaTime*1);  
        
    }

    void bajada()
    {
        transform.Translate(new Vector3(0,-0.5f,0)*Time.deltaTime*1);
    }

    public void lives()
    {
        life--;
    }

    public void pointss()
    {
        points++;
    }
}
