using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testinteractionToo : MonoBehaviour
{
    public testInteraction interaction;
    private void Start()
    {
        interaction.interactionEvent += TestMethodThree;
    }

    public void Activate()
    {
        Debug.Log("the interaction is currently turned on" + interaction.ExampleBool);
        interaction.Activate();
    }

    private void TestMethodThree() 
    {
        Debug.Log("Test method three has been executed");
    }
}
