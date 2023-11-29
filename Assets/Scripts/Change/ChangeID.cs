using TMPro;
using UnityEngine;

public class ChangeID : MonoBehaviour
{
    [SerializeField] private TMP_Text ChangeArea;
    [SerializeField] private TMP_Text ChangeNname;
    [SerializeField] private GameObject label;

    private void changeName()
    {
        PlayerPrefs.SetString("name", ChangeArea.text);
        ChangeNname.text = ChangeArea.text;
        label.SetActive(false);
    }
    private void ViewChangeID()
    {
        ChangeArea.text = PlayerPrefs.GetString("name");
        label.SetActive(true);
    }
}
