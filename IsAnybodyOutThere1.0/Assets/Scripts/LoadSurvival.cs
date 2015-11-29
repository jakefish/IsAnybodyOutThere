using UnityEngine;
using System.Collections;

public class LoadSurvival : MonoBehaviour {

    public void Load()
    {
     Invoke("delay", 1); 
    }
    public void delay()
    {
        Application.LoadLevel("1");

    }
}
