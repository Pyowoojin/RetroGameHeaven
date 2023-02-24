using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
	[Flags]
	enum WallStatus
	{
		up = 0x1000,
		right = 0x0100,
		down = 0x0010,
		left = 0x0001,
		
		All = up | right | left | down
	}

	public bool visited = false;
	public GameObject[] wall;

	private void Start()
	{
		GridSetting();
	}

	void GridSetting()
	{
		WallStatus status = WallStatus.All;

		// 줄일 방법을 찾자.
		if((status & WallStatus.up) == 0)
		{
			this.wall[1].SetActive(false);
		}
		else if((status & WallStatus.right) == 0)
		{
			this.wall[2].SetActive(false);
		}
		else if ((status & WallStatus.down) == 0)
		{
			this.wall[3].SetActive(false);
		}
		else if ((status & WallStatus.left) == 0)
		{
			this.wall[4].SetActive(false);
		}
	}

}
