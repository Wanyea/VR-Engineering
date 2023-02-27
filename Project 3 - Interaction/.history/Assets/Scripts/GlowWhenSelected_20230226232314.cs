using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowWhenSelected : MonoBehaviour
{
    private bool isGlowing = false;
    // Start is called before the first frame update

    void Awake() 
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ItemSelected();
    }

    void ItemSelected() 
    {
        bool initalize = false;

        if (!initalize)
            var outline = gameObject.AddComponent<Outline>();

        if (gameObject.transform.position.y > 1.0 && !isGlowing) 
        {
            Debug.Log(gameObject.name + " has been selected!");

            outline.OutlineMode = Outline.Mode.OutlineAll;
            outline.OutlineColor = Color.white;
            outline.OutlineWidth = 5f;
            isGlowing = true;

        } else {
            outline.OutlineMode = Outline.Mode.OutlineHidden;
            isGlowing = false;        
        }
    }
}
