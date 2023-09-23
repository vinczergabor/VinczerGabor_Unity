using UnityEngine;

class LoopPractice : MonoBehaviour
{
    
    void Start()
    {
        

        //int i = 1;
        int found = 0;

        for (int i = 1; found < 100;i++)
        {
            if (i%7 == 0 || i%3 == 0)
            {
                Debug.Log(i);
                found++;
            }
            
        }

    }

}
