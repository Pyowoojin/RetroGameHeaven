using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private Color _baseColor, _offSetColor;
	[SerializeField] private SpriteRenderer _spriteRenderer;

	public void Init(bool isOffset)
	{
		_spriteRenderer.color = isOffset ? _offSetColor : _baseColor;
	}
}
