namespace rpg_Game_V1
{
    partial class LooseWindow
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.pictureBoxLooser = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLooser)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRestart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.25277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74723F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(464, 391);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(455, 57);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "EXIT AS LOOSER";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRestart.Location = new System.Drawing.Point(3, 391);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(455, 57);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "TRY AGAIN";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // pictureBoxLooser
            // 
            this.pictureBoxLooser.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLooser.Name = "pictureBoxLooser";
            this.pictureBoxLooser.Size = new System.Drawing.Size(913, 379);
            this.pictureBoxLooser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLooser.TabIndex = 0;
            this.pictureBoxLooser.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxLooser);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(916, 382);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LooseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LooseWindow";
            this.Text = "LooseWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLooser)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLooser;
    }
}