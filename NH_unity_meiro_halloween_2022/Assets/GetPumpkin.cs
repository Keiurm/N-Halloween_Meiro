using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPumpkin : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(player.tag))
        {
            Destroy(gameObject);
        }
    }
}
