namespace FaceCreator
{
    partial class FSave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSave));
            this.label1 = new System.Windows.Forms.Label();
            this.BTYes = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "You sure?";
            // 
            // BTYes
            // 
            this.BTYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTYes.Location = new System.Drawing.Point(30, 74);
            this.BTYes.Name = "BTYes";
            this.BTYes.Size = new System.Drawing.Size(75, 23);
            this.BTYes.TabIndex = 1;
            this.BTYes.Text = "Yes";
            this.BTYes.UseVisualStyleBackColor = true;
            // 
            // BTCancel
            // 
            this.BTCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTCancel.Location = new System.Drawing.Point(171, 74);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 2;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            // 
            // FSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 140);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTYes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5000, 0);
            this.Name = "FSave";
            this.Text = "You sure?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTYes;
        private System.Windows.Forms.Button BTCancel;
    }
}