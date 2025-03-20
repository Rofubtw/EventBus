using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{

	EventBinding<TestEvent> testEventBinding;

	private void OnEnable()
	{
		testEventBinding = new EventBinding<TestEvent>(OnTestEvent);

		EventBus<TestEvent>.Register(testEventBinding);
	}

	private void OnDisable()
	{
		EventBus<TestEvent>.Deregister(testEventBinding);
	}

	private void OnTestEvent(TestEvent e)
	{
		Debug.Log("Test event received");
	}
}
