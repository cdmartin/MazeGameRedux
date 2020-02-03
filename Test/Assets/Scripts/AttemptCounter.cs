using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttemptCounter : MonoBehaviour
{

    public static int attempts;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("attemptNum") <= 0)
        {
            attempts = 1;
            PlayerPrefs.SetInt("attemptNum", attempts);
        }
        else
        {
            attempts = (PlayerPrefs.GetInt("attemptNum"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(attempts);
    }
}
