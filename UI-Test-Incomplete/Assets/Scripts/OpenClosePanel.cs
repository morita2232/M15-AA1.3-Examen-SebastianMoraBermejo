using UnityEngine;

public class OpenClosePanel : MonoBehaviour
{
    public GameObject testPanel;
    public GameObject openButton;
    public GameObject closeButton;


    public void OpenPanel()
    {
        if (testPanel != null) { 
        
            testPanel.SetActive(true);

        }

        if (openButton != null)
        {
            openButton.SetActive(false);
        }

        if (closeButton != null)
        {
            closeButton.SetActive(true);
        }

    }


    public void ClosePanel()
    {
        if ( testPanel != null )
        {
            testPanel.SetActive(false);
        }

        if ( openButton != null )
        {
            openButton.SetActive(true);
        }

        if( closeButton != null)
        {
            closeButton.SetActive(false);
        }

    }

}
