using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowWhenSelected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ItemSelected() 
    {
        if (gameObject.transform.position.y > 1.0) 
        {
            var outline = gameObject.AddComponent<Outline>();

            outline.OutlineMode = Outline.Mode.OutlineAll;
            outline.OutlineColor = Color.yellow;
            outline.OutlineWidth = 5f;

        }
    }
}
