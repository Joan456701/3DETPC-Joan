using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Use();

    public void Throw()
    {
        Debug.Log("Throw the object");
    }
}
