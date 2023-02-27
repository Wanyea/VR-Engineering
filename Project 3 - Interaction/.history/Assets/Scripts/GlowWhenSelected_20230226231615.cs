using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowWhenSelected : MonoBehaviour
{
    private bool isGlowing = false;
    // Start is called before the first frame update

    void Awake() 
    {
        gameObject.AddComponent<Outline>();
        gameObject.GetComponent<Outline>().OutlineMode = Outline.Mode.OutlineAll;
        gameObject.GetComponent<Outline>().OutlineColor = Color.white;
        gameObject.GetComponent<Outline>().OutlineWidth = 5f;
    }
    
    void Start()
    {
        gameObject.GetComponent<Outline>().enable;
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
