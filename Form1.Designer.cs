namespace Pizza_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTitle = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCrushType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbWhereToEAT = new System.Windows.Forms.Label();
            this.lbThick = new System.Windows.Forms.Label();
            this.lbTopping = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrushType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Wyntex Brasco", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lbTitle.Location = new System.Drawing.Point(228, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(346, 65);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Make Your Pizza";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbSmall.Location = new System.Drawing.Point(29, 28);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbLarge.Location = new System.Drawing.Point(29, 74);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(46, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Larg";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbMeduim.Location = new System.Drawing.Point(29, 51);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(62, 17);
            this.rbMeduim.TabIndex = 2;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSize.Location = new System.Drawing.Point(91, 115);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(109, 106);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbCrushType
            // 
            this.gbCrushType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrushType.Controls.Add(this.rbThinkCrust);
            this.gbCrushType.Controls.Add(this.rbThinCrust);
            this.gbCrushType.ForeColor = System.Drawing.Color.White;
            this.gbCrushType.Location = new System.Drawing.Point(91, 260);
            this.gbCrushType.Name = "gbCrushType";
            this.gbCrushType.Size = new System.Drawing.Size(124, 87);
            this.gbCrushType.TabIndex = 4;
            this.gbCrushType.TabStop = false;
            this.gbCrushType.Text = "Crush Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.ForeColor = System.Drawing.Color.White;
            this.rbThinkCrust.Location = new System.Drawing.Point(29, 51);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(79, 17);
            this.rbThinkCrust.TabIndex = 2;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.ForeColor = System.Drawing.Color.White;
            this.rbThinCrust.Location = new System.Drawing.Point(29, 28);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gbWhereToEat.Location = new System.Drawing.Point(239, 260);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(148, 45);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
  
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.ForeColor = System.Drawing.Color.White;
            this.rbEatOut.Location = new System.Drawing.Point(72, 19);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(61, 17);
            this.rbEatOut.TabIndex = 2;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.ForeColor = System.Drawing.Color.White;
            this.rbEatIn.Location = new System.Drawing.Point(13, 19);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(53, 17);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Salmon;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("WTFCyanSansW01-Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrder.Location = new System.Drawing.Point(239, 356);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(109, 36);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Salmon;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("WTFCyanSansW01-Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(390, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Rest Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.Controls.Add(this.cbGreenPeppers);
            this.gbTopping.Controls.Add(this.cbTomatoes);
            this.gbTopping.Controls.Add(this.cbOlives);
            this.gbTopping.Controls.Add(this.cbMushrooms);
            this.gbTopping.Controls.Add(this.cbOnion);
            this.gbTopping.Controls.Add(this.cbExtraCheese);
            this.gbTopping.ForeColor = System.Drawing.Color.White;
            this.gbTopping.Location = new System.Drawing.Point(239, 115);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(260, 106);
            this.gbTopping.TabIndex = 4;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.ForeColor = System.Drawing.Color.White;
            this.cbGreenPeppers.Location = new System.Drawing.Point(132, 74);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.cbGreenPeppers.TabIndex = 5;
            this.cbGreenPeppers.Tag = "5";
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.ForeColor = System.Drawing.Color.White;
            this.cbTomatoes.Location = new System.Drawing.Point(25, 74);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.cbTomatoes.TabIndex = 4;
            this.cbTomatoes.Tag = "5";
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.ForeColor = System.Drawing.Color.White;
            this.cbOlives.Location = new System.Drawing.Point(132, 50);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(55, 17);
            this.cbOlives.TabIndex = 3;
            this.cbOlives.Tag = "5";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.ForeColor = System.Drawing.Color.White;
            this.cbMushrooms.Location = new System.Drawing.Point(25, 50);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.cbMushrooms.TabIndex = 2;
            this.cbMushrooms.Tag = "5";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.ForeColor = System.Drawing.Color.White;
            this.cbOnion.Location = new System.Drawing.Point(132, 26);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(54, 17);
            this.cbOnion.TabIndex = 1;
            this.cbOnion.Tag = "5";
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.ForeColor = System.Drawing.Color.White;
            this.cbExtraCheese.Location = new System.Drawing.Point(25, 26);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.cbExtraCheese.TabIndex = 0;
            this.cbExtraCheese.Tag = "5";
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraCheese_CheckedChanged);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lbPrice);
            this.gbSummary.Controls.Add(this.lbWhereToEAT);
            this.gbSummary.Controls.Add(this.lbThick);
            this.gbSummary.Controls.Add(this.lbTopping);
            this.gbSummary.Controls.Add(this.lbSize);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.ForeColor = System.Drawing.Color.White;
            this.gbSummary.Location = new System.Drawing.Point(543, 115);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(234, 307);
            this.gbSummary.TabIndex = 8;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("a Adelfa", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbPrice.Location = new System.Drawing.Point(77, 220);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(141, 96);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "$50";
            // 
            // lbWhereToEAT
            // 
            this.lbWhereToEAT.AutoSize = true;
            this.lbWhereToEAT.Location = new System.Drawing.Point(48, 175);
            this.lbWhereToEAT.Name = "lbWhereToEAT";
            this.lbWhereToEAT.Size = new System.Drawing.Size(43, 13);
            this.lbWhereToEAT.TabIndex = 8;
            this.lbWhereToEAT.Text = "Eat Out";
            // 
            // lbThick
            // 
            this.lbThick.AutoSize = true;
            this.lbThick.Location = new System.Drawing.Point(104, 123);
            this.lbThick.Name = "lbThick";
            this.lbThick.Size = new System.Drawing.Size(64, 13);
            this.lbThick.TabIndex = 7;
            this.lbThick.Text = "Thick Crush";
            // 
            // lbTopping
            // 
            this.lbTopping.AutoSize = true;
            this.lbTopping.Location = new System.Drawing.Point(48, 81);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(63, 13);
            this.lbTopping.TabIndex = 6;
            this.lbTopping.Text = "No Topping";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(63, 30);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(34, 13);
            this.lbSize.TabIndex = 5;
            this.lbSize.Text = "Large";
            this.lbSize.Click += new System.EventHandler(this.lbSize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Where to Eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crush Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Topping :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrushType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrushType.ResumeLayout(false);
            this.gbCrushType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrushType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbWhereToEAT;
        private System.Windows.Forms.Label lbThick;
        private System.Windows.Forms.Label lbTopping;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbOlives;
    }
}

