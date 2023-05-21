using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public enum QuizOptions { A, B, C, D };
    [SerializeField] QuizOptions answer;
}
