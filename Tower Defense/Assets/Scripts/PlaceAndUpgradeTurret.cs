using UnityEngine;
using System.Collections;

public class PlaceAndUpgradeTurret : MonoBehaviour {
    public GameObject TowerPrefab;
    private int baseCost = 100;
    private bool towerPlaced = false;
	// Use this for initialization
	void OnMouseUpAsButton() {
        if (!towerPlaced && ManageScore.CanSpendPoints(baseCost)){
            ManageScore.SpendPoints(baseCost);
            GameObject g = (GameObject)Instantiate(TowerPrefab);
            g.transform.position = transform.position + Vector3.back;
        }
	}
}
