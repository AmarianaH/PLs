namespace PriceCompareUI
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.choosingQuantity1 = new PriceCompareUI.ChoosingQuantity();
            this.addingToCart1 = new PriceCompareUI.AddingToCart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.choosingQuantity1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addingToCart1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(905, 472);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // choosingQuantity1
            // 
            this.choosingQuantity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choosingQuantity1.Location = new System.Drawing.Point(0, 0);
            this.choosingQuantity1.Name = "choosingQuantity1";
            this.choosingQuantity1.Size = new System.Drawing.Size(354, 472);
            this.choosingQuantity1.TabIndex = 0;
            this.choosingQuantity1.Load += new System.EventHandler(this.choosingQuantity1_Load_1);
            // 
            // addingToCart1
            // 
            this.addingToCart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addingToCart1.Location = new System.Drawing.Point(0, 0);
            this.addingToCart1.Name = "addingToCart1";
            this.addingToCart1.Size = new System.Drawing.Size(547, 472);
            this.addingToCart1.TabIndex = 0;
            this.addingToCart1.Load += new System.EventHandler(this.addingToCart1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(905, 472);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "השוואת מחירים - דף הבית";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AddingToCart addingToCart1;
        private ChoosingQuantity choosingQuantity1;
    }
}

