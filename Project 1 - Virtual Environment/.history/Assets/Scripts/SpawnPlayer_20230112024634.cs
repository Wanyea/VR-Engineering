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
        Instantiate(player, spawnTile.transform.position, Quaternion.identity);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
