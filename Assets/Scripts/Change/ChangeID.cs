using TMPro;
using UnityEngine;

public class ChangeID : MonoBehaviour
{
    [SerializeField] private TMP_Text ChangeArea;
    [SerializeField] private TMP_Text ChangeNname;
    [SerializeField] private TMP_Text ChangeNname1;
    [SerializeField] private GameObject label;

    private void changeName()
    {
        PlayerPrefs.SetString("name", ChangeArea.text);
        ChangeNname.text = ChangeArea.text;
        ChangeNname1.text = ChangeArea.text;
        label.SetActive(false);
    }
    private void ViewChangeID()
    {
        ChangeArea.text = PlayerPrefs.GetString("name");
        label.SetActive(true);
    }
}
