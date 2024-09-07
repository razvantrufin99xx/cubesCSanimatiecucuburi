/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/8/2024
 * Time: 1:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cubes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Graphics g;
		public Pen p = new Pen(	Color.Black);
		public Brush b = new SolidBrush(Color.Black);
		public Font f;
			
		void MainFormLoad(object sender, EventArgs e)
		{
			g = this.CreateGraphics();
			f = this.Font;
		}
		public cub c0 = new cub(10,10,10);
		public cub c1 = new cub(20,10,10);
		public cub c2 = new cub(30,20,10);
		public cub c3 = new cub(50,10,10);
		public cub c4 = new cub(10,50,10);
		public cub c5 = new cub(40,20,10);
		public cub c6 = new cub(30,20,10);
		public cub c7 = new cub(30,60,10);
		public cub c8 = new cub(70,10,10);
		public cub c9 = new cub(10,70,10);
		
		public void clearScreen()
		{
			g.Clear(this.BackColor);
		}
		public void draw(ref cub c )
		{
			
			g.DrawLine(p,c.x,c.y,c.x+10,c.y);
			g.DrawLine(p,c.x+10,c.y,c.x+10,c.y+10);
			g.DrawLine(p,c.x+10,c.y+10,c.x,c.y+10);
			g.DrawLine(p,c.x,c.y+10,c.x,c.y);
			
			g.DrawLine(p,c.x-3,c.y-3,c.x-3+10,c.y-3);
			g.DrawLine(p,c.x-3+10,c.y-3,c.x-3+10,c.y-3+10);
			g.DrawLine(p,c.x-3+10,c.y-3+10,c.x-3,c.y-3+10);
			g.DrawLine(p,c.x-3,c.y-3+10,c.x-3,c.y-3);
			
			
			g.DrawLine(p,c.x,c.y,c.x-3,c.y-3);
			g.DrawLine(p,c.x+10,c.y,c.x-3+10,c.y-3);
			g.DrawLine(p,c.x+10,c.y+10,c.x-3+10,c.y-3+10);
			g.DrawLine(p,c.x,c.y+10,c.x-3,c.y-3+10);
		}
		public void aDepasit(ref cub xx)
		{
			int lx = 2;
			int ly = 2;
			int lw = 800;
			int lh = 600;
			if(xx.x<lx ){xx.x=xx.initx;}
			if(xx.x>lw ){xx.x=xx.initx;}
			if(xx.y<ly ){xx.y=xx.inity;}
			if(xx.y>lh ){xx.y=xx.inity;}
			
			
		}
		public int restartIt = 0;
		void Timer1Tick(object sender, EventArgs e)
		{
			restartIt++;
			
			clearScreen();
			draw(ref c0);
			draw(ref c1);
			draw(ref c2);
			draw(ref c3);
			draw(ref c4);
			draw(ref c5);
			draw(ref c6);
			draw(ref c7);
			draw(ref c8);
			draw(ref c9);
			
			c0.x += 2;
			c0.y += 2;
			c1.x += 1;
			c1.y += 2;
			c2.x += 3;
			c2.y += 2;
			c3.x += 2;
			c3.y += 2;
			c4.x += 1;
			c4.y += 2;
			c5.x += 2;
			c5.y += 2;
			c6.x += 3;
			c6.y += 2;
			c7.x += 2;
			c7.y += 2;
			c8.x += 3;
			c8.y += 2;
			c9.x += 1;
			c9.y += 2;
			
			aDepasit(ref c0);
			aDepasit(ref c1);
			aDepasit(ref c2);
			aDepasit(ref c3);
			aDepasit(ref c4);
			aDepasit(ref c5);
			aDepasit(ref c6);
			aDepasit(ref c7);
			aDepasit(ref c8);
			aDepasit(ref c9);
			
		}
		public class cub
		{
			public int x;
			public int y;
			public int z;
			public int initx;
			public int inity;
			public int initz;
			public cub(int px, int py, int pz)
			{
				x = px;
				y = py;
				z = pz;
				initx = x;
				inity = y;
				initz = z;
			}
					
		}
		
		
		
	}
}
