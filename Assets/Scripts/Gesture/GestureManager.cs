using UnityEngine;


namespace Academy.HoloToolkit.Unity
{
    /// <summary>
    /// GestureManager contains event handlers for subscribed gestures.
    /// </summary>
    public class GestureManager : MonoBehaviour
    {
        private UnityEngine.XR.WSA.Input.GestureRecognizer gestureRecognizer;

        void Start()
        {
            gestureRecognizer = new UnityEngine.XR.WSA.Input.GestureRecognizer();
            gestureRecognizer.SetRecognizableGestures(UnityEngine.XR.WSA.Input.GestureSettings.Tap);

            gestureRecognizer.TappedEvent += (source, tapCount, ray) =>
            {
                GameObject focusedObject = InteractibleManager.Instance.FocusedGameObject;

                if (focusedObject != null)
                {
                    focusedObject.SendMessage("OnSelect");
                }
            };

            gestureRecognizer.StartCapturingGestures();
        }

        void OnDestroy()
        {
            gestureRecognizer.StopCapturingGestures();
        }
    }
}