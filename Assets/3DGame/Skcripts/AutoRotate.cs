using UnityEngine;

class AutoRotate : MonoBehaviour
{
    [SerializeField] float angularSpeed = 300;

    

    void Update()
    {
        transform.Rotate(0, angularSpeed* Time.deltaTime, 0);
    }

    

}
