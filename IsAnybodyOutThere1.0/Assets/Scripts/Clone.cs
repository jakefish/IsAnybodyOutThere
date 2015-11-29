using UnityEngine;
using System.Collections;

public class Clone : MonoBehaviour
{
    public GameController gc;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.07f, 0.0f, 0.0f);

    }
}
