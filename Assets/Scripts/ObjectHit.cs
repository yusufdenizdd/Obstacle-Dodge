using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.turquoise;
            Debug.Log("benim adım " + gameObject + " ve biri bana çarptı");
            gameObject.tag = "Hit";
        }
    }
}
