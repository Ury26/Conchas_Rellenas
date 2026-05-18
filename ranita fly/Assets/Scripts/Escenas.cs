using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{

    // Update is called once per frame
   public void Inicio()
   {
     SceneManager.LoadScene(0);   
    }
    public void PrimerNivel()
    {
        SceneManager.LoadScene(1);
    }

    public void SegundoNivel()
    { 
        SceneManager.LoadScene(2);
    }
}
