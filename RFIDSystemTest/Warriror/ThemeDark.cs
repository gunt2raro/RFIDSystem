using System;
using System.Collections.Generic;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using RFIDSystemTest.Views.Events;

namespace RFIDSystemTest.Warriror
{
    /// <summary>
    /// Theme dark
    /// </summary>
    public static class ThemeDark
    {
        /// <summary>
        /// Responsive Design
        /// </summary>
        /// <param name="control_child"></param>
        /// <param name="control_parent"></param>
        /// <param name="width_por"></param>
        /// <param name="height_por"></param>
        public static void ResponsiveDesign(Control control_child, Control control_parent, double width_por, double height_por)
        {
            control_child.Width = (int)(control_parent.Width * width_por);
            control_child.Height = (int)(control_parent.Height * height_por);
        }// End of Responsive Design function

        /// <summary>
        /// Responsive Design
        /// </summary>
        /// <param name="panel_child"></param>
        /// <param name="panel_parent"></param>
        /// <param name="width_por"></param>
        /// <param name="height_por"></param>
        public static void ResponsiveDesign(Panel panel_child, Panel panel_parent, double width_por, double height_por)
        {
            panel_child.Width = (int)(panel_parent.Width * width_por);
            panel_child.Height = (int)(panel_parent.Height * height_por);
        }// End of Responsive Design function

        /// <summary>
        /// Set background color
        /// </summary>
        /// <param name="control"></param>
        public static void SetBackgroundColor(Control control) {
            control.BackColor = Color.FromArgb(34, 34, 34);
        }// End of SetBackgroundColor function

        /// <summary>
        /// Set background color
        /// </summary>
        /// <param name="panel"></param>
        public static void SetBackgroundColor(Panel panel) {
            panel.BackColor = Color.FromArgb(9, 42, 56);
        }// End of SetBackgroundColor function

        /// <summary>
        /// Set buttons theme
        /// </summary>
        /// <param name="control"></param>
        public static void SetButtonsTheme(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(Control) || c.GetType() == typeof(Panel))
                {
                    SetButtonsTheme(c);
                }
                else if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.BackColor = Color.FromArgb(255, 255, 255);
                    b.ForeColor = Color.FromArgb(190, 187, 187);
                    b.Font = new Font("Segoe UI", 15, FontStyle.Regular, GraphicsUnit.World);

                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 192);
                    b.FlatAppearance.BorderSize = 2;

