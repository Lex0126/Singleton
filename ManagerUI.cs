using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static ManagerUI Instance {get; private set;}

    TextMeshProUGUI contador;

    float cont_seg;
    float tiempo_Transcurrido;

    private void Awake(){
        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }else{
        //Intance es difrente de null
            // this es diferente de instance
            Instance = this;
            contador = GetComponentInChildren<TextMeshProUGUI>();
        }
       
    }
    void Start()
    {
        cont_seg =0;
        tiempo_Transcurrido =0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_Transcurrido += Time.deltaTime;
        if(tiempo_Transcurrido>1.0f){
            cont_seg ++;
            tiempo_Transcurrido = 0;
            contador.text = cont_seg.ToString();
        }
    }
}
