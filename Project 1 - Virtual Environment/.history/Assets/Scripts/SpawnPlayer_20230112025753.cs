using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnTile;

    [SerializeField]
    private GameObject player;

    private Vector3 playerSpawnPosition = Vector3(spawnTile.transform.position.x, 
                                        spawnTile.transform.position.y + 0.1f, 
                                        spawnTile.transform.position.z), 
                                        Quaternion.identity);     

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, playerSpawnPosition, Quaternion.identity);     
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < spawnTile.transform.position.y)
            Destroy(player);

        if (Input.GetKeyDown(KeyCode.R))
            Instantiate(player)
    }
}
