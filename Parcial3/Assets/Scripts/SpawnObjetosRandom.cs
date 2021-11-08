using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetosRandom : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject Objeto3;
    GameObject Objeto4;

    float x1, x2, x3;
    float z1, z2, z3 ;
    Vector3 pos1,pos2,pos3;
   
    // Start is called before the first frame update
    void Start()
    {
        z1 = Random.Range(300, 350);
        z2 = Random.Range(200, 250);
        z3 = Random.Range(50, 60);
        x1 = Random.Range(0, 100);
        x2 = Random.Range(100, 150);
        x3 = Random.Range(0, 20);
        pos1 = new Vector3(x1, 5, z1);
        pos2 = new Vector3(x2, 5, z2);
        pos3 = new Vector3(x3, 5, z3);


        Instantiate(objeto1, pos1, transform.rotation);
        Instantiate(objeto2, pos2, transform.rotation);
        Instantiate(Objeto3, pos3, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
