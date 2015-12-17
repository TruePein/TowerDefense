using UnityEngine;
using System.Collections;

public class SpeedController : MonoBehaviour {
    public static float Speed;
    public static float SpawnDelay;
    public float startSpeed;
    public float startSpawnDelay;
    private float timer;
	// Use this for initialization
	void Start () {
        Speed = startSpeed;
        SpawnDelay = startSpawnDelay;
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 10f)
        {
            timer -= 10f;
            Speed *= 1.1f;
            SpawnDelay *= 0.9f;
        }
	}
}
