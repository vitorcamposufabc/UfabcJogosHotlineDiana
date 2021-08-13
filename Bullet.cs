using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	public Vector3 direction;
	public string creator;
	EnemyAttacked attacked;
	public GameObject bloodImpact, wallImpact;

	float timer = 10.0f;


	void Start()
	{

	}

	void Update()
	{
		transform.Translate(direction * 17 * Time.deltaTime);

		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	public void setVals(Vector3 dir, string name)
	{
		direction = dir;
		creator = name;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			attacked = col.gameObject.GetComponent<EnemyAttacked>();
			attacked.killBullet();
			Instantiate(bloodImpact, this.transform.position, this.transform.rotation);
			Destroy(this.gameObject);
		}
		else
		{
			Instantiate(wallImpact, this.transform.position, this.transform.rotation);
			Destroy(this.gameObject);

		}
	}
}