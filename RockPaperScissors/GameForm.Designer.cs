namespace RockPaperScissors
{
    partial class GameForm
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
            this.player1Points = new System.Windows.Forms.Label();
            this.player2Points = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.mainGameInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.player2DataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.player1DataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainGameInfoPanel.SuspendLayout();
            this.player2DataPanel.SuspendLayout();
            this.player1DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1Points
            // 
            this.player1Points.AutoSize = true;
            this.player1Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Points.Location = new System.Drawing.Point(3, 0);
            this.player1Points.Name = "player1Points";
            this.player1Points.Size = new System.Drawing.Size(94, 147);
            this.player1Points.TabIndex = 0;
            this.player1Points.Text = "0";
            this.player1Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Points
            // 
            this.player2Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Points.Location = new System.Drawing.Point(253, 0);
            this.player2Points.Name = "player2Points";
            this.player2Points.Size = new System.Drawing.Size(94, 147);
            this.player2Points.TabIndex = 1;
            this.player2Points.Text = "0";
            this.player2Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(103, 0);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(244, 147);
            this.player1Name.TabIndex = 2;
            this.player1Name.Text = "ISTI";
            this.player1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(3, 0);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(244, 147);
            this.player2Name.TabIndex = 3;
            this.player2Name.Text = "BOT";
            this.player2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGame
            // 
            this.startGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startGame.Location = new System.Drawing.Point(380, 30);
            this.startGame.Margin = new System.Windows.Forms.Padding(30);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(740, 93);
            this.startGame.TabIndex = 4;
            this.startGame.Text = "Új játék indítása";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // mainGameInfoPanel
            // 
            this.mainGameInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainGameInfoPanel.AutoSize = true;
            this.mainGameInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainGameInfoPanel.ColumnCount = 3;
            this.mainGameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.mainGameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.mainGameInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.mainGameInfoPanel.Controls.Add(this.startGame, 1, 0);
            this.mainGameInfoPanel.Controls.Add(this.player2DataPanel, 2, 0);
            this.mainGameInfoPanel.Controls.Add(this.player1DataPanel, 0, 0);
            this.mainGameInfoPanel.Location = new System.Drawing.Point(77, 50);
            this.mainGameInfoPanel.Name = "mainGameInfoPanel";
            this.mainGameInfoPanel.RowCount = 1;
            this.mainGameInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainGameInfoPanel.Size = new System.Drawing.Size(1500, 160);
            this.mainGameInfoPanel.TabIndex = 7;
            // 
            // player2DataPanel
            // 
            this.player2DataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.player2DataPanel.ColumnCount = 2;
            this.player2DataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.player2DataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.player2DataPanel.Controls.Add(this.player2Name, 0, 0);
            this.player2DataPanel.Controls.Add(this.player2Points, 1, 0);
            this.player2DataPanel.Location = new System.Drawing.Point(1153, 3);
            this.player2DataPanel.Name = "player2DataPanel";
            this.player2DataPanel.RowCount = 1;
            this.player2DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.player2DataPanel.Size = new System.Drawing.Size(344, 147);
            this.player2DataPanel.TabIndex = 9;
            // 
            // player1DataPanel
            // 
            this.player1DataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.player1DataPanel.ColumnCount = 2;
            this.player1DataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.player1DataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.player1DataPanel.Controls.Add(this.player1Points, 0, 0);
            this.player1DataPanel.Controls.Add(this.player1Name, 1, 0);
            this.player1DataPanel.Location = new System.Drawing.Point(3, 3);
            this.player1DataPanel.Name = "player1DataPanel";
            this.player1DataPanel.RowCount = 1;
            this.player1DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.player1DataPanel.Size = new System.Drawing.Size(344, 147);
            this.player1DataPanel.TabIndex = 8;
            // 
            // gameLayoutPanel
            // 
            this.gameLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gameLayoutPanel.ColumnCount = 1;
            this.gameLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameLayoutPanel.Location = new System.Drawing.Point(77, 250);
            this.gameLayoutPanel.Name = "gameLayoutPanel";
            this.gameLayoutPanel.RowCount = 1;
            this.gameLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameLayoutPanel.Size = new System.Drawing.Size(1500, 739);
            this.gameLayoutPanel.TabIndex = 8;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1654, 1034);
            this.Controls.Add(this.gameLayoutPanel);
            this.Controls.Add(this.mainGameInfoPanel);
            this.Name = "GameForm";
            this.Text = "Kő Papír Olló játék";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.mainGameInfoPanel.ResumeLayout(false);
            this.player2DataPanel.ResumeLayout(false);
            this.player2DataPanel.PerformLayout();
            this.player1DataPanel.ResumeLayout(false);
            this.player1DataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Points;
        private System.Windows.Forms.Label player2Points;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TableLayoutPanel mainGameInfoPanel;
        private System.Windows.Forms.TableLayoutPanel player2DataPanel;
        private System.Windows.Forms.TableLayoutPanel player1DataPanel;
        private System.Windows.Forms.TableLayoutPanel gameLayoutPanel;
    }
}

