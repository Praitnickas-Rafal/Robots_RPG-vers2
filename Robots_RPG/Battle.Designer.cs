namespace Robots_RPG
{
    partial class Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            this.LeftRobotPicterBox = new System.Windows.Forms.PictureBox();
            this.HpUsera = new System.Windows.Forms.Label();
            this.HpRobotaCumputer = new System.Windows.Forms.Label();
            this.CommentBattleTextBox = new System.Windows.Forms.TextBox();
            this.BattleExitButton = new System.Windows.Forms.Button();
            this.RightRobotPictureBox = new System.Windows.Forms.PictureBox();
            this.OptionBattleGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UDefArenaComboBox = new System.Windows.Forms.ComboBox();
            this.UAttackArenaComboBox = new System.Windows.Forms.ComboBox();
            this.USpeedBattleLabel = new System.Windows.Forms.Label();
            this.UDamageBattleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRobotPicterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRobotPictureBox)).BeginInit();
            this.OptionBattleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftRobotPicterBox
            // 
            this.LeftRobotPicterBox.BackColor = System.Drawing.Color.Transparent;
            this.LeftRobotPicterBox.Location = new System.Drawing.Point(124, 301);
            this.LeftRobotPicterBox.Name = "LeftRobotPicterBox";
            this.LeftRobotPicterBox.Size = new System.Drawing.Size(373, 643);
            this.LeftRobotPicterBox.TabIndex = 0;
            this.LeftRobotPicterBox.TabStop = false;
            // 
            // HpUsera
            // 
            this.HpUsera.AutoSize = true;
            this.HpUsera.BackColor = System.Drawing.Color.Transparent;
            this.HpUsera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpUsera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HpUsera.Location = new System.Drawing.Point(119, 960);
            this.HpUsera.Name = "HpUsera";
            this.HpUsera.Size = new System.Drawing.Size(50, 25);
            this.HpUsera.TabIndex = 2;
            this.HpUsera.Text = "HP:";
            // 
            // HpRobotaCumputer
            // 
            this.HpRobotaCumputer.AutoSize = true;
            this.HpRobotaCumputer.BackColor = System.Drawing.Color.Transparent;
            this.HpRobotaCumputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpRobotaCumputer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HpRobotaCumputer.Location = new System.Drawing.Point(1423, 960);
            this.HpRobotaCumputer.Name = "HpRobotaCumputer";
            this.HpRobotaCumputer.Size = new System.Drawing.Size(50, 25);
            this.HpRobotaCumputer.TabIndex = 4;
            this.HpRobotaCumputer.Text = "HP:";
            // 
            // CommentBattleTextBox
            // 
            this.CommentBattleTextBox.Location = new System.Drawing.Point(749, 879);
            this.CommentBattleTextBox.Multiline = true;
            this.CommentBattleTextBox.Name = "CommentBattleTextBox";
            this.CommentBattleTextBox.Size = new System.Drawing.Size(438, 140);
            this.CommentBattleTextBox.TabIndex = 6;
            // 
            // BattleExitButton
            // 
            this.BattleExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleExitButton.Location = new System.Drawing.Point(12, 12);
            this.BattleExitButton.Name = "BattleExitButton";
            this.BattleExitButton.Size = new System.Drawing.Size(187, 58);
            this.BattleExitButton.TabIndex = 10;
            this.BattleExitButton.Text = "Kapitulacja";
            this.BattleExitButton.UseVisualStyleBackColor = true;
            this.BattleExitButton.Click += new System.EventHandler(this.BattleExitButton_Click);
            // 
            // RightRobotPictureBox
            // 
            this.RightRobotPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RightRobotPictureBox.Location = new System.Drawing.Point(1428, 301);
            this.RightRobotPictureBox.Name = "RightRobotPictureBox";
            this.RightRobotPictureBox.Size = new System.Drawing.Size(373, 643);
            this.RightRobotPictureBox.TabIndex = 11;
            this.RightRobotPictureBox.TabStop = false;
            // 
            // OptionBattleGroupBox
            // 
            this.OptionBattleGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionBattleGroupBox.Controls.Add(this.label2);
            this.OptionBattleGroupBox.Controls.Add(this.label1);
            this.OptionBattleGroupBox.Controls.Add(this.UDefArenaComboBox);
            this.OptionBattleGroupBox.Controls.Add(this.UAttackArenaComboBox);
            this.OptionBattleGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionBattleGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OptionBattleGroupBox.Location = new System.Drawing.Point(85, 180);
            this.OptionBattleGroupBox.Name = "OptionBattleGroupBox";
            this.OptionBattleGroupBox.Size = new System.Drawing.Size(459, 115);
            this.OptionBattleGroupBox.TabIndex = 12;
            this.OptionBattleGroupBox.TabStop = false;
            this.OptionBattleGroupBox.Text = "Wybierz działania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ataka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obrona:";
            // 
            // UDefArenaComboBox
            // 
            this.UDefArenaComboBox.FormattingEnabled = true;
            this.UDefArenaComboBox.Location = new System.Drawing.Point(245, 72);
            this.UDefArenaComboBox.Name = "UDefArenaComboBox";
            this.UDefArenaComboBox.Size = new System.Drawing.Size(176, 33);
            this.UDefArenaComboBox.TabIndex = 1;
            // 
            // UAttackArenaComboBox
            // 
            this.UAttackArenaComboBox.FormattingEnabled = true;
            this.UAttackArenaComboBox.Location = new System.Drawing.Point(38, 72);
            this.UAttackArenaComboBox.Name = "UAttackArenaComboBox";
            this.UAttackArenaComboBox.Size = new System.Drawing.Size(176, 33);
            this.UAttackArenaComboBox.TabIndex = 0;
            this.UAttackArenaComboBox.SelectedIndexChanged += new System.EventHandler(this.UAttackArenaComboBox_SelectedIndexChanged);
            // 
            // USpeedBattleLabel
            // 
            this.USpeedBattleLabel.AutoSize = true;
            this.USpeedBattleLabel.BackColor = System.Drawing.Color.Transparent;
            this.USpeedBattleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USpeedBattleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.USpeedBattleLabel.Location = new System.Drawing.Point(325, 960);
            this.USpeedBattleLabel.Name = "USpeedBattleLabel";
            this.USpeedBattleLabel.Size = new System.Drawing.Size(50, 25);
            this.USpeedBattleLabel.TabIndex = 15;
            this.USpeedBattleLabel.Text = "HP:";
            // 
            // UDamageBattleLabel
            // 
            this.UDamageBattleLabel.AutoSize = true;
            this.UDamageBattleLabel.BackColor = System.Drawing.Color.Transparent;
            this.UDamageBattleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDamageBattleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UDamageBattleLabel.Location = new System.Drawing.Point(119, 994);
            this.UDamageBattleLabel.Name = "UDamageBattleLabel";
            this.UDamageBattleLabel.Size = new System.Drawing.Size(50, 25);
            this.UDamageBattleLabel.TabIndex = 16;
            this.UDamageBattleLabel.Text = "HP:";
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.UDamageBattleLabel);
            this.Controls.Add(this.USpeedBattleLabel);
            this.Controls.Add(this.OptionBattleGroupBox);
            this.Controls.Add(this.RightRobotPictureBox);
            this.Controls.Add(this.BattleExitButton);
            this.Controls.Add(this.CommentBattleTextBox);
            this.Controls.Add(this.HpRobotaCumputer);
            this.Controls.Add(this.HpUsera);
            this.Controls.Add(this.LeftRobotPicterBox);
            this.Name = "Battle";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftRobotPicterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRobotPictureBox)).EndInit();
            this.OptionBattleGroupBox.ResumeLayout(false);
            this.OptionBattleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftRobotPicterBox;
        private System.Windows.Forms.Label HpUsera;
        private System.Windows.Forms.Label HpRobotaCumputer;
        private System.Windows.Forms.TextBox CommentBattleTextBox;
        private System.Windows.Forms.Button BattleExitButton;
        private System.Windows.Forms.PictureBox RightRobotPictureBox;
        private System.Windows.Forms.GroupBox OptionBattleGroupBox;
        private System.Windows.Forms.ComboBox UDefArenaComboBox;
        private System.Windows.Forms.ComboBox UAttackArenaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USpeedBattleLabel;
        private System.Windows.Forms.Label UDamageBattleLabel;
    }
}