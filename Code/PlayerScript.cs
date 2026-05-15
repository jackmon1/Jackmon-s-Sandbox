using Sandbox;
using System.Linq;

public sealed class PlayerScript : Component
{


	protected override void OnUpdate()
	{
		if (IsProxy) 
			return;

		if ( !Input.AnalogMove.IsNearZeroLength )
		{
			WorldPosition += Input.AnalogMove.Normal * Time.Delta * 100.0f;	
		}

		var camera = Scene.GetAllComponents<CameraComponent>().FirstOrDefault();
		camera.WorldRotation = new Angles( 45, 0, 0 );
		camera.WorldPosition  = WorldPosition  + camera.WorldRotation.Backward * 1500;





		
	}
}
