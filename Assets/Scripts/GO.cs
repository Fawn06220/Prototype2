using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO : MonoBehaviour
{

    private GameObject go;
    // Start is called before the first frame update

    private void Awake()
    {
        go = GameObject.Find("GameOver");
        go.SetActive(false);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndGame()
    {
        go.SetActive(true);
        Time.timeScale = 0;
    }
}
