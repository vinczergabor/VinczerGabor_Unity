using System.Globalization;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

class Arrays : MonoBehaviour
{
    
    void Start()
    {
        int[] myFirstArray = new int[10];
		string[] myFirstStringArray = { "Alma", "Banan", "Citrom" };

		int element3 = myFirstArray[3];  // 0
		string element1 = myFirstStringArray[1];  // Banan

		myFirstArray[3] = 123;  //ertek beallitasa

		for (int i = 0; i < myFirstArray.Length; i++)
		{
			myFirstArray[i] = i + 1;
		}

		char myFirstChar = 'x';

		string myString = "Bear";
		char[] myCharArray = myString.ToCharArray();

		myCharArray[2] = 'e';
		string myNewString = new string(myCharArray);
		Debug.Log(myNewString); // "Beer"

    }

	float GetProduct(float[] array)
	{
		float result = 1f;

		for (int i = 0; i < array.Length; i++) {
			result *= array[i];
		}

		return result;
	}

	int[] GetSecondPowerArray(int number)
	{
		int[] array = new int[number];

		for(int i = 0; i < number; i++)
		{
			int n = i + i;
			array[n] = n * n;
			// array[i] = (i + 1) * (i + 1); altrantiv megoldas
		}
		return array;
	}

	int[] GetPowerArray(int number, int power)
	{
		int[] array = new int[number];

		for (int i = 0; i < number; i++)
		{
			int n = i + i;
			array[i] = Pow(n, power);
			
		}
		return array;
	}
	int Pow(int baseNum, int exp)
	{
		int result = 1;
		for (int i = 0; i < exp; i++)
		{
			result *= baseNum;
		}
		return result;
	}



	float MaxValue(float[] array)
	{
		if (array.Length == 0)
			return 0;

		float result = array[0];

		for (int i = 1; i < array.Length;i++)
		{
			if (result < array[i])
				result = array[i];
		}
		return result;
	}

	string[] Reverse(string[] word)
	{
		string[] result = new string[word.Length];

		// int step = word.Length -1; 

		for (int i = 0; i < result.Length; i++)
		{
			result[i] = word[word.Length -1 - i];
			// result[i] = word[^(i+1)]; tomboknel a ^ a visszafele indexelésre jo
			// step--;
		}
		return result;

	}

	void Reverse2(string[] array)
	{
		for (int i = 0; i < array.Length / 2; i++)
		{
			string temp = array[i];
			array[i] = array[^(i+1)];
			array[^(i + 1)] = temp;
		}
	}
}
