using UnityEngine;

public class SpinPropeller : MonoBehaviour
{

    private float propellerSpeed = 1500f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
