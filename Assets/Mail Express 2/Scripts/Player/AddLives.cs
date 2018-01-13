using UnityEngine;

public class AddLives : MonoBehaviour 
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			if(CarHealth.carHealth.imageHealthCar1_im)
			{
				CarHealth.carHealth.imageHealthCar1_im.fillAmount += 0.3f;
			}
			if(CarHealth.carHealth.imageHealthCar2_im)
			{
				CarHealth.carHealth.imageHealthCar2_im.fillAmount += 0.3f;
			}
			if(CarHealth.carHealth.imageHealthCar3_im)
			{
				CarHealth.carHealth.imageHealthCar3_im.fillAmount += 0.3f;
			}
			Destroy(FunctionExtras.extraLives.liveExtra);
		}
	}
}
