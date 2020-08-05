using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour

{
    public GameObject cubePrefabvar;
    // Start is called before the first frame update
    void Start()
    {
        /*Instantiate(cubePrefabvar);*/
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubePrefabvar);
    }
}
