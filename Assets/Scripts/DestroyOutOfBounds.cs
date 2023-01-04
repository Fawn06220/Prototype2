using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField]
    private float topBound=30f;
    [SerializeField]
    private float lowerBound = -1f;
    private GameObject go;
    // Start is called before the first frame update

    private void Awake()
    {
        go = GameObject.Find("Main Camera");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            go.GetComponent<GO>().EndGame();
        }
    }
}
