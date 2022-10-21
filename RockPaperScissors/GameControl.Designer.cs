namespace RockPaperScissors
{
    partial class GameControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.selectionContainer = new System.Windows.Forms.TableLayoutPanel();
            this.selectionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRock
            // 
            this.buttonRock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRock.BackgroundImage = global::RockPaperScissors.Properties.Resources.rock;
            this.buttonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRock.Location = new System.Drawing.Point(50, 50);
            this.buttonRock.Margin = new System.Windows.Forms.Padding(50);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(250, 250);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaper.BackgroundImage = global::RockPaperScissors.Properties.Resources.paper;
            this.buttonPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPaper.Location = new System.Drawing.Point(400, 50);
            this.buttonPaper.Margin = new System.Windows.Forms.Padding(50);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(250, 250);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScissors.BackgroundImage = global::RockPaperScissors.Properties.Resources.scissors;
            this.buttonScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonScissors.Location = new System.Drawing.Point(750, 50);
            this.buttonScissors.Margin = new System.Windows.Forms.Padding(50);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(250, 250);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // selectionContainer
            // 
            this.selectionContainer.AutoSize = true;
            this.selectionContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectionContainer.ColumnCount = 3;
            this.selectionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectionContainer.Controls.Add(this.buttonRock, 0, 0);
            this.selectionContainer.Controls.Add(this.buttonScissors, 2, 0);
            this.selectionContainer.Controls.Add(this.buttonPaper, 1, 0);
            this.selectionContainer.Location = new System.Drawing.Point(3, 3);
            this.selectionContainer.Name = "selectionContainer";
            this.selectionContainer.RowCount = 1;
            this.selectionContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectionContainer.Size = new System.Drawing.Size(1050, 350);
            this.selectionContainer.TabIndex = 3;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.selectionContainer);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(1056, 356);
            this.selectionContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.TableLayoutPanel selectionContainer;
    }
}
