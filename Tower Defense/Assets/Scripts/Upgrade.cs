using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
    private int baseCost;
	// Use this for initialization
	void Start () {
        baseCost = 100;
	}
	
	// Update is called once per frame
	void OnMouseUpAsButton () {
        ShootEnemy se = GetComponent<ShootEnemy>();
        if (se.getLevel() < se.getMaxLevel() && ManageScore.CanSpendPoints(baseCost*se.getLevel()))
        {
            GetComponent<ShootEnemy>().Upgrade();
            ManageScore.SpendPoints(baseCost * se.getLevel());
        }
        
	}
}
