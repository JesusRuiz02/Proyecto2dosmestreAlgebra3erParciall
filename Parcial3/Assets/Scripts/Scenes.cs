using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
   public GameObject PantallaInicio;

    public void Start()
    {
        PantallaInicio.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PantallaInicio.SetActive(false);
        }
    }


}
