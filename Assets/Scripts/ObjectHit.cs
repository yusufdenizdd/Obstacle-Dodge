using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.turquoise;
        Debug.Log("biri bana çarptı");
    }
}
