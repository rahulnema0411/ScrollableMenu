using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class TouchScrollMenu : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

    public Button homeButton, shopButton, friendsButton, leaderBoardButton, settingsButton;
    public ScrollRect scrollRect;
    public Scrollbar scrollbar;

    Vector3 pointerUpPosition, pointerDownPosition;

    public void ShowHome() {
        scrollRect.DOHorizontalNormalizedPos(0.00f, 0.2f);
    }

    public void ShowShop() {
        scrollRect.DOHorizontalNormalizedPos(1.00f, 0.2f);
    }

    public void ShowLeaderBoard() {
        scrollRect.DOHorizontalNormalizedPos(0.75f, 0.2f);
    }

    public void ShowSettings() {
        scrollRect.DOHorizontalNormalizedPos(0.50f, 0.2f);
    }

    public void ShowFriends() {
        scrollRect.DOHorizontalNormalizedPos(0.25f, 0.2f);
    }

    public void OnPointerUp(PointerEventData eventData) {
        pointerUpPosition = Input.mousePosition;
        if((pointerDownPosition.x - pointerUpPosition.x) > 0) {
            if(scrollbar.value + 0.25f <= 1.00f) {
                scrollRect.DOHorizontalNormalizedPos(scrollbar.value + 0.25f, 0.2f);
            }
        } else {
            if (scrollbar.value - 0.25f >= 0.00f) {
                scrollRect.DOHorizontalNormalizedPos(scrollbar.value - 0.25f, 0.2f);
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        pointerDownPosition = Input.mousePosition;
    }
}
