using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You bumped " + hits + " different objects");
        }
    }
}
