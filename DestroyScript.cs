using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject _gameObject;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(_gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
