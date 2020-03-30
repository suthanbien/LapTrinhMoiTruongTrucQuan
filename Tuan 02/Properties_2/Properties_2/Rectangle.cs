﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_2
{
	class Rectangle
	{
		private int m_Length;
		private int m_Width;
		private int m_Area;

		public Rectangle()
		{
			m_Length = 3;   //<=> Length = 3;
			m_Width = 2;
		}
		public int Length
		{
			get
			{
				return m_Length;
			}
			set
			{
				if (m_Length < 0) return;
				m_Length = value;
			}

		}
		public int Width
		{
			get
			{
				return m_Width;
			}
			set
			{
				// Đọan mã kiểm tra giá trị …..
				m_Width = value;
			}
		}
		public int Area
		{
			get
			{
				return m_Area;
			}
		}

		public void CalArea()
		{
			m_Area = m_Length * m_Width;
		}
	}
	}
