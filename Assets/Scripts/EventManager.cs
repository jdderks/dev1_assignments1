using System.Collections.Generic;
/// <summary>
/// This class is for a generic eventlistener
/// </summary>
public enum EventEnum
{
    ON_GAME_START = 0
}

public static class EventManager
{

    public delegate void VoidDelegate();
    private static Dictionary<EventEnum, System.Action> eventDictionary = new Dictionary<EventEnum, System.Action>();

    public static void AddListener(EventEnum type, System.Action function)
    {
        if (!eventDictionary.ContainsKey(type))
        {
            eventDictionary.Add(type, null);
        }
        eventDictionary[type] += function;
    }

    public static void RemoveListener(EventEnum type, System.Action function)
    {
        if (eventDictionary.ContainsKey(type) && eventDictionary[type] != null)
        {
            eventDictionary[type] -= function;
        }
    }

    public static void RaiseEvent(EventEnum type) //invokes / execues the event
    {
        eventDictionary[type]?.Invoke();
    }
}

public static class EventManagerWithGeneric<T>
{

    public delegate void VoidDelegate();
    private static Dictionary<EventEnum, System.Action<T>> eventDictionary = new Dictionary<EventEnum, System.Action<T>>();

    public static void AddListener(EventEnum type, System.Action<T> function)
    {
        if (!eventDictionary.ContainsKey(type))
        {
            eventDictionary.Add(type, null);
        }
        eventDictionary[type] += function;
    }

    public static void RemoveListener(EventEnum type, System.Action<T> function)
    {
        if (eventDictionary.ContainsKey(type) && eventDictionary[type] != null)
        {
            eventDictionary[type] -= function;
        }
    }

    public static void RaiseEvent(EventEnum type, T arg1) //invokes / execues the event
    {
        eventDictionary[type]?.Invoke(arg1);
    }
}