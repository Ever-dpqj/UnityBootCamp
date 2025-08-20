using UnityEngine;
using UnityEngine.Events;

public class EventSample3 : MonoBehaviour
{
    public UnityEvent OnKButtonEnter;
    public UnityAction OnAction;

    private void Start()
    {
        //OnKButtonEnter += Sample;
        OnKButtonEnter.AddListener(Sample);
        OnAction += Sample2;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            OnKButtonEnter?.Invoke();
        }
    }

    private void Sample()
    {
        Debug.Log("<color=cyan>Sample 실행</color>");
    }
    private void Sample2()
    {
        Debug.Log("<color=cyan>Sample2 실행</color>");
    }
}
