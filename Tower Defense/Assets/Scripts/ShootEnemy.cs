using UnityEngine;
using System.Collections;

public class ShootEnemy : MonoBehaviour {
    public int FireRate;
    public float range;
    private int level;
    private int maxLevel;
    private bool targetAquired;
    private Rigidbody2D target;
    private float timer;
	// Use this for initialization
	void Start () {
        level = 1;
        maxLevel = 3;
        range = 9 + level * 3;
        timer = 0f;
	}
	
	// Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (targetAquired)
        {
            float distance = Vector2.Distance(this.transform.position, target.transform.position);
            if (distance > range)
            {
                targetAquired = false;
                FindNewTarget();
            }
            if(timer >= FireRate)
            {
                timer = 0f;
                //fire
            }
        }
    }
    private void FindNewTarget()
    {
        Collider2D[] colls = Physics2D.OverlapCircleAll(this.transform.position, range);
        foreach(Collider2D col in colls)
        {
            if(col.tag == "Enemy")
            {
                target = col.GetComponent<Rigidbody2D>();
            }
        }
    }
	void OnTriggerEnter (Collider col) {
	    if(col.tag == "Enemy"&&!targetAquired)
        {
            targetAquired = true;
            target = col.GetComponent<Rigidbody2D>();
        }
	}

    public void Upgrade()
    {
        if (level < maxLevel)
        {
            level++;
            range = 9 + level * 3;
            FireRate *= 2;
        }
    }

    public int getLevel()
    {
        return level;
    }

    public int getMaxLevel()
    {
        return maxLevel;
    }
}
