  using UnityEngine;
using TMPro;

[RequireComponent(typeof(SyncedPuzzle))]
public class PCLogin : MonoBehaviour
{
    SyncedPuzzle syncedPuzzle;

    [SerializeField] string pcName;

    public TMP_InputField passwordInput;
    public string password;
    [SerializeField] GameObject pcScreen, printer;
    public int tipNum;
    Hints hints;
    Tips tips;
    public GameObject toDisable;

    public bool printer_puzzle, hasTip;

    private void Awake()
    {
        syncedPuzzle = GetComponent<SyncedPuzzle>();
        hints = FindObjectOfType<Hints>();
        tips = FindObjectOfType<Tips>();
    }
    private void OnEnable()
    {
        syncedPuzzle.onSolvedPuzzle += OnSolvedPuzzle;
    }
    private void OnDisable()
    {
        syncedPuzzle.onSolvedPuzzle -= OnSolvedPuzzle;
    }

    public void PasswordCheck()
    {
        if (passwordInput.text.ToUpper() == password.ToUpper())
        {
            syncedPuzzle.CallSyncSolvePuzzle();
        }
        else
        {
            GameSoundManager.PlaySound("Error");
        }
    }
    public void OnSolvedPuzzle()
    {
        GameSoundManager.PlaySound("PCLogin");

        pcScreen.SetActive(true);
        toDisable.SetActive(false);
        hints.CompletedPuzzle(pcName);

        if (hasTip)
        {
            tips.SetTipActive(tipNum);
        }
        if (printer_puzzle)
        {
            printer.GetComponent<Printer>().CompletedPC();
        }
    }

    public void ShowHide_Password()
    {
        if (passwordInput.inputType == TMP_InputField.InputType.Password) // Reveal Password
        {
            passwordInput.inputType = TMP_InputField.InputType.Standard;
        }
        else // Hides password
        {
            passwordInput.inputType = TMP_InputField.InputType.Password;
        }
        passwordInput.ForceLabelUpdate();
    }
}
