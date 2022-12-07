using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewHandler : MonoBehaviour
{

    [SerializeField] GameObject player;
    PlayerMovement playerMovement;
    ScrollRect scrollRect;
    float hor;
    float ver;
    //bool once = false;
    private void Start()
    {
        
        scrollRect = GetComponent<ScrollRect>();
        playerMovement= player.GetComponent<PlayerMovement>();


        //float scrollValue = 1 + _element.anchoredPosition.y / scrollRect.content.GetHeight();
        //scrollRect.verticalScrollbar.value = _scrollValue;
    }
    private void Update()
    {
        handleInput();
    }

    private void handleInput()
    {
        if (Input.GetMouseButton(0) )
        {
            //if (Input.multiTouchEnabled) Input.multiTouchEnabled = false;
            hor = (scrollRect.horizontalScrollbar.value - 0.5f) * 2;
            ver = (scrollRect.verticalScrollbar.value - 0.5f) * 2;
            //Debug.Log("Horizontal: " + hor + "Vertical " + ver);
            playerMovement.direction = new Vector2(-hor, -ver);
            //GameManager.Instance.Console("Player has moved " + playerMovement.direction);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //Input.multiTouchEnabled = true;
            scrollRect.horizontalScrollbar.value = 0.5f;
            scrollRect.verticalScrollbar.value = 0.5f;
            playerMovement.direction = Vector2.zero;
        }
    }
    /*
    
    

For desktops:

    Mouse Down - Input.GetMouseButtonDown
    Mouse Up - Input.GetMouseButtonUp

Example:

if (Input.GetMouseButtonDown(0))
{
    Debug.Log("Mouse Pressed");
}

if (Input.GetMouseButtonUp(0))
{
    Debug.Log("Mouse Lifted/Released");
}

For Mobile devices:

    Touch Down - TouchPhase.Began
    Touch Up - TouchPhase.Ended

Example:

if (Input.touchCount >= 1)
{
    if (Input.touches[0].phase == TouchPhase.Began)
    {
        Debug.Log("Touch Pressed");
    }

    if (Input.touches[0].phase == TouchPhase.Ended)
    {
        Debug.Log("Touch Lifted/Released");
    }
}


     */
}