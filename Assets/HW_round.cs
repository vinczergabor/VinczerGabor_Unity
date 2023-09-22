
using UnityEngine;

class HW_round : MonoBehaviour
{
    [SerializeField] float baseNumber, floorNumber, ceilNumber, roundNumber;
    float Floor(float floor)
    {
        float reminder = floor % 1;
        if (reminder < 0)
            reminder = 1 + reminder;

        return floor - reminder;
    }

    float Ceil (float ceil)
    {
        float reminder = ceil % 1;
        if (reminder == 0)
            return ceil;

        return ceil + (1 - reminder);
    }

    float Round(float round)
    {
        float reminder = round % 1;
        if (reminder > 0.5f)
            return Ceil(round);
        else
            return Floor(round);
    }

    void OnValidate()
    {
        floorNumber = Floor(baseNumber);
        ceilNumber = Ceil(baseNumber);
        roundNumber = Round(baseNumber);
    }
}
