using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] cards;
    [SerializeField] private GameObject[] texts;

    [SerializeField] private AudioSource uiSFX;
    
    public void CardClick(int index)
    {
        uiSFX.Play();

        for (int i = 0; i < cards.Length; i++)
        {
            if(i == index)
            {
                texts[i].SetActive(true);
                cards[i].SetActive(true);
            }
            else
            {
                texts[i].SetActive(false);
                cards[i].SetActive(false);
            }
        }
    }
}
