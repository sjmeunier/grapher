using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EquationGrapher
{
    public partial class Graph : UserControl
    {
        public Color axisColor = Color.Black;
        public Color drawColor = Color.Red;
        public Color gridColor = Color.LightGray;
        public Color backgroundColor = Color.White;
        public int axisFontSize = 5;
        public Boolean drawAxes = true;
        public Boolean drawGrid = true;
        
        public Graph()
        {
            InitializeComponent();
        }

        public Bitmap GenerateGraph(string equation, double xScale, double yScale, double xOffset, double yOffset, double xLabelIncrement, double yLabelIncrement, int width, int height)
        {
            Bitmap image = new Bitmap(width, height);
            int midX = width / 2;
            int midY = height / 2;

            Graphics g = Graphics.FromImage(image);
            SolidBrush backgroundBrush = new SolidBrush(backgroundColor);
            SolidBrush axisBrush = new SolidBrush(axisColor);
            SolidBrush drawBrush = new SolidBrush(drawColor);
            SolidBrush gridBrush = new SolidBrush(gridColor);

            Pen drawPen = new Pen(drawColor);
            Pen axisPen = new Pen(axisColor);
            Pen gridPen = new Pen(gridColor);
            Font axisFont = new Font(FontFamily.GenericSansSerif, axisFontSize);
            //Clear background
            g.FillRectangle(backgroundBrush, 0, 0, width, height);
            
            //Draw Axes
            if (drawAxes)
            {
                g.DrawLine(axisPen, 0, midY, width, midY);
                g.DrawLine(axisPen, midX, 0, midX, height);

                //draw labels
                float xIncrementSize = (float)(xScale * xLabelIncrement);

                float curX = midX;
                while (curX < width)
                {
                    if (curX != midX)
                    {
                        if (drawGrid)
                        {
                            g.DrawLine(gridPen, curX, 0, curX, height);
                        }
                        g.DrawLine(axisPen, curX, midY, curX, midY + 3);
                        g.DrawString(Math.Round((curX - midX) * xScale + xOffset, 2).ToString(), axisFont, axisBrush, curX - 3, midY + 5);
                    }
                    curX += xIncrementSize;
                }
                curX = midX;
                while (curX > 0)
                {
                    if (curX != midX)
                    {
                        if (drawGrid)
                        {
                            g.DrawLine(gridPen, curX, 0, curX, height);
                        }
                        g.DrawLine(axisPen, curX, midY, curX, midY + 3);
                        g.DrawString(Math.Round((curX - midX) * xScale + xOffset, 2).ToString(), axisFont, axisBrush, curX - 3, midY + 5);
                    }
                    curX -= xIncrementSize;

                }

                float yIncrementSize = (float)(yScale * yLabelIncrement);

                float curY = midY;
                while (curY < height)
                {
                    if (curY != midY)
                    {
                        if (drawGrid)
                        {
                            g.DrawLine(gridPen, 0, curY, width, curY);
                        }
                        g.DrawLine(axisPen, midX, curY, midX + 3, curY);
                        g.DrawString(Math.Round(((curY - midY) * yScale + yOffset) * -1, 2).ToString(), axisFont, axisBrush, midX + 5, curY - 3);
                    }
                    curY += yIncrementSize;
                }
                curY = midY;
                while (curY > 0)
                {
                    if (curY != midY)
                    {
                        if (drawGrid)
                        {
                            g.DrawLine(gridPen, 0, curY, width, curY);
                        }
                        g.DrawLine(axisPen, midX, curY, midX + 3, curY);
                        g.DrawString(Math.Round(((curY - midY) * yScale + yOffset) * -1, 2).ToString(), axisFont, axisBrush, midX + 5, curY - 3);
                    }
                    curY -= yIncrementSize;
                }

            }

            //Draw graph
            float prevX = 0;
            float prevY = 0;
            double x = 0;
            double y = 0;
            float xImage = 0;
            float yImage = 0;
            string filledEquation = "";

            for (int i = 0; i < width; i++)
            {
                x = ((double)(i - midX) * xScale) + xOffset;
                
                filledEquation = equation.Replace("x", x.ToString());
                dotMath.EqCompiler equationCompiler = new dotMath.EqCompiler(filledEquation, true);
                equationCompiler.Compile();
                y = equationCompiler.Calculate() + yOffset;

                xImage = i;
                yImage = (int)(y * (-1) / yScale) + midY;
                if (i > 0)
                {
                    g.DrawLine(drawPen, prevX, prevY, xImage, yImage);
                }
                prevX = xImage;
                prevY = yImage;
            }
            return image;
        }
        public void DrawGraph(string equation, double xScale, double yScale, double xOffset, double yOffset, double xLabelIncrement, double yLabelIncrement)
        {
            picGraph.Image = GenerateGraph(equation, xScale, yScale, xOffset, yOffset, xLabelIncrement, yLabelIncrement, picGraph.Width, picGraph.Height);
        }
    }
}
