using UnityEngine;
using UnityEngine.UI;

public class CarHealth : MonoBehaviour 
{
	public static CarHealth carHealth;
	
	[Header("Health Car")]
	public Image 			imageHealthCar1_im;
	public Image 			imageHealthCar2_im;
	public Image 			imageHealthCar3_im;
	public GameObject 		CarMain;

	private void Awake()
	{
		if(!carHealth)
		{
			carHealth = this;
		}
		else
		{
			Destroy(this);
		}
	}
	private void Update()
	{
		LowHealth();
	}
	private void LowHealth()
	{
		if(imageHealthCar1_im.fillAmount <= 0)
		{
			Destroy(imageHealthCar1_im);
		}
		if(imageHealthCar2_im.fillAmount <= 0)
		{
			Destroy(imageHealthCar2_im);
		}
		if(imageHealthCar3_im.fillAmount <= 0)
		{
			Destroy(CarMain);
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if(imageHealthCar1_im && other.gameObject.tag == "Enemy")
		{
			imageHealthCar1_im.fillAmount -= 0.3f;
		}
		if(!imageHealthCar1_im && other.gameObject.tag == "Enemy")
		{
/*SUGERENCIA: Activar un efecto de daño del auto */
			imageHealthCar2_im.fillAmount -= 0.3f;
		}
		if(!imageHealthCar2_im && other.gameObject.tag == "Enemy")
		{
			imageHealthCar3_im.fillAmount -= 0.3f;
		}
	}
}
