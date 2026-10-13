using UnityEngine;

public class UnityVariables : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   [SerializeField] private int variable = 99;//Serializo aquellas variables privadas, pero que necesite
   //usar o modificar en el inspector

    public Color color = new Color(0f, 0f, 0f, 0f);

    public int getVariable()
    {
        return variable;
    }

    public void setVariable(int value)
    {
        variable = value;
    }

    void Start()
    {
        Debug.Log("Star()" + gameObject.name);
        Debug.Log(variable);
        Debug.Log(color);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
