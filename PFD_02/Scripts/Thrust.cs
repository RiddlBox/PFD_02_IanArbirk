using UnityEngine;

public class Thrust : MonoBehaviour
{
    public Transform planeTransform;
    public float moveIntensity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = direction + Vector3.up;   
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = direction + Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = direction + Vector3.right;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = direction + Vector3.down;
        }

        Debug.Log(direction);
        planeTransform.position = planeTransform.position + direction * moveIntensity * Time.deltaTime;

    }
}
