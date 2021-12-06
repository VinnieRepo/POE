
namespace POE_Task_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.MapLabel = new System.Windows.Forms.Label();
            this.MapHolderBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.Weapon1Label = new System.Windows.Forms.Label();
            this.Weapon2Label = new System.Windows.Forms.Label();
            this.WeaponLabel3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buy1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Buy2 = new System.Windows.Forms.Button();
            this.Buy3 = new System.Windows.Forms.Button();
            this.EquippedWeapon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.Location = new System.Drawing.Point(400, 26);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(50, 20);
            this.CharacterLabel.TabIndex = 1;
            this.CharacterLabel.Text = "label2";
            // 
            // EnemyLabel
            // 
            this.EnemyLabel.AutoSize = true;
            this.EnemyLabel.Location = new System.Drawing.Point(400, 249);
            this.EnemyLabel.Name = "EnemyLabel";
            this.EnemyLabel.Size = new System.Drawing.Size(50, 20);
            this.EnemyLabel.TabIndex = 2;
            this.EnemyLabel.Text = "label3";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 460);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(182, 59);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(722, 329);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(94, 29);
            this.UpButton.TabIndex = 8;
            this.UpButton.Text = "Up";
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(619, 365);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(94, 29);
            this.LeftButton.TabIndex = 5;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(819, 365);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(94, 29);
            this.RightButton.TabIndex = 6;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(722, 411);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(94, 29);
            this.DownButton.TabIndex = 7;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.Location = new System.Drawing.Point(12, 41);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(50, 20);
            this.MapLabel.TabIndex = 0;
            this.MapLabel.Text = "label1";
            this.MapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MapHolderBox
            // 
            this.MapHolderBox.Location = new System.Drawing.Point(12, 23);
            this.MapHolderBox.MinimumSize = new System.Drawing.Size(30, 30);
            this.MapHolderBox.Multiline = true;
            this.MapHolderBox.Name = "MapHolderBox";
            this.MapHolderBox.ReadOnly = true;
            this.MapHolderBox.Size = new System.Drawing.Size(382, 371);
            this.MapHolderBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(851, 52);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 61);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(851, 162);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(126, 61);
            this.LoadButton.TabIndex = 12;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Weapon1Label
            // 
            this.Weapon1Label.AutoSize = true;
            this.Weapon1Label.Location = new System.Drawing.Point(499, 499);
            this.Weapon1Label.Name = "Weapon1Label";
            this.Weapon1Label.Size = new System.Drawing.Size(72, 20);
            this.Weapon1Label.TabIndex = 13;
            this.Weapon1Label.Text = "Weapon1";
            // 
            // Weapon2Label
            // 
            this.Weapon2Label.AutoSize = true;
            this.Weapon2Label.Location = new System.Drawing.Point(677, 499);
            this.Weapon2Label.Name = "Weapon2Label";
            this.Weapon2Label.Size = new System.Drawing.Size(72, 20);
            this.Weapon2Label.TabIndex = 14;
            this.Weapon2Label.Text = "Weapon2";
            // 
            // WeaponLabel3
            // 
            this.WeaponLabel3.AutoSize = true;
            this.WeaponLabel3.Location = new System.Drawing.Point(851, 499);
            this.WeaponLabel3.Name = "WeaponLabel3";
            this.WeaponLabel3.Size = new System.Drawing.Size(72, 20);
            this.WeaponLabel3.TabIndex = 15;
            this.WeaponLabel3.Text = "Weapon3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "SHOP";
            // 
            // Buy1
            // 
            this.Buy1.Location = new System.Drawing.Point(521, 560);
            this.Buy1.Name = "Buy1";
            this.Buy1.Size = new System.Drawing.Size(94, 29);
            this.Buy1.TabIndex = 17;
            this.Buy1.Text = "Buy";
            this.Buy1.UseVisualStyleBackColor = true;
            this.Buy1.Click += new System.EventHandler(this.Buy1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Buy2
            // 
            this.Buy2.Location = new System.Drawing.Point(699, 560);
            this.Buy2.Name = "Buy2";
            this.Buy2.Size = new System.Drawing.Size(94, 29);
            this.Buy2.TabIndex = 19;
            this.Buy2.Text = "Buy";
            this.Buy2.UseVisualStyleBackColor = true;
            this.Buy2.Click += new System.EventHandler(this.Buy2_Click);
            // 
            // Buy3
            // 
            this.Buy3.Location = new System.Drawing.Point(861, 560);
            this.Buy3.Name = "Buy3";
            this.Buy3.Size = new System.Drawing.Size(94, 29);
            this.Buy3.TabIndex = 20;
            this.Buy3.Text = "Buy";
            this.Buy3.UseVisualStyleBackColor = true;
            this.Buy3.Click += new System.EventHandler(this.Buy3_Click);
            // 
            // EquippedWeapon
            // 
            this.EquippedWeapon.AutoSize = true;
            this.EquippedWeapon.Location = new System.Drawing.Point(400, 123);
            this.EquippedWeapon.Name = "EquippedWeapon";
            this.EquippedWeapon.Size = new System.Drawing.Size(41, 20);
            this.EquippedWeapon.TabIndex = 21;
            this.EquippedWeapon.Text = " Fists";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 656);
            this.Controls.Add(this.EquippedWeapon);
            this.Controls.Add(this.Buy3);
            this.Controls.Add(this.Buy2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Buy1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeaponLabel3);
            this.Controls.Add(this.Weapon2Label);
            this.Controls.Add(this.Weapon1Label);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MapHolderBox);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.CharacterLabel);
            this.Controls.Add(this.MapLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.TextBox MapHolderBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label Weapon1Label;
        private System.Windows.Forms.Label Weapon2Label;
        private System.Windows.Forms.Label WeaponLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buy1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Buy2;
        private System.Windows.Forms.Button Buy3;
        private System.Windows.Forms.Label EquippedWeapon;
    }
}

