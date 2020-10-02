using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour

{
    public GameObject cubePrefabvar;
    public float one;
    public int two;
    public int three;

    // Start is called before the first frame update
    void Start()
    {
        /*Instantiate(cubePrefabvar);*/
        one = Screen.dpi;
        print(one);
        two = Screen.width;
        print(two);
        three = Screen.height;
        print(three);
        print(SystemInfo.operatingSystem);
        print("Test");
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubePrefabvar);
    }
}
