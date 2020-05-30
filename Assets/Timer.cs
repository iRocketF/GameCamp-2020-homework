using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float gameTime;

    [Range(0,1)]
    public float timeScale = 1f;
    [SerializeField]
    private float currentTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Time.timeScale = timeScale;

        currentTime += Time.deltaTime;

        if(currentTime >= gameTime)
        {
            currentTime = 0;
            // timeScale = 0;
        }
    }
}
