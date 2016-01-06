namespace ModelViewViewModelPattern
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
			this.components = new System.ComponentModel.Container();
			this.MakeLabel = new System.Windows.Forms.Label();
			this.ModelLabel = new System.Windows.Forms.Label();
			this.MakeTextBox = new System.Windows.Forms.TextBox();
			this.ModelTextBox = new System.Windows.Forms.TextBox();
			this.LastUpdatedLabelLabel = new System.Windows.Forms.Label();
			this.LastUpdatedLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.mainFormViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.mainFormViewModelBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// MakeLabel
			// 
			this.MakeLabel.AutoSize = true;
			this.MakeLabel.Location = new System.Drawing.Point(12, 9);
			this.MakeLabel.Name = "MakeLabel";
			this.MakeLabel.Size = new System.Drawing.Size(34, 13);
			this.MakeLabel.TabIndex = 0;
			this.MakeLabel.Text = "Make";
			// 
			// ModelLabel
			// 
			this.ModelLabel.AutoSize = true;
			this.ModelLabel.Location = new System.Drawing.Point(12, 48);
			this.ModelLabel.Name = "ModelLabel";
			this.ModelLabel.Size = new System.Drawing.Size(36, 13);
			this.ModelLabel.TabIndex = 1;
			this.ModelLabel.Text = "Model";
			// 
			// MakeTextBox
			// 
			this.MakeTextBox.Location = new System.Drawing.Point(12, 25);
			this.MakeTextBox.Name = "MakeTextBox";
			this.MakeTextBox.Size = new System.Drawing.Size(260, 20);
			this.MakeTextBox.TabIndex = 2;
			// 
			// ModelTextBox
			// 
			this.ModelTextBox.Location = new System.Drawing.Point(12, 64);
			this.ModelTextBox.Name = "ModelTextBox";
			this.ModelTextBox.Size = new System.Drawing.Size(260, 20);
			this.ModelTextBox.TabIndex = 3;
			// 
			// LastUpdatedLabelLabel
			// 
			this.LastUpdatedLabelLabel.AutoSize = true;
			this.LastUpdatedLabelLabel.Location = new System.Drawing.Point(13, 87);
			this.LastUpdatedLabelLabel.Name = "LastUpdatedLabelLabel";
			this.LastUpdatedLabelLabel.Size = new System.Drawing.Size(71, 13);
			this.LastUpdatedLabelLabel.TabIndex = 4;
			this.LastUpdatedLabelLabel.Text = "Last Updated";
			// 
			// LastUpdatedLabel
			// 
			this.LastUpdatedLabel.AutoSize = true;
			this.LastUpdatedLabel.Location = new System.Drawing.Point(13, 110);
			this.LastUpdatedLabel.Name = "LastUpdatedLabel";
			this.LastUpdatedLabel.Size = new System.Drawing.Size(77, 13);
			this.LastUpdatedLabel.TabIndex = 5;
			this.LastUpdatedLabel.Text = "[Last Updated]";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(16, 138);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(256, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// mainFormViewModelBindingSource
			// 
			this.mainFormViewModelBindingSource.DataSource = typeof(ModelViewViewModelPattern.ViewModels.MainFormViewModel);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 171);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.LastUpdatedLabel);
			this.Controls.Add(this.LastUpdatedLabelLabel);
			this.Controls.Add(this.ModelTextBox);
			this.Controls.Add(this.MakeTextBox);
			this.Controls.Add(this.ModelLabel);
			this.Controls.Add(this.MakeLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Model View ViewModel Example";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.mainFormViewModelBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MakeLabel;
		private System.Windows.Forms.Label ModelLabel;
		private System.Windows.Forms.TextBox MakeTextBox;
		private System.Windows.Forms.TextBox ModelTextBox;
		private System.Windows.Forms.Label LastUpdatedLabelLabel;
		private System.Windows.Forms.Label LastUpdatedLabel;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.BindingSource mainFormViewModelBindingSource;
	}
}

