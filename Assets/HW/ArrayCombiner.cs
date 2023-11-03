using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCombiner : MonoBehaviour
{
    [SerializeField] string[] a = { "Alma", "Korte", "Barack" };
    [SerializeField] string[] b = { "Cukor", "Feherje", "Szenhidrat" };
    [SerializeField] string[] c = new string[6];



    string[] Combiner(string[] x, string[] y)
    {
        string[] result = new string[x.Length + y.Length];

        for (int i = 0; i < x.Length; i++)
            result[i] = x[i];

        for (int i = 0; i < y.Length; i++)
            result[x.Length + i] = y[i];

        return result;
    }


	private void OnValidate()
	{
        int lengtOfStings = Combiner(a, b).Length;
        

        for (int i = 0; i < lengtOfStings; i++)
        {
            c[i] = Combiner(a, b)[i];
        }

        
	}


}
