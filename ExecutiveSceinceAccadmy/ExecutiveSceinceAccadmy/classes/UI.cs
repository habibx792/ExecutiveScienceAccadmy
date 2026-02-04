using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExecutiveScienceAcademy.classes
{
    internal class UI
    {
        // Singleton
        private static UI _instance;
        private static readonly object _lock = new object();

        public static UI Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new UI();
                    }
                }
                return _instance;
            }
        }

        private UI() { }

        // Modern color scheme
        public Color PrimaryColor { get; set; } = Color.FromArgb(0, 120, 215); // Blue
        public Color SecondaryColor { get; set; } = Color.FromArgb(40, 40, 40); // Dark gray
        public Color AccentColor { get; set; } = Color.FromArgb(220, 53, 69); // Red
        public Color LightBackground { get; set; } = Color.FromArgb(245, 245, 245);
        public Color DarkBackground { get; set; } = Color.FromArgb(50, 50, 50);

        // Title bar height
        private const int TitleBarHeight = 40;

        // Track form state
        private Dictionary<Form, (Panel TitleBar, Button MinBtn, Button MaxBtn, Button CloseBtn, Label TitleLabel)> _formStates =
            new Dictionary<Form, (Panel, Button, Button, Button, Label)>();

        // =======================
        // Style Form with Modern Controls
        // =======================
        public void StyleForm(Form form, Color? backgroundColor = null, int borderRadius = 25,
                            bool showCustomTitleBar = true, string title = null)
        {
            if (form == null) return;

            // Set colors
            Color backColor = backgroundColor ?? LightBackground;
            Color titleBarColor = Color.FromArgb(30, 30, 30);

            form.BackColor = backColor;
            form.FormBorderStyle = FormBorderStyle.None;
            form.DoubleBuffered(true);

            // Apply rounded corners
            UpdateFormRoundedCorners(form, borderRadius);

            // Add custom title bar
            if (showCustomTitleBar)
            {
                // Adjust form size to accommodate title bar
                int originalHeight = form.Height;
                form.Height = originalHeight + TitleBarHeight;

                // Move all existing controls down EXCEPT the title bar
                MoveControlsDown(form, TitleBarHeight);

                AddCustomTitleBar(form, titleBarColor, PrimaryColor, title ?? form.Text, borderRadius);
            }
            else
            {
                // Make entire form draggable if no custom title bar
                form.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        ReleaseCapture();
                        SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    }
                };
            }

            // Handle form events
            form.Resize += (s, e) => HandleFormResize(form, borderRadius);
            form.ResizeBegin += (s, e) => SuspendTitleBarUpdates(form);
            form.ResizeEnd += (s, e) => ResumeTitleBarUpdates(form, borderRadius);

            // Handle form closing to clean up
            form.FormClosed += (s, e) =>
            {
                if (_formStates.ContainsKey(form))
                {
                    _formStates.Remove(form);
                }
            };
        }
        public void AddFormShadow(Form f)
        {
            f.Paint += (s, e) =>
            {
                // Draw subtle shadow around form
                ControlPaint.DrawBorder(e.Graphics, f.ClientRectangle,
                    Color.FromArgb(100, 0, 0, 0), 0, ButtonBorderStyle.None,
                    Color.FromArgb(100, 0, 0, 0), 0, ButtonBorderStyle.None,
                    Color.FromArgb(100, 0, 0, 0), 1, ButtonBorderStyle.None,
                    Color.FromArgb(100, 0, 0, 0), 1, ButtonBorderStyle.None);
            };
        }
        public void setFormSize(Form f,int w,int h) 
        {
            f.Size = new Size(w, h);
        }

        // =======================
        // Handle Form Resize
        // =======================
        private void HandleFormResize(Form form, int borderRadius)
        {
            if (!_formStates.ContainsKey(form)) return;

            var (titleBar, minBtn, maxBtn, closeBtn, titleLabel) = _formStates[form];

            // Update title bar width
            titleBar.Width = form.Width;

            // Update button positions
            if (closeBtn != null)
                closeBtn.Left = form.Width - closeBtn.Width - 10;
            if (maxBtn != null)
                maxBtn.Left = closeBtn.Left - maxBtn.Width - 2;
            if (minBtn != null)
                minBtn.Left = maxBtn.Left - minBtn.Width - 2;

            // Update rounded corners based on window state
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.Region = null;
                if (maxBtn != null) maxBtn.Text = "🗗";
            }
            else
            {
                UpdateFormRoundedCorners(form, borderRadius);
                if (maxBtn != null) maxBtn.Text = "🗖";
            }
        }

        private void SuspendTitleBarUpdates(Form form)
        {
            if (!_formStates.ContainsKey(form)) return;

            var (titleBar, minBtn, maxBtn, closeBtn, titleLabel) = _formStates[form];
            titleBar.SuspendLayout();
        }

        private void ResumeTitleBarUpdates(Form form, int borderRadius)
        {
            if (!_formStates.ContainsKey(form)) return;

            var (titleBar, minBtn, maxBtn, closeBtn, titleLabel) = _formStates[form];
            titleBar.ResumeLayout();
            HandleFormResize(form, borderRadius);
        }

        // =======================
        // Move controls down (excluding title bar)
        // =======================
        private void MoveControlsDown(Form form, int pixels)
        {
            List<Control> controls = new List<Control>();

            // Collect all controls except future title bar
            foreach (Control control in form.Controls)
            {
                if (!(control is Panel && control.Name == "TitleBar"))
                {
                    controls.Add(control);
                }
            }

            // Move each control down
            foreach (Control control in controls)
            {
                control.Top += pixels;
            }
        }

        // =======================
        // Add Custom Title Bar with Controls (FIXED VERSION)
        // =======================
        private void AddCustomTitleBar(Form form, Color titleBarColor, Color accentColor,
                                     string titleText, int borderRadius)
        {
            // Create title bar panel
            Panel titleBar = new Panel
            {
                Height = TitleBarHeight,
                Width = form.Width,
                BackColor = titleBarColor,
                Location = new Point(0, 0),
                Name = "TitleBar",
                Padding = new Padding(15, 0, 10, 0),
                Dock = DockStyle.Top
            };

            // Title label
            Label titleLabel = new Label
            {
                Text = titleText,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(15, (TitleBarHeight - 25) / 2),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Height = 25,
                Name = "TitleLabel",
                BackColor = Color.Transparent
            };

            // Close button
            Button closeBtn = CreateTitleBarButton("✕", Color.FromArgb(220, 53, 69));
            closeBtn.Location = new Point(form.Width - closeBtn.Width - 10,
                                         (TitleBarHeight - closeBtn.Height) / 2);
            closeBtn.Click += (s, e) => form.Close();
            closeBtn.Name = "CloseButton";

            // Maximize/Restore button
            Button maxBtn = CreateTitleBarButton("🗖", Color.FromArgb(60, 60, 60));
            maxBtn.Location = new Point(closeBtn.Left - maxBtn.Width - 2,
                                       (TitleBarHeight - maxBtn.Height) / 2);
            maxBtn.Click += (s, e) =>
            {
                if (form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                    maxBtn.Text = "🗖";
                    UpdateFormRoundedCorners(form, borderRadius);
                }
                else
                {
                    form.WindowState = FormWindowState.Maximized;
                    maxBtn.Text = "🗗";
                    form.Region = null;
                }
            };
            maxBtn.Name = "MaximizeButton";

            // Minimize button
            Button minBtn = CreateTitleBarButton("_", Color.FromArgb(60, 60, 60));
            minBtn.Location = new Point(maxBtn.Left - minBtn.Width - 2,
                                       (TitleBarHeight - minBtn.Height) / 2);
            minBtn.Click += (s, e) => form.WindowState = FormWindowState.Minimized;
            minBtn.Name = "MinimizeButton";

            // Add controls to title bar
            titleBar.Controls.Add(titleLabel);
            titleBar.Controls.Add(minBtn);
            titleBar.Controls.Add(maxBtn);
            titleBar.Controls.Add(closeBtn);

            // Make title bar draggable
            titleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };

            // Also make title label draggable
            titleLabel.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };

            // Add title bar to form
            form.Controls.Add(titleBar);
            titleBar.BringToFront();

            // Store all references
            _formStates[form] = (titleBar, minBtn, maxBtn, closeBtn, titleLabel);

            // Update title label when form text changes
            form.TextChanged += (s, e) => titleLabel.Text = form.Text;
        }

        private Button CreateTitleBarButton(string text, Color backColor)
        {
            Button btn = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = backColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Height = TitleBarHeight - 10,
                Width = 45,
                Cursor = Cursors.Hand,
                TabStop = false,
                FlatAppearance = {
                    BorderSize = 0,
                    MouseOverBackColor = Color.FromArgb(
                        Math.Min(backColor.R + 30, 255),
                        Math.Min(backColor.G + 30, 255),
                        Math.Min(backColor.B + 30, 255)),
                    MouseDownBackColor = Color.FromArgb(
                        Math.Max(backColor.R - 30, 0),
                        Math.Max(backColor.G - 30, 0),
                        Math.Max(backColor.B - 30, 0))
                }
            };

            return btn;
        }

        // =======================
        // Style Button with rounded corners
        // =======================
        public void StyleButton(Button btn, int borderRadius = 15, Color? backgroundColor = null)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            Color normal = backgroundColor ?? PrimaryColor;
            Color hover = Color.FromArgb(
                Math.Min(normal.R + 20, 255),
                Math.Min(normal.G + 20, 255),
                Math.Min(normal.B + 20, 255));
            Color pressed = Color.FromArgb(
                Math.Max(normal.R - 30, 0),
                Math.Max(normal.G - 30, 0),
                Math.Max(normal.B - 30, 0));
            Color disabled = Color.FromArgb(200, 200, 200);

            btn.BackColor = normal;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 11F);
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 5, 10, 5);

            // Rounded corners
            ApplyRoundedCorners(btn, borderRadius);

            // Hover / press effects
            btn.MouseEnter += (s, e) =>
            {
                if (btn.Enabled)
                {
                    btn.BackColor = hover;
                    btn.FlatAppearance.MouseOverBackColor = hover;
                }
            };

            btn.MouseLeave += (s, e) =>
            {
                if (btn.Enabled)
                {
                    btn.BackColor = normal;
                }
            };

            btn.MouseDown += (s, e) =>
            {
                if (btn.Enabled)
                {
                    btn.BackColor = pressed;
                }
            };

            btn.MouseUp += (s, e) =>
            {
                if (btn.Enabled)
                {
                    btn.BackColor = hover;
                }
            };

            btn.EnabledChanged += (s, e) =>
            {
                btn.BackColor = btn.Enabled ? normal : disabled;
                btn.ForeColor = btn.Enabled ? Color.White : Color.DarkGray;
            };

            // Update rounded corners on resize
            btn.Resize += (s, e) => ApplyRoundedCorners(btn, borderRadius);
        }
        public void MakeButtonModern(
     Button btn,
     int width = 140,
     int height = 40,
     int borderRadius = 15,
     int borderSize = 0,
     Color? backgroundColor = null,
     Color? hoverColor = null,
     Color? pressedColor = null,
     Color? borderColor = null,
     Color? textColor = null,
     Font? font = null)
        {
            if (btn == null) return;

            // 🔒 Prevent double styling - SIMPLE CHECK
            if (btn.FlatStyle == FlatStyle.Flat && btn.Cursor == Cursors.Hand && btn.Padding.Top == 5)
                return;

            Color normal = backgroundColor ?? PrimaryColor;
            Color hover = hoverColor ?? ControlPaint.Light(normal, 0.1f);
            Color pressed = pressedColor ?? ControlPaint.Dark(normal, 0.15f);
            Color border = borderColor ?? Color.Transparent;
            Color fore = textColor ?? Color.White;

            btn.Size = new Size(width, height);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = borderSize;
            btn.FlatAppearance.BorderColor = border;
            btn.BackColor = normal;
            btn.ForeColor = fore;
            btn.Font = font ?? new Font("Segoe UI Semibold", 11F);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Padding = new Padding(10, 5, 10, 5);
            btn.TabStop = false;

            ApplyRoundedCorners(btn, borderRadius);

            // Use named event handlers to prevent duplication
           

            btn.Resize -= (_, __) => ApplyRoundedCorners(btn, borderRadius);
            btn.Resize += (_, __) => ApplyRoundedCorners(btn, borderRadius);

            // Store colors in Tag
            btn.Tag = new { normal, hover, pressed, fore };
        }
        private void ApplyRoundedCorners(Button btn, int radius)
        {
            if (btn == null || btn.Width <= 0 || btn.Height <= 0) return;

            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }


        // =======================
        // Style Panel with rounded corners
        // =======================
        public void StylePanel(Panel panel,
                               Color? backColor = null,
                               Color? borderColor = null,
                               int borderThickness = 2,
                               int borderRadius = 15,
                               Padding? padding = null,
                               Padding? margin = null)
        {
            if (panel == null) return;

            panel.BackColor = backColor ?? Color.White;

            if (padding.HasValue)
                panel.Padding = padding.Value;
            if (margin.HasValue)
                panel.Margin = margin.Value;

            panel.BorderStyle = BorderStyle.None;
            panel.DoubleBuffered(true);

            // Apply rounded corners
            ApplyRoundedCorners(panel, borderRadius);

            // Custom painting for border
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = panel.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
                using (Pen pen = new Pen(borderColor ?? PrimaryColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };

            // Update rounded corners on resize
            panel.Resize += (s, e) => ApplyRoundedCorners(panel, borderRadius);
        }

        // =======================
        // Style TextBox with modern look
        // =======================
        //public void MakeTextBoxModern(TextBox tb)
        //{
        //    if (tb == null || tb.Parent == null) return;

        //    Form form = tb.FindForm();
        //    if (form == null) return;

        //    int radius = 6; // Smaller radius for modern look
        //    Color normal = Color.FromArgb(210, 210, 210); // Better gray
        //    Color focused = Color.FromArgb(0, 120, 215);

        //    tb.BorderStyle = BorderStyle.None;
        //    tb.BackColor = Color.WhiteSmoke; // Better background
        //    tb.Font = new Font("Segoe UI", 10f);
        //    tb.Height = 36; // Better touch target

        //    // Only use Multiline if needed
        //    if (!tb.Multiline)
        //    {
        //        tb.Multiline = true;
        //        tb.MinimumSize = new Size(0, tb.Height);
        //        tb.MaximumSize = new Size(0, tb.Height);
        //    }

        //    // Optimized invalidation
        //    void invalidate()
        //    {
        //        if (!form.IsDisposed && !form.Disposing && tb.IsHandleCreated)
        //        {
        //            Rectangle invalRect = new Rectangle(
        //                tb.Left - 2,
        //                tb.Top - 2,
        //                tb.Width + 4,
        //                tb.Height + 4);
        //            form.Invalidate(invalRect);
        //        }
        //    }

        //    // Attach events once
        //    EventHandler invalidateHandler = (s, e) => invalidate();

        //    tb.Enter -= invalidateHandler;
        //    tb.Leave -= invalidateHandler;
        //    tb.TextChanged -= invalidateHandler;
        //    tb.Resize -= invalidateHandler;
        //    tb.LocationChanged -= invalidateHandler;

        //    tb.Enter += invalidateHandler;
        //    tb.Leave += invalidateHandler;
        //    tb.TextChanged += invalidateHandler;
        //    tb.Resize += invalidateHandler;
        //    tb.LocationChanged += invalidateHandler;

        //    // Remove existing paint handler to avoid duplicates
        //    EventHandler<PaintEventArgs> paintHandler = null;

        //    // Clean up old handler first
            

        //    paintHandler = (s, e) =>
        //    {
        //        if (tb.IsDisposed || !tb.Visible || tb.Bounds.IsEmpty) return;

        //        Rectangle r = new Rectangle(
        //            tb.Left - 1,
        //            tb.Top - 1,
        //            tb.Width + 1,
        //            tb.Height + 1);

        //        using (GraphicsPath path = RoundedRect(r, radius))
        //        using (Pen pen = new Pen(tb.Focused ? focused : normal, 1.75f))
        //        {
        //            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //            e.Graphics.DrawPath(pen, path);

        //            // Add subtle shadow when focused
        //            if (tb.Focused)
        //            {
        //                using (Pen shadowPen = new Pen(Color.FromArgb(30, focused), 3f))
        //                {
        //                    e.Graphics.DrawPath(shadowPen, path);
        //                }
        //            }
        //        }
        //    };

           
        //}

        //private GraphicsPath RoundedRect(Rectangle r, int radius)
        //{
        //    GraphicsPath path = new GraphicsPath();

        //    if (radius <= 0)
        //    {
        //        path.AddRectangle(r);
        //        return path;
        //    }

        //    int d = radius * 2;

        //    // Ensure arcs fit in rectangle
        //    if (d > r.Width) d = r.Width;
        //    if (d > r.Height) d = r.Height;

        //    // Top-left
        //    path.AddArc(r.X, r.Y, d, d, 180, 90);
        //    // Top-right
        //    path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        //    // Bottom-right
        //    path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        //    // Bottom-left
        //    path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);

        //    path.CloseFigure();
        //    return path;
        //}

        // =======================
        // Helper Methods
        // =======================
        private void UpdateFormRoundedCorners(Form form, int radius)
        {
            if (form.WindowState == FormWindowState.Maximized || radius <= 0)
            {
                form.Region = null;
                return;
            }

            form.Region = new Region(GetRoundedRectanglePath(
                new Rectangle(0, 0, form.Width, form.Height),
                radius));
        }

        private void ApplyRoundedCorners(Control control, int radius)
        {
            if (control == null || radius <= 0 || control.Height <= 0 || control.Width <= 0)
            {
                control.Region = null;
                return;
            }

            control.Region = new Region(GetRoundedRectanglePath(
                control.ClientRectangle,
                Math.Min(radius, Math.Min(control.Height, control.Width) / 2)));
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (diameter > rect.Height) diameter = rect.Height;
            if (diameter > rect.Width) diameter = rect.Width;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        // =======================
        // Additional Modern Styling Methods
        // =======================
        public void StyleDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215, 50);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       

        public void StyleLabel(Label label, bool isTitle = false)
        {
            if (label == null) return;

            if (isTitle)
            {
                label.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                label.Font = new Font("Segoe UI", 20);
                label.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        #region Win32 API for dragging
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        #endregion
    }


    // Extension method for smooth double-buffering
    internal static class ControlExtensions
    {
        public static void DoubleBuffered(this Control control, bool setting)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            property?.SetValue(control, setting, null);
        }
    }
}