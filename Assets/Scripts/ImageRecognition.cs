using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;

    public string logo1ImageName = "Cheesious_logo"; 
    public string logo1WebsiteURL = "https://www.cheezious.com/"; 

    public string logo2ImageName = "Kfc_logo"; 
    public string logo2WebsiteURL = "https://www.kfcpakistan.com/";

    public string logo3ImageName = "Ranchers_logo";
    public string logo3WebsiteURL = "https://rancherscafe.com/menupage/";

    public string logo4ImageName = "Hardees_logo";
    public string logo4WebsiteURL = "https://hardees.com.pk/";

    public string logo5ImageName = "PapaJohns_logo";
    public string logo5WebsiteURL = "https://www.papajohns.com.pk/categories/pizzas?locale=en-PK";

    public void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImagesChanged;
    }

    public void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImagesChanged;
    }

    public void OnImagesChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.referenceImage.name);

            if (trackedImage.referenceImage.name == logo1ImageName)
            {
                Application.OpenURL(logo1WebsiteURL);
            }

            else if (trackedImage.referenceImage.name == logo2ImageName)
            {
                Application.OpenURL(logo2WebsiteURL);
            }

            else if (trackedImage.referenceImage.name == logo3ImageName)
            {
                Application.OpenURL(logo3WebsiteURL);
            }

            else if (trackedImage.referenceImage.name == logo4ImageName)
            {
                Application.OpenURL(logo4WebsiteURL);
            }

            else if (trackedImage.referenceImage.name == logo5ImageName)
            {
                Application.OpenURL(logo5WebsiteURL);
            }
        }
    }
}
