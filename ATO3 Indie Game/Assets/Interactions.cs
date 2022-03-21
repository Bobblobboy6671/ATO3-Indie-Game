using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public float distance = 2.5f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Use") == true) 
        {
            if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, distance ) == true) 
            {
                if( hit.transform.TryGetComponent(out IInteractable interactable) == true) 
                {
                    Debug.DrawRay(transform.position, transform.forward * distance, Color.green);
                    interactable.Activate();
                }
            }
        }
    }
}

public interface IInteractable 
{
    void Activate();
}
