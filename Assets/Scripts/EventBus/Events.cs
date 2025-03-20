using UnityEngine;

public interface IEvent { }

public struct TestEvent : IEvent { }

public struct PlayerEvent : IEvent
{
	public int health;
	public int mana;
}

public struct PlayerSpawnEvent : IEvent
{
	public Vector3 position;
	public string name;
}