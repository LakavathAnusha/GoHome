using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anushaBase
{
}

public class anusha : MonoBehaviour
{

    public Vector3 initalposition;
    [SerializeField]
    public Vector3 homeposition;

    public anusha(Vector3 initalposition, Vector3 homeposition)
    {
        this.initalposition = initalposition;
        this.homeposition = homeposition;
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Hello Anusha");
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello Anusha Lakavath");  
    }
}
