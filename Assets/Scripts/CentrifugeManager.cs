using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentrifugeManager : MonoBehaviour
{
    [SerializeField] Renderer _buttonCentrif;
    bool isLoaded;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("cadres"))
        {
            //gameObject.GetComponent<AudioSource>().Play();
            _buttonCentrif.material.color = Color.green;
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
