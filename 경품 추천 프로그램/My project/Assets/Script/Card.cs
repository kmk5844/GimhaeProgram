using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour,IPointerClickHandler
{
    public GameObject Text;
    public GameObject button;
    public Image targetImage;
    public Sprite frontSprite;
    public Sprite backSprite;

    public void OnPointerClick(PointerEventData eventData)
    {
        targetImage.sprite = frontSprite;
        Text.SetActive(true);
        button.SetActive(true);
    }

    public void OnAllOpen()
    {
        targetImage.sprite = frontSprite;
        Text.SetActive(true);
        button.SetActive(true);
    }

    public void OnChangeButton()
    {
        targetImage.sprite = backSprite;
        Text.SetActive(false);
        button.SetActive(false);
        Director directorObject = GameObject.Find("Director").GetComponent<Director>();
        directorObject.ChangeList(transform.gameObject);
    }
}
