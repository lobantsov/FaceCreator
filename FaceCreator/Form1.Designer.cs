namespace FaceCreator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTSizePlus = new System.Windows.Forms.Button();
            this.BTSizeMinus = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtTattoo = new System.Windows.Forms.Button();
            this.BtPiercing = new System.Windows.Forms.Button();
            this.BtNose = new System.Windows.Forms.Button();
            this.BtMustache = new System.Windows.Forms.Button();
            this.BtLips = new System.Windows.Forms.Button();
            this.BtHeaddress = new System.Windows.Forms.Button();
            this.BtHair = new System.Windows.Forms.Button();
            this.BtGlasses = new System.Windows.Forms.Button();
            this.BtForehead = new System.Windows.Forms.Button();
            this.BtFace_shape = new System.Windows.Forms.Button();
            this.BtEyes = new System.Windows.Forms.Button();
            this.BtEyebrows = new System.Windows.Forms.Button();
            this.BtBeard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Tag = "-1";
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Tag = "-1";
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Tag = "-1";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.clearToolStripMenuItem.Tag = "-1";
            this.clearToolStripMenuItem.Text = "Clear All";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // BTSizePlus
            // 
            this.BTSizePlus.Location = new System.Drawing.Point(3, 3);
            this.BTSizePlus.Name = "BTSizePlus";
            this.BTSizePlus.Size = new System.Drawing.Size(50, 23);
            this.BTSizePlus.TabIndex = 35;
            this.BTSizePlus.Tag = "-1";
            this.BTSizePlus.Text = "+";
            this.BTSizePlus.UseVisualStyleBackColor = true;
            this.BTSizePlus.Click += new System.EventHandler(this.BTSizePlus_Click_1);
            // 
            // BTSizeMinus
            // 
            this.BTSizeMinus.Location = new System.Drawing.Point(3, 32);
            this.BTSizeMinus.Name = "BTSizeMinus";
            this.BTSizeMinus.Size = new System.Drawing.Size(50, 23);
            this.BTSizeMinus.TabIndex = 36;
            this.BTSizeMinus.Tag = "-1";
            this.BTSizeMinus.Text = "-";
            this.BTSizeMinus.UseVisualStyleBackColor = true;
            this.BTSizeMinus.Click += new System.EventHandler(this.BTSizeMinus_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1129, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 807);
            this.listBox1.TabIndex = 37;
            this.listBox1.Tag = "-1";
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtTattoo
            // 
            this.BtTattoo.Image = global::FaceCreator.Properties.Resources.tattoo;
            this.BtTattoo.Location = new System.Drawing.Point(3, 740);
            this.BtTattoo.Name = "BtTattoo";
            this.BtTattoo.Size = new System.Drawing.Size(50, 50);
            this.BtTattoo.TabIndex = 33;
            this.BtTattoo.Tag = "-1";
            this.BtTattoo.UseVisualStyleBackColor = true;
            this.BtTattoo.Click += new System.EventHandler(this.BtTattoo_Click);
            // 
            // BtPiercing
            // 
            this.BtPiercing.Image = global::FaceCreator.Properties.Resources.piercing;
            this.BtPiercing.Location = new System.Drawing.Point(3, 684);
            this.BtPiercing.Name = "BtPiercing";
            this.BtPiercing.Size = new System.Drawing.Size(50, 50);
            this.BtPiercing.TabIndex = 32;
            this.BtPiercing.Tag = "-1";
            this.BtPiercing.UseVisualStyleBackColor = true;
            this.BtPiercing.Click += new System.EventHandler(this.BtPiercing_Click);
            // 
            // BtNose
            // 
            this.BtNose.Image = global::FaceCreator.Properties.Resources.nose;
            this.BtNose.Location = new System.Drawing.Point(3, 628);
            this.BtNose.Name = "BtNose";
            this.BtNose.Size = new System.Drawing.Size(50, 50);
            this.BtNose.TabIndex = 31;
            this.BtNose.Tag = "-1";
            this.BtNose.UseVisualStyleBackColor = true;
            this.BtNose.Click += new System.EventHandler(this.BtNose_Click);
            // 
            // BtMustache
            // 
            this.BtMustache.Image = global::FaceCreator.Properties.Resources.mustache;
            this.BtMustache.Location = new System.Drawing.Point(3, 572);
            this.BtMustache.Name = "BtMustache";
            this.BtMustache.Size = new System.Drawing.Size(50, 50);
            this.BtMustache.TabIndex = 30;
            this.BtMustache.Tag = "-1";
            this.BtMustache.UseVisualStyleBackColor = true;
            this.BtMustache.Click += new System.EventHandler(this.BtMustache_Click);
            // 
            // BtLips
            // 
            this.BtLips.Image = global::FaceCreator.Properties.Resources.lips;
            this.BtLips.Location = new System.Drawing.Point(3, 516);
            this.BtLips.Name = "BtLips";
            this.BtLips.Size = new System.Drawing.Size(50, 50);
            this.BtLips.TabIndex = 29;
            this.BtLips.Tag = "-1";
            this.BtLips.UseVisualStyleBackColor = true;
            this.BtLips.Click += new System.EventHandler(this.BtLips_Click);
            // 
            // BtHeaddress
            // 
            this.BtHeaddress.Image = global::FaceCreator.Properties.Resources.headdress;
            this.BtHeaddress.Location = new System.Drawing.Point(3, 460);
            this.BtHeaddress.Name = "BtHeaddress";
            this.BtHeaddress.Size = new System.Drawing.Size(50, 50);
            this.BtHeaddress.TabIndex = 28;
            this.BtHeaddress.Tag = "-1";
            this.BtHeaddress.UseVisualStyleBackColor = true;
            this.BtHeaddress.Click += new System.EventHandler(this.BtHeaddress_Click);
            // 
            // BtHair
            // 
            this.BtHair.Image = global::FaceCreator.Properties.Resources.hair;
            this.BtHair.Location = new System.Drawing.Point(3, 404);
            this.BtHair.Name = "BtHair";
            this.BtHair.Size = new System.Drawing.Size(50, 50);
            this.BtHair.TabIndex = 27;
            this.BtHair.Tag = "-1";
            this.BtHair.UseVisualStyleBackColor = true;
            this.BtHair.Click += new System.EventHandler(this.BtHair_Click);
            // 
            // BtGlasses
            // 
            this.BtGlasses.Image = global::FaceCreator.Properties.Resources.glasses;
            this.BtGlasses.Location = new System.Drawing.Point(3, 348);
            this.BtGlasses.Name = "BtGlasses";
            this.BtGlasses.Size = new System.Drawing.Size(50, 50);
            this.BtGlasses.TabIndex = 26;
            this.BtGlasses.Tag = "-1";
            this.BtGlasses.UseVisualStyleBackColor = true;
            this.BtGlasses.Click += new System.EventHandler(this.BtGlasses_Click);
            // 
            // BtForehead
            // 
            this.BtForehead.Image = global::FaceCreator.Properties.Resources.forehead;
            this.BtForehead.Location = new System.Drawing.Point(3, 292);
            this.BtForehead.Name = "BtForehead";
            this.BtForehead.Size = new System.Drawing.Size(50, 50);
            this.BtForehead.TabIndex = 25;
            this.BtForehead.Tag = "-1";
            this.BtForehead.UseVisualStyleBackColor = true;
            this.BtForehead.Click += new System.EventHandler(this.BtForehead_Click);
            // 
            // BtFace_shape
            // 
            this.BtFace_shape.Image = global::FaceCreator.Properties.Resources.face_shape;
            this.BtFace_shape.Location = new System.Drawing.Point(3, 236);
            this.BtFace_shape.Name = "BtFace_shape";
            this.BtFace_shape.Size = new System.Drawing.Size(50, 50);
            this.BtFace_shape.TabIndex = 24;
            this.BtFace_shape.Tag = "-1";
            this.BtFace_shape.UseVisualStyleBackColor = true;
            this.BtFace_shape.Click += new System.EventHandler(this.BtFace_shape_Click);
            // 
            // BtEyes
            // 
            this.BtEyes.Image = global::FaceCreator.Properties.Resources.eyes;
            this.BtEyes.Location = new System.Drawing.Point(3, 180);
            this.BtEyes.Name = "BtEyes";
            this.BtEyes.Size = new System.Drawing.Size(50, 50);
            this.BtEyes.TabIndex = 23;
            this.BtEyes.Tag = "-1";
            this.BtEyes.UseVisualStyleBackColor = true;
            this.BtEyes.Click += new System.EventHandler(this.BtEyes_Click);
            // 
            // BtEyebrows
            // 
            this.BtEyebrows.Image = global::FaceCreator.Properties.Resources.eyebrows;
            this.BtEyebrows.Location = new System.Drawing.Point(3, 124);
            this.BtEyebrows.Name = "BtEyebrows";
            this.BtEyebrows.Size = new System.Drawing.Size(50, 50);
            this.BtEyebrows.TabIndex = 22;
            this.BtEyebrows.Tag = "-1";
            this.BtEyebrows.UseVisualStyleBackColor = true;
            this.BtEyebrows.Click += new System.EventHandler(this.BtEyebrows_Click);
            // 
            // BtBeard
            // 
            this.BtBeard.Image = global::FaceCreator.Properties.Resources.beard;
            this.BtBeard.Location = new System.Drawing.Point(3, 68);
            this.BtBeard.Name = "BtBeard";
            this.BtBeard.Size = new System.Drawing.Size(50, 50);
            this.BtBeard.TabIndex = 21;
            this.BtBeard.Tag = "-1";
            this.BtBeard.UseVisualStyleBackColor = true;
            this.BtBeard.Click += new System.EventHandler(this.BtBeard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTSizePlus);
            this.panel1.Controls.Add(this.BtPiercing);
            this.panel1.Controls.Add(this.BtHair);
            this.panel1.Controls.Add(this.BtBeard);
            this.panel1.Controls.Add(this.BtNose);
            this.panel1.Controls.Add(this.BtEyebrows);
            this.panel1.Controls.Add(this.BtGlasses);
            this.panel1.Controls.Add(this.BtHeaddress);
            this.panel1.Controls.Add(this.BtEyes);
            this.panel1.Controls.Add(this.BtTattoo);
            this.panel1.Controls.Add(this.BtMustache);
            this.panel1.Controls.Add(this.BTSizeMinus);
            this.panel1.Controls.Add(this.BtForehead);
            this.panel1.Controls.Add(this.BtLips);
            this.panel1.Controls.Add(this.BtFace_shape);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 807);
            this.panel1.TabIndex = 40;
            this.panel1.Tag = "-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 835);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "FaceCreater";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtTattoo;
        private System.Windows.Forms.Button BtPiercing;
        private System.Windows.Forms.Button BtNose;
        private System.Windows.Forms.Button BtMustache;
        private System.Windows.Forms.Button BtLips;
        private System.Windows.Forms.Button BtHeaddress;
        private System.Windows.Forms.Button BtHair;
        private System.Windows.Forms.Button BtGlasses;
        private System.Windows.Forms.Button BtForehead;
        private System.Windows.Forms.Button BtFace_shape;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button BtEyes;
        private System.Windows.Forms.Button BtEyebrows;
        private System.Windows.Forms.Button BtBeard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button BTSizePlus;
        private System.Windows.Forms.Button BTSizeMinus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

