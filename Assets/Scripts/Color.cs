using DG.Tweening;
using UnityEngine;

public class Color : MonoBehaviour
{
	[SerializeField] private SpriteRenderer _spriteRenderer;
	[SerializeField] private Color32 _color;

	private float _duration = 2f;

	void Start()
	{
		_spriteRenderer.DOColor(_color,_duration);
	}
}
