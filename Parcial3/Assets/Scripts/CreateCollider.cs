using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Annotations;
using UnityEngine;

public class CreateCollider : MonoBehaviour
{
    public GameObject EnemySphere;
    private Spawn _spawn;
    public float positionx;
    public float positiony;
    public float positionz;
    public float distancex;
    public float distance;
   public GameObject[] ListB = new GameObject[2];
   public GameObject[] ListP = new GameObject[2];
  public  GameObject[] ListN = new GameObject[1];
  private Movimiento _movimiento;
  
  public float timer1;
  public bool switca=true;
  public bool switca2=true;

  public float scale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        distancex = Vector3.Distance(EnemySphere.transform.position, transform.position);
        if (transform.position.x >= EnemySphere.transform.localScale.x / 2)
        {
            distance = distancex + EnemySphere.transform.localScale.x / 2;
        }
        else
        {
            distance = distancex - EnemySphere.transform.localScale.x / 2;
        }

        if (distance <= 1)
        {
            print("hola");
            //_spawn.enableObjects();
            ListB = GameObject.FindGameObjectsWithTag("Bomb");
        
            foreach (GameObject p in ListB)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                print("p " + p.transform.position + "yo" + transform.position);
                if (p.transform.position == transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = true;
                    //p.SetActive(true);
                    
                }
                

            }

            ListP = GameObject.FindGameObjectsWithTag("Point");
           
            foreach (GameObject p in ListP)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                print("p " + p.transform.position + "yo" + transform.position);
                if (p.transform.position == transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = true;
                    //p.SetActive(true);
                   
                }

            }
            ListN = GameObject.FindGameObjectsWithTag("Nothing");
            foreach (GameObject p in ListN)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                print("p " + p.transform.position + "yo" + transform.position);
                if (p.transform.position == transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = true;

                    //p.SetActive(true);
                }

            }
            
        }

       




    }






   

}

    



