using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinView : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spRend;
    
    private void Start()
    {
        spRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        spRend.enabled ^= true;
    }
}
