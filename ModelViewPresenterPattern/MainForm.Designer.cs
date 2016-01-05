namespace ModelViewPresenterPattern
{
	partial class MainForm
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
			this.FoodListBox = new System.Windows.Forms.ListBox();
			this.SortButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FoodListBox
			// 
			this.FoodListBox.FormattingEnabled = true;
			this.FoodListBox.Location = new System.Drawing.Point(12, 12);
			this.FoodListBox.Name = "FoodListBox";
			this.FoodListBox.Size = new System.Drawing.Size(176, 238);
			this.FoodListBox.TabIndex = 0;
			// 
			// SortButton
			// 
			this.SortButton.Location = new System.Drawing.Point(12, 256);
			this.SortButton.Name = "SortButton";
			this.SortButton.Size = new System.Drawing.Size(176, 23);
			this.SortButton.TabIndex = 1;
			this.SortButton.Text = "Sort";
			this.SortButton.UseVisualStyleBackColor = true;
			this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(200, 284);
			this.Controls.Add(this.SortButton);
			this.Controls.Add(this.FoodListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Food List";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox FoodListBox;
		private System.Windows.Forms.Button SortButton;
	}
}

