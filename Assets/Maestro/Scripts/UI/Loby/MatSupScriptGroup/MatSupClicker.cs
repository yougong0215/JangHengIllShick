using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatSupClicker : MonoBehaviour
{
    [SerializeField] IngredientValues _ingredient = IngredientValues.Metal;


    [SerializeField] private GameObject _clickerContent;
    [SerializeField] private GameObject _materialImage;
    [SerializeField] private Vector3 _toMovePos;

    public void ClickFactory()
    {
        GameObject _mat = Instantiate(_materialImage, _clickerContent.transform);
        _mat.transform.localPosition = this.transform.localPosition;
        MatImage matImage = _mat.GetComponent<MatImage>();

        Ingreient.AddIngredent(_ingredient, 10);

        Debug.Log($"{_ingredient.ToString()} : {Ingreient.GetIngredent(_ingredient)}");



        matImage.MovePos(_toMovePos);
    }
}
