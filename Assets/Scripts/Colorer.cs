using DG.Tweening;
using UnityEngine;

public class Colorer : DORepeatedTransform
{
	[SerializeField] private SpriteRenderer _spriteRenderer;
	[SerializeField] private Color32 _color;

	private void Start()
	{
		_spriteRenderer.DOColor(_color, Duration).SetLoops(Repeats, LoopType);
	}
}