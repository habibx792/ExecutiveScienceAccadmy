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

        // Track created title bars
        private Dictionary<Form, Panel> _formTitleBars = new Dictionary<Form, Panel>();

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

            // Store original size before adjustments
            int originalHeight = form.Height;
            int originalWidth = form.Width;

            // Apply rounded corners
            UpdateFormRoundedCorners(form, borderRadius);

            // Add custom title bar
            if (showCustomTitleBar)
            {
                // Adjust form size to accommodate title bar
                form.Height += TitleBarHeight;

                // Move all existing controls down
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

            // Update on resize
            form.Resize += (s, e) =>
            {
                UpdateFormRoundedCorners(form, borderRadius);

                // Update title bar width when form resizes
                if (_formTitleBars.ContainsKey(form))
                {
                    _formTitleBars[form].Width = form.Width;
                }
            };

            // Handle maximize/restore
            form.ResizeEnd += (s, e) =>
            {
                if (form.WindowState == FormWindowState.Maximized)
                {
                    form.Region = null; // Remove rounded corners when maximized
                    // Hide custom title bar buttons in maximize mode
                    if (_formTitleBars.ContainsKey(form))
                    {
                        UpdateTitleBarForMaximize(form, true);
                    }
                }
                else
                {
                    UpdateFormRoundedCorners(form, borderRadius);
                    // Show custom title bar buttons in normal mode
                    if (_formTitleBars.ContainsKey(form))
                    {
                        UpdateTitleBarForMaximize(form, false);
                    }
                }
            };
        }

        // =======================
        // Move all existing controls down
        // =======================
        private void MoveControlsDown(Form form, int pixels)
        {
            List<Control> controls = new List<Control>();

            // Collect all controls
            foreach (Control control in form.Controls)
            {
                controls.Add(control);
            }

            // Move each control down
            foreach (Control control in controls)
            {
                control.Top += pixels;
            }
        }

        // =======================
        // Add Custom Title Bar with Controls (Fixed Order)
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
                Padding = new Padding(15, 0, 10, 0)
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
                Name = "TitleLabel"
            };

            // Calculate button positions from right to left
            int rightMargin = 10;

            // Close button
            Button closeBtn = CreateTitleBarButton("✕", Color.FromArgb(220, 53, 69));
            closeBtn.Location = new Point(form.Width - closeBtn.Width - rightMargin,
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
                    UpdateTitleBarForMaximize(form, false);
                }
                else
                {
                    form.WindowState = FormWindowState.Maximized;
                    maxBtn.Text = "🗗";
                    form.Region = null;
                    UpdateTitleBarForMaximize(form, true);
                }
            };
            maxBtn.Name = "MaximizeButton";

            // Minimize button
            Button minBtn = CreateTitleBarButton("_", Color.FromArgb(60, 60, 60));
            minBtn.Location = new Point(maxBtn.Left - minBtn.Width - 2,
                                       (TitleBarHeight - minBtn.Height) / 2);
            minBtn.Click += (s, e) => form.WindowState = FormWindowState.Minimized;
            minBtn.Name = "MinimizeButton";

            // Add controls to title bar IN CORRECT ORDER
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

            // Add title bar to form AT THE BEGINNING (so it's at index 0)
            form.Controls.Add(titleBar);
            titleBar.BringToFront();

            // Store reference to title bar
            _formTitleBars[form] = titleBar;

            // Update title label when form text changes
            form.TextChanged += (s, e) => titleLabel.Text = form.Text;

            // Handle form closing to clean up
            form.FormClosed += (s, e) =>
            {
                if (_formTitleBars.ContainsKey(form))
                {
                    _formTitleBars.Remove(form);
                }
            };
        }

        private void UpdateTitleBarForMaximize(Form form, bool isMaximized)
        {
            if (!_formTitleBars.ContainsKey(form)) return;

            Panel titleBar = _formTitleBars[form];
            if (isMaximized)
            {
                // Adjust title bar width when maximized
                titleBar.Width = form.Width;

                // Reposition buttons
                Control closeBtn = titleBar.Controls["CloseButton"];
                Control maxBtn = titleBar.Controls["MaximizeButton"];
                Control minBtn = titleBar.Controls["MinimizeButton"];

                if (closeBtn != null)
                    closeBtn.Left = titleBar.Width - closeBtn.Width - 10;
                if (maxBtn != null)
                    maxBtn.Left = closeBtn.Left - maxBtn.Width - 2;
                if (minBtn != null)
                    minBtn.Left = maxBtn.Left - minBtn.Width - 2;
            }
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
        public void StyleTextBox(TextBox txtBox, int borderRadius = 8, Color? borderColor = null)
        {
            if (txtBox == null) return;

            txtBox.BorderStyle = BorderStyle.None;
            txtBox.BackColor = Color.White;
            txtBox.Font = new Font("Segoe UI", 10);
            txtBox.Padding = new Padding(10, 8, 10, 8);

            // Store original location
            Point originalLocation = txtBox.Location;
            Control parent = txtBox.Parent;

            // Create rounded border panel
            Panel borderPanel = new Panel
            {
                BackColor = borderColor ?? Color.FromArgb(220, 220, 220),
                Size = new Size(txtBox.Width + 2, txtBox.Height + 2),
                Location = new Point(originalLocation.X - 1, originalLocation.Y - 1),
                Padding = new Padding(1)
            };

            ApplyRoundedCorners(borderPanel, borderRadius);

            // Remove textbox from parent and add to border panel
            parent.Controls.Remove(txtBox);
            borderPanel.Controls.Add(txtBox);
            txtBox.Dock = DockStyle.Fill;

            // Add border panel to parent
            parent.Controls.Add(borderPanel);
            borderPanel.BringToFront();

            // Focus effects
            txtBox.Enter += (s, e) => borderPanel.BackColor = PrimaryColor;
            txtBox.Leave += (s, e) => borderPanel.BackColor = borderColor ?? Color.FromArgb(220, 220, 220);
        }

        // =======================
        // Style ComboBox
        // =======================
        public void StyleComboBox(ComboBox comboBox, int borderRadius = 8, Color? borderColor = null)
        {
            if (comboBox == null) return;

            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Color.White;
            comboBox.Font = new Font("Segoe UI", 10);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Create rounded border panel
            Panel borderPanel = new Panel
            {
                BackColor = borderColor ?? Color.FromArgb(220, 220, 220),
                Size = new Size(comboBox.Width + 2, comboBox.Height + 2),
                Location = new Point(comboBox.Left - 1, comboBox.Top - 1),
                Padding = new Padding(1)
            };

            ApplyRoundedCorners(borderPanel, borderRadius);

            // Remove combobox from parent and add to border panel
            comboBox.Parent.Controls.Remove(comboBox);
            borderPanel.Controls.Add(comboBox);
            comboBox.Dock = DockStyle.Fill;

            // Add border panel to parent
            comboBox.Parent.Controls.Add(borderPanel);
            borderPanel.BringToFront();

            // Focus effects
            comboBox.Enter += (s, e) => borderPanel.BackColor = PrimaryColor;
            comboBox.Leave += (s, e) => borderPanel.BackColor = borderColor ?? Color.FromArgb(220, 220, 220);
        }

        // =======================
        // Style DataGridView
        // =======================
        public void StyleDataGridView(DataGridView dgv, int borderRadius = 10)
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
            dgv.RowTemplate.Height = 35;
            dgv.DoubleBuffered(true);

            // Add rounded corners to DataGridView
            Panel dgvContainer = new Panel
            {
                BackColor = Color.FromArgb(50, 50, 50),
                Location = new Point(dgv.Left - 1, dgv.Top - 1),
                Size = new Size(dgv.Width + 2, dgv.Height + 2),
                Padding = new Padding(1)
            };

            ApplyRoundedCorners(dgvContainer, borderRadius);

            // Move DataGridView into container
            dgv.Parent.Controls.Remove(dgv);
            dgvContainer.Controls.Add(dgv);
            dgv.Dock = DockStyle.Fill;
            dgv.Parent.Controls.Add(dgvContainer);
            dgvContainer.BringToFront();
        }

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
        public void StyleLabel(Label label, bool isTitle = false)
        {
            if (label == null) return;

            if (isTitle)
            {
                label.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                label.Font = new Font("Segoe UI", 10);
                label.ForeColor = Color.FromArgb(80, 80, 80);
            }
        }

        public void StyleGroupBox(GroupBox groupBox, int borderRadius = 10)
        {
            if (groupBox == null) return;

            groupBox.FlatStyle = FlatStyle.Flat;
            groupBox.ForeColor = Color.FromArgb(50, 50, 50);
            groupBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Custom painting for rounded groupbox
            groupBox.Paint += (s, e) =>
            {
                GroupBox gb = s as GroupBox;
                if (gb == null) return;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw rounded border
                using (GraphicsPath path = GetRoundedRectanglePath(
                    new Rectangle(0, gb.Font.Height / 2, gb.Width - 1, gb.Height - gb.Font.Height / 2 - 1),
                    borderRadius))
                using (Pen pen = new Pen(Color.FromArgb(200, 200, 200), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Draw groupbox text
                Size textSize = TextRenderer.MeasureText(gb.Text, gb.Font);
                Rectangle textRect = new Rectangle(15, 0, textSize.Width, textSize.Height);
                e.Graphics.FillRectangle(new SolidBrush(gb.BackColor), textRect);
                e.Graphics.DrawString(gb.Text, gb.Font, new SolidBrush(gb.ForeColor), 15, 0);
            };
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