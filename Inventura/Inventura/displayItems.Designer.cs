namespace Inventura
{
    partial class displayItems
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
            this.hardwareDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.computerDataGrid = new System.Windows.Forms.DataGridView();
            this.monitorDataGrid = new System.Windows.Forms.DataGridView();
            this.softwareDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delHardware = new System.Windows.Forms.Button();
            this.delComputer = new System.Windows.Forms.Button();
            this.delMonitor = new System.Windows.Forms.Button();
            this.delSoftware = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hardwareDataGrid
            // 
            this.hardwareDataGrid.AllowUserToAddRows = false;
            this.hardwareDataGrid.AllowUserToDeleteRows = false;
            this.hardwareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardwareDataGrid.Location = new System.Drawing.Point(15, 25);
            this.hardwareDataGrid.Name = "hardwareDataGrid";
            this.hardwareDataGrid.Size = new System.Drawing.Size(691, 201);
            this.hardwareDataGrid.TabIndex = 0;
            this.hardwareDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.hardwareDataGrid_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hardware";
            // 
            // computerDataGrid
            // 
            this.computerDataGrid.AllowUserToAddRows = false;
            this.computerDataGrid.AllowUserToDeleteRows = false;
            this.computerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerDataGrid.Location = new System.Drawing.Point(722, 25);
            this.computerDataGrid.Name = "computerDataGrid";
            this.computerDataGrid.Size = new System.Drawing.Size(691, 201);
            this.computerDataGrid.TabIndex = 2;
            this.computerDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.computerDataGrid_CellEndEdit);
            // 
            // monitorDataGrid
            // 
            this.monitorDataGrid.AllowUserToAddRows = false;
            this.monitorDataGrid.AllowUserToDeleteRows = false;
            this.monitorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitorDataGrid.Location = new System.Drawing.Point(15, 296);
            this.monitorDataGrid.Name = "monitorDataGrid";
            this.monitorDataGrid.Size = new System.Drawing.Size(691, 201);
            this.monitorDataGrid.TabIndex = 3;
            this.monitorDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.monitorDataGrid_CellEndEdit);
            // 
            // softwareDataGrid
            // 
            this.softwareDataGrid.AllowUserToAddRows = false;
            this.softwareDataGrid.AllowUserToDeleteRows = false;
            this.softwareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareDataGrid.Location = new System.Drawing.Point(722, 296);
            this.softwareDataGrid.Name = "softwareDataGrid";
            this.softwareDataGrid.Size = new System.Drawing.Size(691, 201);
            this.softwareDataGrid.TabIndex = 4;
            this.softwareDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.softwareDataGrid_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Software";
            // 
            // delHardware
            // 
            this.delHardware.Location = new System.Drawing.Point(15, 233);
            this.delHardware.Name = "delHardware";
            this.delHardware.Size = new System.Drawing.Size(691, 23);
            this.delHardware.TabIndex = 8;
            this.delHardware.Text = "Izbrisi oznacen izdelek";
            this.delHardware.UseVisualStyleBackColor = true;
            this.delHardware.Click += new System.EventHandler(this.delHardware_Click);
            // 
            // delComputer
            // 
            this.delComputer.Location = new System.Drawing.Point(722, 232);
            this.delComputer.Name = "delComputer";
            this.delComputer.Size = new System.Drawing.Size(691, 23);
            this.delComputer.TabIndex = 9;
            this.delComputer.Text = "Izbrisi oznacen izdelek";
            this.delComputer.UseVisualStyleBackColor = true;
            this.delComputer.Click += new System.EventHandler(this.delComputer_Click);
            // 
            // delMonitor
            // 
            this.delMonitor.Location = new System.Drawing.Point(15, 503);
            this.delMonitor.Name = "delMonitor";
            this.delMonitor.Size = new System.Drawing.Size(691, 23);
            this.delMonitor.TabIndex = 10;
            this.delMonitor.Text = "Izbrisi oznacen izdelek";
            this.delMonitor.UseVisualStyleBackColor = true;
            this.delMonitor.Click += new System.EventHandler(this.delMonitor_Click);
            // 
            // delSoftware
            // 
            this.delSoftware.Location = new System.Drawing.Point(722, 503);
            this.delSoftware.Name = "delSoftware";
            this.delSoftware.Size = new System.Drawing.Size(691, 23);
            this.delSoftware.TabIndex = 11;
            this.delSoftware.Text = "Izbrisi oznacen izdelek";
            this.delSoftware.UseVisualStyleBackColor = true;
            this.delSoftware.Click += new System.EventHandler(this.delSoftware_Click);
            // 
            // displayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 549);
            this.Controls.Add(this.delSoftware);
            this.Controls.Add(this.delMonitor);
            this.Controls.Add(this.delComputer);
            this.Controls.Add(this.delHardware);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.softwareDataGrid);
            this.Controls.Add(this.monitorDataGrid);
            this.Controls.Add(this.computerDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardwareDataGrid);
            this.Name = "displayItems";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.displayItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hardwareDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView computerDataGrid;
        private System.Windows.Forms.DataGridView monitorDataGrid;
        private System.Windows.Forms.DataGridView softwareDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delHardware;
        private System.Windows.Forms.Button delComputer;
        private System.Windows.Forms.Button delMonitor;
        private System.Windows.Forms.Button delSoftware;
    }
}