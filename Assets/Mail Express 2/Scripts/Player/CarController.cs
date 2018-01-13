using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public sealed class CarController : MonoBehaviour 
{
	public ButtonController buttonControllerLeft;
	public ButtonController buttonControllerRight;
	[SerializeField] float speedCar_fl;
	
	private void Update()
	{
		MovementCar(speedCar_fl);
	}
	public void MovementCar(float speedCar_fl)
	{
		float Direction;

		Direction = buttonControllerLeft.pulsed_bo ? -1 : (buttonControllerRight.pulsed_bo ? 1 : Input.GetAxisRaw("Horizontal")); 
		
		float posX = transform.position.x + (Direction * speedCar_fl * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX,-8,8), transform.position.y,transform.position.z);
	}
}
