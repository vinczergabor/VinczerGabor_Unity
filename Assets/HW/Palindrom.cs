using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palindrom : MonoBehaviour
{
    [SerializeField] string word;
    [SerializeField] bool result;

    bool PalindromChecker(string subject)
    {
        if (subject == null)
            return false;

        char[] characters = subject.ToCharArray();

        for(int i = 0; i < characters.Length / 2; i++)
        {
            if (characters[i] != characters[characters.Length - 1 - i])
                return false;
        }

        return true;
    }

	private void OnValidate()
	{
        result = PalindromChecker(word);
	}
}
