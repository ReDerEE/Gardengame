using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantTaker : MonoBehaviour, IInteractible
{
    bool takesPlants = true;
    GameObject obtainedPlant;
    public bool CanInteract()
    {
        // throw new NotImplementedException();
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
            Destroy(obtainedPlant);
        }
        
    }

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
