namespace rpg_Game_V1
{
    partial class ChoiceWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPlayerStats = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonContinue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPlayerStats, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonContinue.Font = new System.Drawing.Font("MetalShred", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(3, 52);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(820, 193);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "CONTINUE FORWAR";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Font = new System.Drawing.Font("MetalShred", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(3, 251);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(820, 194);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "RESTART THIS ADVENTURE";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelPlayerStats
            // 
            this.labelPlayerStats.AutoSize = true;
            this.labelPlayerStats.Location = new System.Drawing.Point(3, 0);
            this.labelPlayerStats.Name = "labelPlayerStats";
            this.labelPlayerStats.Size = new System.Drawing.Size(38, 17);
            this.labelPlayerStats.TabIndex = 2;
            this.labelPlayerStats.Text = "stats";
            // 
            // ChoiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChoiceWindow";
            this.Text = "ChoiceWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelPlayerStats;
    }
}