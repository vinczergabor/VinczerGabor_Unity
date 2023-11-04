using System.Collections;
using UnityEngine;

class AutoDestroy : MonoBehaviour
{
	[SerializeField] float lifeTime = 5;
	[SerializeField] float maxDistance = 10;
	[SerializeField] bool destroyOnCollision;

	Vector3 startPos;

	void Start()
	{
		StartCoroutine(MyCoroutine());
		startPos = transform.position;
	}

	IEnumerator MyCoroutine()
	{
		yield return new WaitForSeconds(lifeTime);
		Destroy(gameObject);
	}

	void Update()
	{
		Vector3 cp = transform.position;
		bool isOutSideOfRange = Vector3.Distance(cp, startPos) > maxDistance;

		if (isOutSideOfRange)
			Destroy(gameObject);


	}

	private void OnCollisionEnter(Collision collision)
	{
		if(destroyOnCollision)
			Destroy(gameObject);
		
	}

	/*
	
	private void Start()
	{
		Invoke(nameof(DestroySelf), lifeTime);	// Option 2
		Destroy(gameObject, lifeTime);			// Option 3
	}

	
	float age = 0;

	void Update()
	{
		age += Time.deltaTime;

		if (age >= lifeTime)
			Destroy(gameObject);
	}
	
	void DestroySelf() { Destroy(gameObject); } // Option 2
	*/
}