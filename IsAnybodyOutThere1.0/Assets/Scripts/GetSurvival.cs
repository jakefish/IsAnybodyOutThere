using UnityEngine;
using System.Collections;

public class GetSurvival : MonoBehaviour {

    public void Load()
    {
        Invoke("delay", 2);
    }
    public void delay()
    {

        Application.LoadLevel("difficulty");

    }
}
