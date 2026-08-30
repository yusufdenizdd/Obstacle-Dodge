using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationXvalue = 0;
    [SerializeField] float rotationYvalue = 50f;
    [SerializeField] float rotationZvalue = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = rotationXvalue * Time.deltaTime;
        float y = rotationYvalue * Time.deltaTime;
        float z = rotationZvalue * Time.deltaTime;

        transform.Rotate(x, y, z);
    }
}
