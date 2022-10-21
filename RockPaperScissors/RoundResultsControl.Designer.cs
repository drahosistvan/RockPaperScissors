namespace RockPaperScissors
{
    partial class RoundResultsControl
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
            this.player1ResultText = new System.Windows.Forms.Label();
            this.player2ResultText = new System.Windows.Forms.Label();
            this.continueGameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finishGameButton = new System.Windows.Forms.Button();
            this.player1Picture = new System.Windows.Forms.PictureBox();
            this.player2Picture = new System.Windows.Forms.PictureBox();
            this.resultMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // player1ResultText
            // 
            this.player1ResultText.AutoSize = true;
            this.player1ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ResultText.Location = new System.Drawing.Point(138, 382);
            this.player1ResultText.Name = "player1ResultText";
            this.player1ResultText.Size = new System.Drawing.Size(93, 55);
            this.player1ResultText.TabIndex = 0;
            this.player1ResultText.Text = "KŐ";
            // 
            // player2ResultText
            // 
            this.player2ResultText.AutoSize = true;
            this.player2ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ResultText.Location = new System.Drawing.Point(1108, 382);
            this.player2ResultText.Name = "player2ResultText";
            this.player2ResultText.Size = new System.Drawing.Size(93, 55);
            this.player2ResultText.TabIndex = 1;
            this.player2ResultText.Text = "KŐ";
            // 
            // continueGameButton
            // 
            this.continueGameButton.Location = new System.Drawing.Point(593, 214);
            this.continueGameButton.Name = "continueGameButton";
            this.continueGameButton.Size = new System.Drawing.Size(223, 103);
            this.continueGameButton.TabIndex = 2;
            this.continueGameButton.Text = "Játék folytatása";
            this.continueGameButton.UseVisualStyleBackColor = true;
            this.continueGameButton.Click += new System.EventHandler(this.continueGameButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // finishGameButton
            // 
            this.finishGameButton.Location = new System.Drawing.Point(593, 214);
            this.finishGameButton.Name = "finishGameButton";
            this.finishGameButton.Size = new System.Drawing.Size(223, 103);
            this.finishGameButton.TabIndex = 4;
            this.finishGameButton.Text = "Játék befejezése";
            this.finishGameButton.UseVisualStyleBackColor = true;
            this.finishGameButton.Click += new System.EventHandler(this.finishGameButton_Click);
            // 
            // player1Picture
            // 
            this.player1Picture.Image = global::RockPaperScissors.Properties.Resources.paper;
            this.player1Picture.InitialImage = global::RockPaperScissors.Properties.Resources.paper;
            this.player1Picture.Location = new System.Drawing.Point(42, 38);
            this.player1Picture.Name = "player1Picture";
            this.player1Picture.Size = new System.Drawing.Size(300, 300);
            this.player1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Picture.TabIndex = 5;
            this.player1Picture.TabStop = false;
            // 
            // player2Picture
            // 
            this.player2Picture.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.player2Picture.Location = new System.Drawing.Point(1009, 38);
            this.player2Picture.Name = "player2Picture";
            this.player2Picture.Size = new System.Drawing.Size(300, 300);
            this.player2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Picture.TabIndex = 6;
            this.player2Picture.TabStop = false;
            // 
            // resultMessage
            // 
            this.resultMessage.AutoSize = true;
            this.resultMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMessage.Location = new System.Drawing.Point(46, 510);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(421, 55);
            this.resultMessage.TabIndex = 7;
            this.resultMessage.Text = "Ide jön az üzenet!";
            // 
            // RoundResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.player2Picture);
            this.Controls.Add(this.player1Picture);
            this.Controls.Add(this.finishGameButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.continueGameButton);
            this.Controls.Add(this.player2ResultText);
            this.Controls.Add(this.player1ResultText);
            this.Name = "RoundResultsControl";
            this.Size = new System.Drawing.Size(1387, 736);
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1ResultText;
        private System.Windows.Forms.Label player2ResultText;
        private System.Windows.Forms.Button continueGameButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button finishGameButton;
        private System.Windows.Forms.PictureBox player1Picture;
        private System.Windows.Forms.PictureBox player2Picture;
        private System.Windows.Forms.Label resultMessage;
    }
}
