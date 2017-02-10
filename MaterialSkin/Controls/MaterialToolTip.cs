using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialToolTip : ToolTip, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public MaterialToolTip()
        {
            IsBalloon = false;
            OwnerDraw = true;
            Draw += DrawToolTipEvent;
            Popup += PopupEvent;
        }

        public MaterialToolTip(IContainer container) : this()
        {
            container.Add(this);
        }

        public void RemoveToolTip(Control control)
        {
            SetToolTip(control, null);
        }

        private void DrawToolTipEvent(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            //Background
            g.Clear(SkinManager.GetToolTipBackgroundColor());

            //Text
            using (StringFormat sf = new StringFormat(StringFormatFlags.NoWrap) { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
                g.DrawString(e.ToolTipText, SkinManager.ROBOTO_MEDIUM_10, SkinManager.GetPrimaryWhiteBrush(), e.Bounds, sf);

        }

        private void PopupEvent(object sender, PopupEventArgs e)
        {
            // measure new tooltip size
            using (Graphics g = Graphics.FromHwnd(e.AssociatedWindow.Handle))
            using (StringFormat sf = new StringFormat(StringFormatFlags.NoWrap) { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                SizeF gMeasureSize = g.MeasureString(GetToolTip(e.AssociatedControl), SkinManager.ROBOTO_MEDIUM_10, new SizeF(), sf);
                Size gNewSize = Size.Ceiling(gMeasureSize);
                e.ToolTipSize = new Size(gNewSize.Width + 8, gNewSize.Height + 6);
            }
        }
    }
}