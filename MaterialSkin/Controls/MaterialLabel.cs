using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        private Font _font;

        public MaterialLabel()
        {
            _font = SkinManager.ROBOTO_MEDIUM_11;
        }

        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        [DefaultValue("")]
        public override Font Font
        {
            get { return _font; }
            set { _font = value; }
        }
        
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ForeColor = SkinManager.GetPrimaryTextColor();
  
            FontChanged += (sender, args) => Font = _font;

            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }

        public TextRenderingHint TextRenderingHint { get; set; } = TextRenderingHint.SystemDefault;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint;
            base.OnPaint(e);
        }
    }
}
