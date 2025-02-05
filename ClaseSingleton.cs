using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaseSingleton : MonoBehaviour
{
    public static ClaseSingleton Instance {get; private set;}
    private void Awake(){
        if (Instance != null && Instance != this){
            Destroy(this);
        }else{
        //Intance es difrente de null
            // this es diferente de instance
            Instance = this;
            DontDestroyOnLoad(gameObject);// depende 
        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    if(Input.GetKeyDown(KeyCode.P)){

     
        int index_escena = SceneManager.GetActiveScene().buildIndex;
        index_escena ++;
        index_escena %=3;
        cambioEscena(index_escena);
        }
    }

    public void cambioEscena(int idx){
        SceneManager.LoadScene(idx);
    }
}

