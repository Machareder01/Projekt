namespace coffeeshop
{
    partial class ClientForm
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCoffeeCount = new System.Windows.Forms.Label();
            this.tbCoffeeCount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbReceipt = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(12, 9);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 31);
            this.lbUserName.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(63, 172);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(437, 86);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Bestellen";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(507, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(437, 86);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCoffeeCount);
            this.panel1.Controls.Add(this.tbCoffeeCount);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 276);
            this.panel1.TabIndex = 6;
            // 
            // lbCoffeeCount
            // 
            this.lbCoffeeCount.AutoSize = true;
            this.lbCoffeeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoffeeCount.Location = new System.Drawing.Point(528, 92);
            this.lbCoffeeCount.Name = "lbCoffeeCount";
            this.lbCoffeeCount.Size = new System.Drawing.Size(96, 37);
            this.lbCoffeeCount.TabIndex = 7;
            this.lbCoffeeCount.Text = "Kaffe";
            // 
            // tbCoffeeCount
            // 
            this.tbCoffeeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCoffeeCount.Location = new System.Drawing.Point(378, 61);
            this.tbCoffeeCount.Multiline = true;
            this.tbCoffeeCount.Name = "tbCoffeeCount";
            this.tbCoffeeCount.Size = new System.Drawing.Size(122, 94);
            this.tbCoffeeCount.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbReceipt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 465);
            this.panel2.TabIndex = 7;
            // 
            // tbReceipt
            // 
            this.tbReceipt.Location = new System.Drawing.Point(63, 6);
            this.tbReceipt.Multiline = true;
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.Size = new System.Drawing.Size(881, 337);
            this.tbReceipt.TabIndex = 0;
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImage = global::coffeeshop.Properties.Resources.Minus_Rot;
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.Location = new System.Drawing.Point(66, 61);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(117, 94);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImage = global::coffeeshop.Properties.Resources.Plus_Grün;
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlus.Location = new System.Drawing.Point(824, 61);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(120, 94);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCoffeeCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbReceipt;
        private System.Windows.Forms.Label lbCoffeeCount;

    }
}