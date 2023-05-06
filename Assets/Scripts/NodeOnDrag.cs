using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class NodeOnDrag : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    //private Transform trans;
    public Transform originalParent;
    
    private int currentItemID;//��ǰ��ƷID

    private void Start()
    {
        //trans = GetComponent<Transform>();
        Debug.Log("start");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        //currentItemID = originalParent.GetComponent<Slot>().slotID;
        //transform.SetParent(transform.parent.parent.parent.parent);
        //transform.SetParent(transform.parent.parent);
        transform.position = eventData.position;

        //GetComponent<CanvasGroup>().blocksRaycasts = false;//�����赲�ر�
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        
        //transform.position = eventData.position;
            //trans.position += new Vector3(eventData.delta);
        //transform.position = Input.mousePosition;
        //Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        // if (eventData.pointerCurrentRaycast.gameObject.name == "Item_Image")//�������ItemImage�򻥻�λ��
        // {
        //     transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform.parent.parent);
        //     transform.position = eventData.pointerCurrentRaycast.gameObject.transform.parent.parent.position;
        //     //����itemList����Ʒ�洢λ��
        //     // var temp = myBag.itemList[currentItemID];
        //     // myBag.itemList[currentItemID] = myBag.itemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID];
        //     // myBag.itemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID] = temp;

        //     eventData.pointerCurrentRaycast.gameObject.transform.parent.position = originalParent.position;
        //     eventData.pointerCurrentRaycast.gameObject.transform.parent.SetParent(originalParent);

        //     GetComponent<CanvasGroup>().blocksRaycasts = true;//�����赲�����������޷��ٴ�ѡ����Ʒ
        //     return;
        // }
        // else if (eventData.pointerCurrentRaycast.gameObject.name == "Item_Slot(Clone)")//������ǿո��򻥻�λ��
        // {
        //     transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform);
        //     transform.position = eventData.pointerCurrentRaycast.gameObject.transform.position;
        //     //����itemList����Ʒ�洢λ��
        //     // myBag.itemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID] = myBag.itemList[currentItemID];
        //     // //�����Ʒ�Ż�ԭλ������
        //     // if(eventData.pointerCurrentRaycast.gameObject.GetComponent<Slot>().slotID != currentItemID)
        //     //     myBag.itemList[currentItemID] = null;
        //     GetComponent<CanvasGroup>().blocksRaycasts = true;
        //     return;
        // }
        // else
        // {
        //     transform.position = originalParent.position;
        //     transform.SetParent(originalParent);
        //     GetComponent<CanvasGroup>().blocksRaycasts = true;
        //     return;
        // }
        // GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

   

}