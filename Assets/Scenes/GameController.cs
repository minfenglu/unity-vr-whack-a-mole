using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject moleContainer;
    public float spawnDuration = 3f;
    public float minimumSpawnDuraiton = 1.5f;
    public float spawnDecrement = 0.1f;
    private float spawnTimer = 0f;
    private Mole[] moles;

    // Start is called before the first frame update
    void Start()
    {
        moles = moleContainer.GetComponentsInChildren<Mole>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0) {
            moles[Random.Range(0, moles.Length)].Rise();
            spawnDuration -= spawnDecrement;
            if (spawnDuration < minimumSpawnDuraiton) {
                spawnDuration = minimumSpawnDuraiton;
            }
            spawnTimer = spawnDuration;
        }
    }
}
