using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 playerpos = new Vector2(3.0f, 4.0f);
        playerpos.x += 1.0f;
        playerpos.y += 2.0f;
        Debug.Log(playerpos);
    }

}