                    if (b.Image != null && b.ImageAlign != ContentAlignment.BottomLeft && b.ImageAlign != ContentAlignment.MiddleRight) {
                        using (Image img = b.Image.Clone() as Image) {
                            b.Image = (Image)(new Bitmap(img, new Size( (int)(b.Width *.75), (int)( b.Height *.75 ) )));
                        }
                    }
                    else if(b.Image != null && b.ImageAlign == ContentAlignment.BottomLeft)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .13), (int)(b.Height * .8))));
                        }
                    }
                }
            }

        }// End of SetButtons function

        /// <summary>
        /// Set buttons theme
        /// </summary>
        /// <param name="panel"></param>
        public static void SetButtonsTheme(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(Control) || c.GetType() == typeof(Panel))
                {
                    SetButtonsTheme(c);
                }
                else if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.BackColor = Color.FromArgb(255, 255, 255);
                    b.ForeColor = Color.FromArgb(190, 187, 187);
                    b.Font = new Font("Segoe UI", 15, FontStyle.Regular, GraphicsUnit.World);

                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 192);
                    b.FlatAppearance.BorderSize = 2;

                    if (b.Image != null && b.ImageAlign != ContentAlignment.BottomLeft && b.ImageAlign != ContentAlignment.MiddleRight)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .75), (int)(b.Height * .75))));
                        }
                    }
                    else if (b.Image != null && b.ImageAlign == ContentAlignment.BottomLeft)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .13), (int)(b.Height * .8))));
                        }
                    }

                }
            }
        }// End of SetButtons function

        /// <summary>
        /// Set buttons theme
        /// </summary>
        /// <param name="control"></param>
        public static void SetButtonsThemeDark(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(Control) || c.GetType() == typeof(Panel))
                {
                    SetButtonsThemeDark(c);
                }
                else if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.BackColor = Color.FromArgb(34, 34, 34);
                    b.ForeColor = Color.FromArgb(255, 255, 255);
                    b.Font = new Font("Segoe UI", 15, FontStyle.Bold, GraphicsUnit.World);
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = FlatStyle.Flat;
                    if (b.Image != null && b.ImageAlign != ContentAlignment.BottomLeft && b.ImageAlign != ContentAlignment.MiddleRight)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .75), (int)(b.Height * .75))));
                        }
                    }
                    else if (b.Image != null && b.ImageAlign == ContentAlignment.BottomLeft)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .13), (int)(b.Height * .8))));
                        }
                    }
                }
            }

        }// End of SetButtons function

        /// <summary>
        /// Set buttons theme
        /// </summary>
        /// <param name="panel"></param>
        public static void SetButtonsThemeDark(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(Control) || c.GetType() == typeof(Panel))
                {
                    SetButtonsThemeDark(c);
                }
                else if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.BackColor = Color.FromArgb(34, 34, 34);
                    b.ForeColor = Color.FromArgb(255, 255, 255);
                    b.Font = new Font("Segoe UI", 15, FontStyle.Bold, GraphicsUnit.World);
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = FlatStyle.Flat;

                    if (b.Image != null && b.ImageAlign != ContentAlignment.BottomLeft && b.ImageAlign != ContentAlignment.MiddleRight)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .75), (int)(b.Height * .75))));
                        }
                    }
                    else if (b.Image != null && b.ImageAlign == ContentAlignment.BottomLeft)
                    {
                        using (Image img = b.Image.Clone() as Image)
                        {
                            b.Image = (Image)(new Bitmap(img, new Size((int)(b.Width * .13), (int)(b.Height * .8))));
                        }
                    }

                }
            }
        }// End of SetButtons function

        /// <summary>
        /// Set labels theme
        /// </summary>
        /// <param name="newEvent"></param>
        internal static void SetLabelsTheme(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(Control) || c.GetType() == typeof(Panel))
                {
                    SetLabelsTheme(c);
                }
                else if (c.GetType() == typeof(Label))
                {
                    Label l = (Label)c;
                    l.ForeColor = Color.FromArgb(148, 165, 181);
                    l.Font = new Font("Segoe UI", 40, FontStyle.Regular, GraphicsUnit.Document);
                }
            }

        }// End of SetLabelsTheme function

        /// <summary>
        /// Set labels theme
        /// </summary>
        /// <param name="newEvent"></param>
        internal static void SetLabelsTheme(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(Control) || c.GetType() == typeof(Panel))
                {
                    SetLabelsTheme(c);
                }
                else if (c.GetType() == typeof(Label))
                {
                    Label l = (Label)c;
                    l.ForeColor = Color.FromArgb(148, 165, 181);
                    l.Font = new Font("Segoe UI", 40, FontStyle.Regular, GraphicsUnit.Document);
                }
            }

        }// End of SetLabelsTheme function

        /// <summary>
        /// Set Data Grid View Theme
        /// </summary>
        /// <param name="dgv"></param>
        public static void SetDataGridViewTheme( DataGridView dgv )
        {
            
        }// End of Set Data Grid View Theme function

        /// <summary>
        /// Set data grid view responsive width
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="control"></param>
        /// <param name="per_width"></param>
        public static void SetDataGridViewResponsiveWidth( DataGridView dgv, Control control, double per_width ) {
            dgv.Width = (int)( control.Width * per_width );
        }// End of SetDataGridViewResponsive function

        /// <summary>
        /// Set data grid view responsive height
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="control"></param>
        /// <param name="per_height"></param>
        public static void SetDataGridViewResponsiveHeight( DataGridView dgv, Control control, double per_height) {
            dgv.Height = (int)( control.Height * per_height );
        }// End of Data GridView Responsive Height

        ///
        /// Buttons responsiveness
        /// 
        #region Buttons
        /// <summary>
        /// Buttons responsive width
        /// </summary>
        public static void ButtonsResponsiveWidth(Button button, Control control, double per_width)
        {
            button.Width = (int)(control.Width * per_width);
        }// End of Buttons Reponsive Width function

        /// <summary>
        /// Buttons responsive width
        /// </summary>
        public static void ButtonsResponsiveWidth(Button button, Panel panel, double per_width)
        {

            button.Width = (int)(panel.Height * per_width);
        }// End of Buttons Reponsive Width function

        /// <summary>
        /// Buttons resonsive height
        /// </summary>
        /// <param name="per_heigth"></param>
        public static void ButtonsReponsiveHeight(Button button, Panel panel, double per_heigth ) {

            button.Height = (int)(panel.Height * per_heigth);
        }// End of Buttons responsive height function


        /// <summary>
        /// Buttons resonsive height
        /// </summary>
        /// <param name="per_heigth"></param>
        public static void ButtonsReponsiveHeight(Button button, Control control, double per_heigth)
        {
            button.Height = (int)( control.Height * per_heigth );
        }// End of Buttons responsive height function
        #endregion
        // End of buttons responsiveness region
        
    }// End of Theme Dark class
}
