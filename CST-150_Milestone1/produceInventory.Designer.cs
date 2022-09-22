namespace CST_150_Milestone1
{
    partial class produceInvFrm
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
            this.prodInvLstBx = new System.Windows.Forms.ListBox();
            this.produceInvLbl = new System.Windows.Forms.Label();
            this.addItemTxt = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.removeItmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodInvLstBx
            // 
            this.prodInvLstBx.FormattingEnabled = true;
            this.prodInvLstBx.Items.AddRange(new object[] {
            "Lettuce",
            "Tomato",
            "Cucumber",
            "Squash",
            "Orange",
            "Apple",
            "Grapes"});
            this.prodInvLstBx.Location = new System.Drawing.Point(26, 25);
            this.prodInvLstBx.Name = "prodInvLstBx";
            this.prodInvLstBx.Size = new System.Drawing.Size(166, 121);
            this.prodInvLstBx.TabIndex = 1;
            // 
            // produceInvLbl
            // 
            this.produceInvLbl.AutoSize = true;
            this.produceInvLbl.Location = new System.Drawing.Point(54, 9);
            this.produceInvLbl.Name = "produceInvLbl";
            this.produceInvLbl.Size = new System.Drawing.Size(94, 13);
            this.produceInvLbl.TabIndex = 2;
            this.produceInvLbl.Text = "Produce Inventory";
            // 
            // addItemTxt
            // 
            this.addItemTxt.Location = new System.Drawing.Point(26, 152);
            this.addItemTxt.Name = "addItemTxt";
            this.addItemTxt.Size = new System.Drawing.Size(248, 20);
            this.addItemTxt.TabIndex = 3;
            this.addItemTxt.Text = "Type here to add an item to the produce inventory.";
            this.addItemTxt.TextChanged += new System.EventHandler(this.addItemTxt_TextChanged);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(26, 204);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // removeItmBtn
            // 
            this.removeItmBtn.Location = new System.Drawing.Point(126, 204);
            this.removeItmBtn.Name = "removeItmBtn";
            this.removeItmBtn.Size = new System.Drawing.Size(75, 23);
            this.removeItmBtn.TabIndex = 5;
            this.removeItmBtn.Text = "Remove Item";
            this.removeItmBtn.UseVisualStyleBackColor = true;
            this.removeItmBtn.Click += new System.EventHandler(this.removeItmBtn_Click);
            // 
            // produceInvFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeItmBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.addItemTxt);
            this.Controls.Add(this.produceInvLbl);
            this.Controls.Add(this.prodInvLstBx);
            this.Name = "produceInvFrm";
            this.Text = "Produce Inventory";
            this.Load += new System.EventHandler(this.produceInvFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox prodInvLstBx;
        private System.Windows.Forms.Label produceInvLbl;
        private System.Windows.Forms.TextBox addItemTxt;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button removeItmBtn;
    }
}

