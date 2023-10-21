using System.Collections.Generic;
using UnityEngine;

class List : MonoBehaviour
{
	private void Start()
	{
		// letrehozas, a fenti sor is jo, ez rovidebb
		// List<Vector3> myFirstList = new List<Vector3>();
		List<Vector3> myFirstList = new();  

		// feltoltesek
		myFirstList.Add(new Vector3(1, 2, 3)); 
		myFirstList.Add(transform.position);

		// indexeles
		Vector3 element = myFirstList[1]; 
		myFirstList[2] = Vector3.down;

		//Muveletek
		myFirstList.Remove(Vector3.down); // spec elem kivetele
		//myFirstList.Remove(3);	// x. elem kivetele
		myFirstList.Insert(0, Vector3.right);// beillesztes a megfelelo helyre

		bool doesContain = myFirstList.Contains(Vector3.zero); // tratalamazza e

		myFirstList.Sort(); // lista sorbarendezese

		myFirstList.Clear(); // lista torlese

		for (int i = 0; i < myFirstList.Count; i++)
		{
			Vector3 item = myFirstList[i];
			Debug.Log(item);
		}

		// a foreach olyan helyeken hasznalhato, amiknek elemei vannak (lista, tomb)

		foreach(Vector3 item in myFirstList)
		{
			Debug.Log(item);
		}
		
	}
}
