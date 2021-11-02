using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCollider : MonoBehaviour
{
    public GameObject EnemySphere;

    public float positionx;
    public float positiony;
    public float positionz;
    public float distancex;
    public float distancey;
    public float distancez;
    public float enemyz;
    public float enemyy;
    public float enemyx;

    public float scale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        takingposition();
        enemyposition();



        distancex = Vector3.Distance(EnemySphere.transform.position, transform.position);
        if (transform.position.x>=EnemySphere.transform.localScale.x/2)
        {
            distancex=distancex + EnemySphere.transform.localScale.x / 2;
        }
        else
        {
            distancex = distancex - EnemySphere.transform.localScale.x / 2;
        }


        if (distancex<=1)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }


    }

    void takingposition()
    {
        positionx = transform.position.x;
        positiony = transform.position.y;
        positionz = transform.position.z;
        
    }

    void enemyposition()
    {
        enemyx = EnemySphere.transform.position.x;
        enemyy = EnemySphere.transform.position.y;
        enemyz = EnemySphere.transform.position.z;
        
        
    }
}