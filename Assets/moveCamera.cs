using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{

    public Chomper player;

    public float height;

    public float bottom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            new Vector3(player.transform.position.x, player.transform.position.y + height, player.transform.position.z + bottom);
    }
}
