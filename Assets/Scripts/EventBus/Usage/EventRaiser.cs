using UnityEngine;

public class EventRaiser : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			EventBus<TestEvent>.Raise(new TestEvent());
		}
	}
}
