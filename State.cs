using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "ScriptableObjects/State ", order = 1)]
public class State : ScriptableObject
{
    [TextArea(10, 14)]
    [SerializeField]
    string storyText;

    public string GetStoryText()
    {
        return storyText;
    }
}
