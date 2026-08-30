using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    float dropTime;
    bool hasDropped = false;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;

        dropTime = Time.time + timeToWait;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time + " kadar zaman geçti");

        if (Time.time > dropTime && hasDropped == false)
        {
            Debug.Log("YUKARI BAK!");
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
            hasDropped = true;
        }
    }
}
