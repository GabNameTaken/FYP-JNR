using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mastermind : MonoBehaviour
{
    [SerializeField] int attempts;
    [SerializeField] int slots;

    [SerializeField] GameObject correctMarker, differentMarker, wrongMarker;

    int[] slotNumbers;

    int[] guesses;

    
}
