using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantTaker : MonoBehaviour, IInteractible
{
    bool takesPlants = true;
    GameObject obtainedPlant;
    GameObject lavenderPlant;
    public bool CanInteract()
    {
        return takesPlants;
    }

    public void Interact()
    {
        obtainedPlant = GameObject.FindGameObjectWithTag("Plant");

        if(obtainedPlant==null){
            Debug.Log("There is no plant");
            return;
        }
        else{
            Debug.Log("There is a plant");
            switch(obtainedPlant.name){
                case "Lavender(Clone)":
                    Debug.Log("it is a lavender");
                    lavenderPlant.transform.GetChild(0).gameObject.SetActive(true);
                    break;
                default:
                    Debug.Log("default");
                    break;
            }
            Destroy(obtainedPlant);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        lavenderPlant = GameObject.FindGameObjectWithTag("Lavender");
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
