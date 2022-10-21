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
            this.gameLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1Points
            // 
            this.player1Points.AutoSize = true;
            this.player1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Points.Location = new System.Drawing.Point(35, 28);
            this.player1Points.Name = "player1Points";
            this.player1Points.Size = new System.Drawing.Size(134, 147);
            this.player1Points.TabIndex = 0;
            this.player1Points.Text = "0";
            // 
            // player2Points
            // 
            this.player2Points.AutoSize = true;
            this.player2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Points.Location = new System.Drawing.Point(1196, 28);
            this.player2Points.Name = "player2Points";
            this.player2Points.Size = new System.Drawing.Size(134, 147);
            this.player2Points.TabIndex = 1;
            this.player2Points.Text = "0";
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(160, 48);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(226, 108);
            this.player1Name.TabIndex = 2;
            this.player1Name.Text = "ISTI";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(961, 48);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(229, 108);
            this.player2Name.TabIndex = 3;
            this.player2Name.Text = "Gép";
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(545, 61);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(177, 79);
            this.startGame.TabIndex = 4;
            this.startGame.Text = "Új játék indítása";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // gameLayoutPanel
            // 
            this.gameLayoutPanel.Location = new System.Drawing.Point(71, 216);
            this.gameLayoutPanel.Name = "gameLayoutPanel";
            this.gameLayoutPanel.Size = new System.Drawing.Size(1313, 559);
            this.gameLayoutPanel.TabIndex = 5;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(271, 835);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(875, 42);
            this.message.TabIndex = 6;
            this.message.Text = "Kattinston az Új játék indítása gombra a kezdéshez!";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1575, 949);
            this.Controls.Add(this.message);
            this.Controls.Add(this.gameLayoutPanel);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.player2Points);
            this.Controls.Add(this.player1Points);
            this.Name = "GameForm";
            this.Text = "Kő Papír Olló játék";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Points;
        private System.Windows.Forms.Label player2Points;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.FlowLayoutPanel gameLayoutPanel;
        private System.Windows.Forms.Label message;
    }
}

