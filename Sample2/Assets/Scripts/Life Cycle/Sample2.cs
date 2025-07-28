using UnityEngine;

public class Sample2 : MonoBehaviour
{
    public Sample1 sample1;
    private void Awake()
    {
        sample1 = GameObject.FindWithTag("s1").GetComponent<Sample1>();
        Debug.Log(sample1.cc.message);

    }
}
