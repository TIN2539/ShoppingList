namespace ShoppingList
{
	partial class MainWindow
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
			this.addButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.productTextBox = new System.Windows.Forms.TextBox();
			this.productCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.downButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.Enabled = false;
			this.addButton.Location = new System.Drawing.Point(138, 317);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(110, 23);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.Enabled = false;
			this.deleteButton.Location = new System.Drawing.Point(12, 346);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(236, 23);
			this.deleteButton.TabIndex = 1;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// productTextBox
			// 
			this.productTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.productTextBox.Location = new System.Drawing.Point(12, 317);
			this.productTextBox.Name = "productTextBox";
			this.productTextBox.Size = new System.Drawing.Size(120, 20);
			this.productTextBox.TabIndex = 2;
			this.productTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
			// 
			// productCheckedListBox
			// 
			this.productCheckedListBox.Items.AddRange(new object[] {
            "Avocado",
            "Chicken",
            "Milk",
            "Rice",
            "Eqqs"});
			this.productCheckedListBox.Location = new System.Drawing.Point(12, 12);
			this.productCheckedListBox.Name = "productCheckedListBox";
			this.productCheckedListBox.Size = new System.Drawing.Size(327, 289);
			this.productCheckedListBox.TabIndex = 4;
			this.productCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ProductCheckedListBox_ItemCheck);
			this.productCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ProductCheckedListBox_SelectedIndexChanged);
			// 
			// downButton
			// 
			this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.downButton.Enabled = false;
			this.downButton.Location = new System.Drawing.Point(254, 346);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(85, 23);
			this.downButton.TabIndex = 5;
			this.downButton.Text = "Down";
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.DownButton_Click);
			// 
			// upButton
			// 
			this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.upButton.Enabled = false;
			this.upButton.Location = new System.Drawing.Point(254, 317);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(85, 23);
			this.upButton.TabIndex = 6;
			this.upButton.Text = "Up";
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 381);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.productCheckedListBox);
			this.Controls.Add(this.productTextBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.addButton);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shopping List";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox productTextBox;
		private System.Windows.Forms.CheckedListBox productCheckedListBox;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button upButton;
	}
}

