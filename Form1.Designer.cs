
namespace SankeAndLaderForm
{
    partial class Form1
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlyerDiceNo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlyerDiceNo2 = new System.Windows.Forms.TextBox();
            this.btn_Roll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(103, 34);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(18, 20);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "0";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(103, 69);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(18, 20);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Dice Number For Player 1";
            // 
            // txtPlyerDiceNo1
            // 
            this.txtPlyerDiceNo1.Location = new System.Drawing.Point(32, 193);
            this.txtPlyerDiceNo1.Name = "txtPlyerDiceNo1";
            this.txtPlyerDiceNo1.Size = new System.Drawing.Size(228, 26);
            this.txtPlyerDiceNo1.TabIndex = 6;
            this.txtPlyerDiceNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlyerDiceNo1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Dice Number For Player 2";
            // 
            // txtPlyerDiceNo2
            // 
            this.txtPlyerDiceNo2.Location = new System.Drawing.Point(300, 193);
            this.txtPlyerDiceNo2.Name = "txtPlyerDiceNo2";
            this.txtPlyerDiceNo2.Size = new System.Drawing.Size(228, 26);
            this.txtPlyerDiceNo2.TabIndex = 8;
            this.txtPlyerDiceNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlyerDiceNo2_KeyPress);
            // 
            // btn_Roll
            // 
            this.btn_Roll.Location = new System.Drawing.Point(200, 270);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(121, 39);
            this.btn_Roll.TabIndex = 9;
            this.btn_Roll.Text = "Roll Dice ";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SankeAndLaderForm.Properties.Resources.spic;
            this.pictureBox1.Location = new System.Drawing.Point(638, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Roll);
            this.Controls.Add(this.txtPlyerDiceNo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlyerDiceNo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlyerDiceNo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlyerDiceNo2;
        private System.Windows.Forms.Button btn_Roll;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

