using UnityEngine;
using System.Collections;

public class WeaponPickup : MonoBehaviour {
	//public string name;
	public float fireRate;
	WeaponAttack wa;
    public bool gun, OneHanded;

    void Start()
    {
		wa = GameObject.FindGameObjectWithTag ("Player").GetComponent<WeaponAttack> ();
	}
	

	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D coll) {
		Debug.Log("Colission");
		if (coll.gameObject.tag == "Player" && Input.GetMouseButtonDown(1)){
		
			Debug.Log("Player picked up: " + name);
			if (wa.getCur () != null) {
				wa.dropWeapon ();
			}
			wa.setWeapon (this.gameObject,name,fireRate,gun,OneHanded);
			this.gameObject.SetActive (false);

			}
		
		}
	}

