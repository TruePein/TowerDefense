using UnityEngine;
using System.Collections;

public class TurnEnemy : MonoBehaviour {
    public int vertical;
    public int horizontal;
	public void OnTriggerEnter(Collider col)
    {
        float speed = SpeedController.Speed;
        if(col.tag == "Enemy")
        {
            col.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal>0?speed:-speed, vertical>0?speed:-speed);
        }
    }
}
