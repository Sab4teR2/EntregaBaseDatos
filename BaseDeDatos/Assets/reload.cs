using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //Este void hace que reseteemos la escena para poder probar nuestra base de datos

    public void reloade()
    {
       SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
