using UnityEngine;

class StepMover : MonoBehaviour
{
    [SerializeField] float speed = 1;

    Vector3 objectPosition;

    void Start()
    {
        objectPosition = transform.position;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            objectPosition += Vector3.up * speed;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            objectPosition += Vector3.down * speed;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            objectPosition += Vector3.left * speed;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            objectPosition += Vector3.right * speed;

        transform.position = objectPosition;
    }
}
