using UnityEngine;
using System.Collections;

public class ManageScore : MonoBehaviour {
    private static int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}

    public static int getScore()
    {
        return score;
    }

    public static void AddToScore(int i)
    {
        score += i;
    }

    public static bool SpendPoints(int i)
    {
        if (i <= score)
        {
            score -= i;
            return true;
        }
        return false;
    }
    public static bool CanSpendPoints(int i)
    {
        return i <= score;
    }
}
