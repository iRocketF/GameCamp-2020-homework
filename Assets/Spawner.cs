using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(
            original: spawn,
            position: transform.position,
            rotation: Quaternion.identity
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
