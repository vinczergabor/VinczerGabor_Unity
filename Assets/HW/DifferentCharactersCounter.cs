using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentCharactersCounter : MonoBehaviour
{
    [SerializeField] string word;
    [SerializeField] int differentChars;

    int CharCounter(string subject)
    {
        List<char> allChars = new List<char>();

        foreach (char a in subject)
        {
            if(!allChars.Contains(a))
				allChars.Add(a);
		}
        return allChars.Count;

    }

	private void OnValidate()
	{
        differentChars = CharCounter(word);
	}
}
