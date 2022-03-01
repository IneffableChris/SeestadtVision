using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    //public GameObject furniture;
    private Button btn;
    [SerializeField]private RawImage buttonImage;

    private int _itemId;
    private Sprite _buttonTexture;
    public Sprite ButtonTexture
    {
        set
        {
            _buttonTexture = value;
            buttonImage.texture = _buttonTexture.texture;
        }
    }

    public int ItemId
    {
        set { _itemId = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    void Update()
    {
        if (UIManager.Instance.OnEntered(gameObject))
        {
            //  transform.localScale = Vector3.one * 2;
            transform.DOScale(Vector3.one * 2, 0.3f);
        }
        else
        {
            //   transform.localScale = V
            transform.DOScale(Vector3.one, 0.3f);
         
        }
    } 

    void SelectObject()
    {
        DataHandler.Instance.SetFurniture(_itemId);
    }
}
