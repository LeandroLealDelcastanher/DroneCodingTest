namespace DroneCodingTest
{
    partial class DroneCodingTest
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
            this.bt_select_file = new System.Windows.Forms.Button();
            this.dronesGridView = new System.Windows.Forms.DataGridView();
            this.DroneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DroneMaxWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_run = new System.Windows.Forms.Button();
            this.locationsGridView = new System.Windows.Forms.DataGridView();
            this.LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dronesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_select_file
            // 
            this.bt_select_file.Location = new System.Drawing.Point(513, 388);
            this.bt_select_file.Name = "bt_select_file";
            this.bt_select_file.Size = new System.Drawing.Size(75, 23);
            this.bt_select_file.TabIndex = 0;
            this.bt_select_file.Text = "Select File";
            this.bt_select_file.UseVisualStyleBackColor = true;
            this.bt_select_file.Click += new System.EventHandler(this.Bt_select_file_Click);
            // 
            // dronesGridView
            // 
            this.dronesGridView.AllowUserToAddRows = false;
            this.dronesGridView.AllowUserToDeleteRows = false;
            this.dronesGridView.AllowUserToResizeColumns = false;
            this.dronesGridView.AllowUserToResizeRows = false;
            this.dronesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dronesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DroneName,
            this.DroneMaxWeight});
            this.dronesGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dronesGridView.Location = new System.Drawing.Point(12, 31);
            this.dronesGridView.Name = "dronesGridView";
            this.dronesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dronesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dronesGridView.ShowRowErrors = false;
            this.dronesGridView.Size = new System.Drawing.Size(244, 382);
            this.dronesGridView.TabIndex = 1;
            this.dronesGridView.Tag = "";
            // 
            // DroneName
            // 
            this.DroneName.HeaderText = "Name";
            this.DroneName.Name = "DroneName";
            this.DroneName.ReadOnly = true;
            // 
            // DroneMaxWeight
            // 
            this.DroneMaxWeight.HeaderText = "Max Weight";
            this.DroneMaxWeight.Name = "DroneMaxWeight";
            this.DroneMaxWeight.ReadOnly = true;
            // 
            // bt_run
            // 
            this.bt_run.Location = new System.Drawing.Point(513, 417);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(75, 23);
            this.bt_run.TabIndex = 2;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.Bt_run_Click);
            // 
            // locationsGridView
            // 
            this.locationsGridView.AllowUserToAddRows = false;
            this.locationsGridView.AllowUserToDeleteRows = false;
            this.locationsGridView.AllowUserToResizeColumns = false;
            this.locationsGridView.AllowUserToResizeRows = false;
            this.locationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocationName,
            this.LocationWeight});
            this.locationsGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.locationsGridView.Location = new System.Drawing.Point(262, 31);
            this.locationsGridView.Name = "locationsGridView";
            this.locationsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.locationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.locationsGridView.ShowRowErrors = false;
            this.locationsGridView.Size = new System.Drawing.Size(245, 382);
            this.locationsGridView.TabIndex = 4;
            // 
            // LocationName
            // 
            this.LocationName.HeaderText = "Name";
            this.LocationName.Name = "LocationName";
            this.LocationName.ReadOnly = true;
            // 
            // LocationWeight
            // 
            this.LocationWeight.HeaderText = "Weight";
            this.LocationWeight.Name = "LocationWeight";
            this.LocationWeight.ReadOnly = true;
            // 
            // textMessage
            // 
            this.textMessage.ForeColor = System.Drawing.Color.Red;
            this.textMessage.Location = new System.Drawing.Point(12, 419);
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.Size = new System.Drawing.Size(495, 20);
            this.textMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Locations";
            // 
            // DroneCodingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.locationsGridView);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.dronesGridView);
            this.Controls.Add(this.bt_select_file);
            this.Name = "DroneCodingTest";
            this.Text = "prazo";
            ((System.ComponentModel.ISupportInitialize)(this.dronesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_select_file;
        private System.Windows.Forms.DataGridView dronesGridView;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.DataGridView locationsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DroneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DroneMaxWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationWeight;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

