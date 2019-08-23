using UnityEngine;

public class RemoveSphereHandler: MonoBehaviour
{
    public void RemoveSphere(GameObject sphere)
    {
        sphere.SetActive(false);
    }
}
