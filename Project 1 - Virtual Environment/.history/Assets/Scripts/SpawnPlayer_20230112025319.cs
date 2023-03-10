using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnTile;

    [SerializeField]
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, new Vector3(spawnTile.transform.position.x, 
                                        spawnTile.transform.position.y + 1.0f, 
                                        spawnTile.transform.position.z), 
                                        Quaternion.identity);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
