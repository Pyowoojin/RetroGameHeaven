using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
	[SerializeField] private int _width, _height;

	[SerializeField] public Cell _tilePrefab;
	[SerializeField] private Transform _cam;


	private void Start()
	{
		GenerateGrid();
	}
	void GenerateGrid()
	{
		for(int i = 0; i < _width; i++)
		{
			for(int j = 0; j < _height; j++)
			{
				var spawnedTile = Instantiate(_tilePrefab, new Vector3(i, j), Quaternion.identity);
				spawnedTile.name = $"Tile {i} {j}";

				var isOffset = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
				// ��ũ��Ʈ ���� Tile �������� ������ ����
				// spawnedTile.Init(isOffset);
			}
		}

		_cam.transform.position = new Vector3((float)_width / 2 - 0.5f, _height / 2 - 0.5f, -10);
	}
}
