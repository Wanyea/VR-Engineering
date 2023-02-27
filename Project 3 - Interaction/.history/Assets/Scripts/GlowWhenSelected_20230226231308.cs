using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowWhenSelected : MonoBehaviour
{
    private bool isGlowing = false;

    var outline = gameObject.AddComponent<Outline>();
    // Start is called before the first frame update

    void Awake() 
    {
        

            outline.OutlineMode = Outline.Mode.OutlineAll;
            outline.OutlineColor = Color.white;
            outline.OutlineWidth = 5f;

    }

    void Start()
    {
        outli
    }

    // Update is called once per frame
    void Update()
    {
        ItemSelected();
    }

    void ItemSelected() 
    {
        if (gameObject.transform.position.y > 1.0 && !isGlowing) 
        {
            Debug.Log(gameObject.name + " has been selected!");
            
            isGlowing = true;

        } else {
            isGlowing = false;

            gameObject.RemoveComponent
        }
    }
}
