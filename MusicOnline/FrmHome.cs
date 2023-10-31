using System.Drawing.Drawing2D;

namespace MusicOnline
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            slider.Height = 30;
        }

        #region slider

        private float defaultValue = 0.1f, min = 0.0f, max = 1.0f;

        private float Bar(float value)
        {
            return (slider.Width - 24) * (value - min) / (float)(max - min);
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float barSize = 0.45f;
            float x = Bar(defaultValue);
            int y = (int)(slider.Height * barSize);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#4D4D4D")), 0, y, slider.Width, y / 2);

            using (Pen pen = new Pen(Color.White, 8))
                g.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
        }

        #endregion

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}