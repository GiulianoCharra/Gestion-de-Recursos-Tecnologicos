using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Gestión_de_Recursos_Tecnológicos.Clases.Soporte
{
    [DefaultEvent("_TextChanged")]
    public partial class RedondeadoTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        private int borderRadio = 0;


        public RedondeadoTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;
        [Category("Redondeado")]
        public Color BorderColor {
            get => borderColor;
            set {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Redondeado")]
        public int BorderSize {
            get => borderSize;
            set {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Redondeado")]
        public bool UnderlinedStyle {
            get => underlinedStyle;
            set {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("Redondeado")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set {
                borderFocusColor = value;
            }
        }
        [Category("Redondeado")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("Redondeado")]
        public override Color BackColor
        {
            get => base.BackColor;
            set {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Redondeado")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Redondeado")]
        public override Font Font
        {
            get => base.Font;
            set {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Redondeado")]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [Category("Redondeado")]
        public int BorderRadio
        {
            get => borderRadio;
            set
            {
                if (value >= 0)
                {
                    borderRadio = value;
                    this.Invalidate();
                }
            }
        }
                
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadio > 1)// Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -BorderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = getFigurePath(rectBorderSmooth, borderRadio))
                using (GraphicsPath pathBorder = getFigurePath(rectBorder, borderRadio - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Drawing
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadio > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (!isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle)//Line style
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //normal style
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder,pathBorder);
                    }
                }
            }
            else// Normal TextBox
            {
                //draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underlinedStyle)//Line style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        else //normal style
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;

                        if (underlinedStyle)//Line style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        else //normal style
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = getFigurePath(textBox1.ClientRectangle,borderRadio - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = getFigurePath(textBox1.ClientRectangle,borderSize*2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        private GraphicsPath getFigurePath(Rectangle rect, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radio * 2F;

            path.StartFigure();
            path.AddArc(rect.X,rect.Y,curveSize,curveSize,180,90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize,curveSize, 0,90);
            path.AddArc(rect.X, rect.Bottom -curveSize, curveSize,curveSize, 90,90);
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0,txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void RedondeadoTextBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void RedondeadoTextBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
