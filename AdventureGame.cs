using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI storyTextComponent;

    [SerializeField]
    TextMeshProUGUI optionsTextComponent;

    [SerializeField]
    State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyTextComponent.text = state.GetStoryText();

        optionsTextComponent.text = "1. Try to get up<br>2. Wait for someone to rescue you";
    }

    // Update is called once per frame
    void Update() { }
}
