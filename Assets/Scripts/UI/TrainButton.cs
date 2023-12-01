using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TrainButton : MonoBehaviour
{
    [SerializeField] private NeuronsTrainer neuronsTrainer;

    private void OnMouseDown()
    {
        neuronsTrainer.Train();
        Debug.Log("Train button clicked");
    }

}
