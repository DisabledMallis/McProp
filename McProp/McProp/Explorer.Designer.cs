namespace McProp
{
    partial class Explorer
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
            this.objectList = new System.Windows.Forms.TreeView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.valueInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // objectList
            // 
            this.objectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectList.Location = new System.Drawing.Point(12, 46);
            this.objectList.Name = "objectList";
            this.objectList.Size = new System.Drawing.Size(468, 460);
            this.objectList.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editor";
            // 
            // propNameLabel
            // 
            this.propNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.propNameLabel.AutoSize = true;
            this.propNameLabel.Location = new System.Drawing.Point(493, 87);
            this.propNameLabel.Name = "propNameLabel";
            this.propNameLabel.Size = new System.Drawing.Size(90, 13);
            this.propNameLabel.TabIndex = 3;
            this.propNameLabel.Text = "Property Name: X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value:";
            // 
            // valueBox
            // 
            this.valueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valueBox.Location = new System.Drawing.Point(536, 101);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(205, 20);
            this.valueBox.TabIndex = 5;
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.Location = new System.Drawing.Point(674, 125);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(67, 23);
            this.setButton.TabIndex = 6;
            this.setButton.Text = "Post";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // valueInputBox
            // 
            this.valueInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valueInputBox.Location = new System.Drawing.Point(493, 127);
            this.valueInputBox.Name = "valueInputBox";
            this.valueInputBox.Size = new System.Drawing.Size(175, 20);
            this.valueInputBox.TabIndex = 7;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 518);
            this.Controls.Add(this.valueInputBox);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.propNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.objectList);
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView objectList;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label propNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox valueInputBox;
    }
}