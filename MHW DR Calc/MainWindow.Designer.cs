
namespace MHW_DR_Calc
{
    partial class MainWindow
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
            this.Defense = new System.Windows.Forms.TextBox();
            this.Fire = new System.Windows.Forms.TextBox();
            this.Water = new System.Windows.Forms.TextBox();
            this.Thunder = new System.Windows.Forms.TextBox();
            this.Ice = new System.Windows.Forms.TextBox();
            this.Dragon = new System.Windows.Forms.TextBox();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelFire = new System.Windows.Forms.Label();
            this.labeWater = new System.Windows.Forms.Label();
            this.labelThunder = new System.Windows.Forms.Label();
            this.labelIce = new System.Windows.Forms.Label();
            this.labelDragon = new System.Windows.Forms.Label();
            this.labelEqual = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.IsRanged = new System.Windows.Forms.RadioButton();
            this.IsMelee = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.WaterPercentage = new System.Windows.Forms.TextBox();
            this.ThunderPercentage = new System.Windows.Forms.TextBox();
            this.IcePercentage = new System.Windows.Forms.TextBox();
            this.DragonPercentage = new System.Windows.Forms.TextBox();
            this.FirePercentage = new System.Windows.Forms.TextBox();
            this.DefPercentage = new System.Windows.Forms.TextBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.TextBox();
            this.DefEffectiveHP = new System.Windows.Forms.TextBox();
            this.FireEffectiveHP = new System.Windows.Forms.TextBox();
            this.WaterEffectiveHP = new System.Windows.Forms.TextBox();
            this.ThunderEffectiveHP = new System.Windows.Forms.TextBox();
            this.IceEffectiveHP = new System.Windows.Forms.TextBox();
            this.DragonEffectiveHP = new System.Windows.Forms.TextBox();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelEffectiveHP = new System.Windows.Forms.Label();
            this.labelRaw = new System.Windows.Forms.Label();
            this.labelFire2 = new System.Windows.Forms.Label();
            this.labelWater2 = new System.Windows.Forms.Label();
            this.labelThunder2 = new System.Windows.Forms.Label();
            this.labelIce2 = new System.Windows.Forms.Label();
            this.labelDragon2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Defense
            // 
            this.Defense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Defense.Location = new System.Drawing.Point(63, 29);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(100, 23);
            this.Defense.TabIndex = 0;
            // 
            // Fire
            // 
            this.Fire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fire.Location = new System.Drawing.Point(63, 58);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(100, 23);
            this.Fire.TabIndex = 1;
            // 
            // Water
            // 
            this.Water.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Water.Location = new System.Drawing.Point(63, 87);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(100, 23);
            this.Water.TabIndex = 2;
            // 
            // Thunder
            // 
            this.Thunder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thunder.Location = new System.Drawing.Point(63, 116);
            this.Thunder.Name = "Thunder";
            this.Thunder.Size = new System.Drawing.Size(100, 23);
            this.Thunder.TabIndex = 3;
            // 
            // Ice
            // 
            this.Ice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ice.Location = new System.Drawing.Point(63, 145);
            this.Ice.Name = "Ice";
            this.Ice.Size = new System.Drawing.Size(100, 23);
            this.Ice.TabIndex = 4;
            // 
            // Dragon
            // 
            this.Dragon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dragon.Location = new System.Drawing.Point(63, 174);
            this.Dragon.Name = "Dragon";
            this.Dragon.Size = new System.Drawing.Size(100, 23);
            this.Dragon.TabIndex = 5;
            // 
            // labelDef
            // 
            this.labelDef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(7, 32);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(50, 15);
            this.labelDef.TabIndex = 6;
            this.labelDef.Text = "Defence";
            // 
            // labelFire
            // 
            this.labelFire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFire.AutoSize = true;
            this.labelFire.Location = new System.Drawing.Point(31, 61);
            this.labelFire.Name = "labelFire";
            this.labelFire.Size = new System.Drawing.Size(26, 15);
            this.labelFire.TabIndex = 7;
            this.labelFire.Text = "Fire";
            // 
            // labeWater
            // 
            this.labeWater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeWater.AutoSize = true;
            this.labeWater.Location = new System.Drawing.Point(19, 90);
            this.labeWater.Name = "labeWater";
            this.labeWater.Size = new System.Drawing.Size(38, 15);
            this.labeWater.TabIndex = 8;
            this.labeWater.Text = "Water";
            // 
            // labelThunder
            // 
            this.labelThunder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThunder.AutoSize = true;
            this.labelThunder.Location = new System.Drawing.Point(6, 119);
            this.labelThunder.Name = "labelThunder";
            this.labelThunder.Size = new System.Drawing.Size(51, 15);
            this.labelThunder.TabIndex = 9;
            this.labelThunder.Text = "Thunder";
            // 
            // labelIce
            // 
            this.labelIce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIce.AutoSize = true;
            this.labelIce.Location = new System.Drawing.Point(35, 148);
            this.labelIce.Name = "labelIce";
            this.labelIce.Size = new System.Drawing.Size(22, 15);
            this.labelIce.TabIndex = 10;
            this.labelIce.Text = "Ice";
            // 
            // labelDragon
            // 
            this.labelDragon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDragon.AutoSize = true;
            this.labelDragon.Location = new System.Drawing.Point(11, 177);
            this.labelDragon.Name = "labelDragon";
            this.labelDragon.Size = new System.Drawing.Size(46, 15);
            this.labelDragon.TabIndex = 11;
            this.labelDragon.Text = "Dragon";
            // 
            // labelEqual
            // 
            this.labelEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEqual.AutoSize = true;
            this.labelEqual.Location = new System.Drawing.Point(169, 105);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(15, 15);
            this.labelEqual.TabIndex = 0;
            this.labelEqual.Text = "=";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalc.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalc.Location = new System.Drawing.Point(190, 203);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(206, 48);
            this.buttonCalc.TabIndex = 15;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // IsRanged
            // 
            this.IsRanged.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsRanged.AutoSize = true;
            this.IsRanged.Location = new System.Drawing.Point(89, 203);
            this.IsRanged.Name = "IsRanged";
            this.IsRanged.Size = new System.Drawing.Size(65, 19);
            this.IsRanged.TabIndex = 13;
            this.IsRanged.Text = "Ranged";
            this.IsRanged.UseVisualStyleBackColor = true;
            this.IsRanged.CheckedChanged += new System.EventHandler(this.IsRanged_CheckedChanged);
            // 
            // IsMelee
            // 
            this.IsMelee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsMelee.AutoSize = true;
            this.IsMelee.Location = new System.Drawing.Point(26, 203);
            this.IsMelee.Name = "IsMelee";
            this.IsMelee.Size = new System.Drawing.Size(57, 19);
            this.IsMelee.TabIndex = 12;
            this.IsMelee.TabStop = true;
            this.IsMelee.Text = "Melee";
            this.IsMelee.UseVisualStyleBackColor = true;
            this.IsMelee.CheckedChanged += new System.EventHandler(this.IsMelee_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(177, 15);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Input the values shown in-game";
            // 
            // WaterPercentage
            // 
            this.WaterPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WaterPercentage.Location = new System.Drawing.Point(190, 87);
            this.WaterPercentage.Name = "WaterPercentage";
            this.WaterPercentage.ReadOnly = true;
            this.WaterPercentage.Size = new System.Drawing.Size(100, 23);
            this.WaterPercentage.TabIndex = 20;
            // 
            // ThunderPercentage
            // 
            this.ThunderPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThunderPercentage.Location = new System.Drawing.Point(190, 116);
            this.ThunderPercentage.Name = "ThunderPercentage";
            this.ThunderPercentage.ReadOnly = true;
            this.ThunderPercentage.Size = new System.Drawing.Size(100, 23);
            this.ThunderPercentage.TabIndex = 21;
            // 
            // IcePercentage
            // 
            this.IcePercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IcePercentage.Location = new System.Drawing.Point(190, 145);
            this.IcePercentage.Name = "IcePercentage";
            this.IcePercentage.ReadOnly = true;
            this.IcePercentage.Size = new System.Drawing.Size(100, 23);
            this.IcePercentage.TabIndex = 22;
            // 
            // DragonPercentage
            // 
            this.DragonPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DragonPercentage.Location = new System.Drawing.Point(190, 174);
            this.DragonPercentage.Name = "DragonPercentage";
            this.DragonPercentage.ReadOnly = true;
            this.DragonPercentage.Size = new System.Drawing.Size(100, 23);
            this.DragonPercentage.TabIndex = 23;
            // 
            // FirePercentage
            // 
            this.FirePercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirePercentage.Location = new System.Drawing.Point(190, 58);
            this.FirePercentage.Name = "FirePercentage";
            this.FirePercentage.ReadOnly = true;
            this.FirePercentage.Size = new System.Drawing.Size(100, 23);
            this.FirePercentage.TabIndex = 19;
            // 
            // DefPercentage
            // 
            this.DefPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DefPercentage.Location = new System.Drawing.Point(190, 29);
            this.DefPercentage.Name = "DefPercentage";
            this.DefPercentage.ReadOnly = true;
            this.DefPercentage.Size = new System.Drawing.Size(100, 23);
            this.DefPercentage.TabIndex = 18;
            // 
            // labelHP
            // 
            this.labelHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(6, 231);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(51, 15);
            this.labelHP.TabIndex = 25;
            this.labelHP.Text = "Total HP";
            // 
            // Health
            // 
            this.Health.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Health.Location = new System.Drawing.Point(63, 228);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(100, 23);
            this.Health.TabIndex = 14;
            // 
            // DefEffectiveHP
            // 
            this.DefEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DefEffectiveHP.Location = new System.Drawing.Point(296, 29);
            this.DefEffectiveHP.Name = "DefEffectiveHP";
            this.DefEffectiveHP.ReadOnly = true;
            this.DefEffectiveHP.Size = new System.Drawing.Size(100, 23);
            this.DefEffectiveHP.TabIndex = 26;
            // 
            // FireEffectiveHP
            // 
            this.FireEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FireEffectiveHP.Location = new System.Drawing.Point(296, 58);
            this.FireEffectiveHP.Name = "FireEffectiveHP";
            this.FireEffectiveHP.ReadOnly = true;
            this.FireEffectiveHP.Size = new System.Drawing.Size(100, 23);
            this.FireEffectiveHP.TabIndex = 27;
            // 
            // WaterEffectiveHP
            // 
            this.WaterEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WaterEffectiveHP.Location = new System.Drawing.Point(296, 87);
            this.WaterEffectiveHP.Name = "WaterEffectiveHP";
            this.WaterEffectiveHP.ReadOnly = true;
            this.WaterEffectiveHP.Size = new System.Drawing.Size(100, 23);
            this.WaterEffectiveHP.TabIndex = 28;
            // 
            // ThunderEffectiveHP
            // 
            this.ThunderEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThunderEffectiveHP.Location = new System.Drawing.Point(296, 116);
            this.ThunderEffectiveHP.Name = "ThunderEffectiveHP";
            this.ThunderEffectiveHP.ReadOnly = true;
            this.ThunderEffectiveHP.Size = new System.Drawing.Size(100, 23);
            this.ThunderEffectiveHP.TabIndex = 29;
            // 
            // IceEffectiveHP
            // 
            this.IceEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IceEffectiveHP.Location = new System.Drawing.Point(296, 145);
            this.IceEffectiveHP.Name = "IceEffectiveHP";
            this.IceEffectiveHP.ReadOnly = true;
            this.IceEffectiveHP.Size = new System.Drawing.Size(100, 23);
            this.IceEffectiveHP.TabIndex = 30;
            // 
            // DragonEffectiveHP
            // 
            this.DragonEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DragonEffectiveHP.Location = new System.Drawing.Point(296, 174);
            this.DragonEffectiveHP.Name = "DragonEffectiveHP";
            this.DragonEffectiveHP.ReadOnly = true;
            this.DragonEffectiveHP.Size = new System.Drawing.Size(100, 23);
            this.DragonEffectiveHP.TabIndex = 31;
            // 
            // labelPercent
            // 
            this.labelPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(206, 9);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(66, 15);
            this.labelPercent.TabIndex = 32;
            this.labelPercent.Text = "Percentage";
            // 
            // labelEffectiveHP
            // 
            this.labelEffectiveHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEffectiveHP.AutoSize = true;
            this.labelEffectiveHP.Location = new System.Drawing.Point(311, 9);
            this.labelEffectiveHP.Name = "labelEffectiveHP";
            this.labelEffectiveHP.Size = new System.Drawing.Size(71, 15);
            this.labelEffectiveHP.TabIndex = 33;
            this.labelEffectiveHP.Text = "Effective HP";
            // 
            // labelRaw
            // 
            this.labelRaw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRaw.AutoSize = true;
            this.labelRaw.Location = new System.Drawing.Point(402, 32);
            this.labelRaw.Name = "labelRaw";
            this.labelRaw.Size = new System.Drawing.Size(29, 15);
            this.labelRaw.TabIndex = 34;
            this.labelRaw.Text = "Raw";
            // 
            // labelFire2
            // 
            this.labelFire2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFire2.AutoSize = true;
            this.labelFire2.Location = new System.Drawing.Point(402, 61);
            this.labelFire2.Name = "labelFire2";
            this.labelFire2.Size = new System.Drawing.Size(26, 15);
            this.labelFire2.TabIndex = 35;
            this.labelFire2.Text = "Fire";
            // 
            // labelWater2
            // 
            this.labelWater2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWater2.AutoSize = true;
            this.labelWater2.Location = new System.Drawing.Point(402, 90);
            this.labelWater2.Name = "labelWater2";
            this.labelWater2.Size = new System.Drawing.Size(38, 15);
            this.labelWater2.TabIndex = 36;
            this.labelWater2.Text = "Water";
            // 
            // labelThunder2
            // 
            this.labelThunder2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThunder2.AutoSize = true;
            this.labelThunder2.Location = new System.Drawing.Point(402, 119);
            this.labelThunder2.Name = "labelThunder2";
            this.labelThunder2.Size = new System.Drawing.Size(51, 15);
            this.labelThunder2.TabIndex = 37;
            this.labelThunder2.Text = "Thunder";
            // 
            // labelIce2
            // 
            this.labelIce2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIce2.AutoSize = true;
            this.labelIce2.Location = new System.Drawing.Point(402, 148);
            this.labelIce2.Name = "labelIce2";
            this.labelIce2.Size = new System.Drawing.Size(22, 15);
            this.labelIce2.TabIndex = 38;
            this.labelIce2.Text = "Ice";
            // 
            // labelDragon2
            // 
            this.labelDragon2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDragon2.AutoSize = true;
            this.labelDragon2.Location = new System.Drawing.Point(402, 177);
            this.labelDragon2.Name = "labelDragon2";
            this.labelDragon2.Size = new System.Drawing.Size(46, 15);
            this.labelDragon2.TabIndex = 39;
            this.labelDragon2.Text = "Dragon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 263);
            this.Controls.Add(this.labelDragon2);
            this.Controls.Add(this.labelIce2);
            this.Controls.Add(this.labelThunder2);
            this.Controls.Add(this.labelWater2);
            this.Controls.Add(this.labelFire2);
            this.Controls.Add(this.labelRaw);
            this.Controls.Add(this.labelEffectiveHP);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.DragonEffectiveHP);
            this.Controls.Add(this.IceEffectiveHP);
            this.Controls.Add(this.ThunderEffectiveHP);
            this.Controls.Add(this.WaterEffectiveHP);
            this.Controls.Add(this.FireEffectiveHP);
            this.Controls.Add(this.DefEffectiveHP);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.DefPercentage);
            this.Controls.Add(this.FirePercentage);
            this.Controls.Add(this.DragonPercentage);
            this.Controls.Add(this.IcePercentage);
            this.Controls.Add(this.ThunderPercentage);
            this.Controls.Add(this.WaterPercentage);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.IsMelee);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.IsRanged);
            this.Controls.Add(this.labelEqual);
            this.Controls.Add(this.labelDragon);
            this.Controls.Add(this.labelIce);
            this.Controls.Add(this.labelThunder);
            this.Controls.Add(this.labeWater);
            this.Controls.Add(this.labelFire);
            this.Controls.Add(this.labelDef);
            this.Controls.Add(this.Dragon);
            this.Controls.Add(this.Ice);
            this.Controls.Add(this.Thunder);
            this.Controls.Add(this.Water);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Defense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DR Calculator - MHW:I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Defense;
        private System.Windows.Forms.TextBox Fire;
        private System.Windows.Forms.TextBox Water;
        private System.Windows.Forms.TextBox Thunder;
        private System.Windows.Forms.TextBox Ice;
        private System.Windows.Forms.TextBox Dragon;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.Label labelFire;
        private System.Windows.Forms.Label labeWater;
        private System.Windows.Forms.Label labelThunder;
        private System.Windows.Forms.Label labelIce;
        private System.Windows.Forms.Label labelDragon;
        private System.Windows.Forms.Label labelEqual;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.RadioButton IsRanged;
        private System.Windows.Forms.RadioButton IsMelee;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox WaterPercentage;
        private System.Windows.Forms.TextBox ThunderPercentage;
        private System.Windows.Forms.TextBox IcePercentage;
        private System.Windows.Forms.TextBox DragonPercentage;
        private System.Windows.Forms.TextBox FirePercentage;
        private System.Windows.Forms.TextBox DefPercentage;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.TextBox Health;
        private System.Windows.Forms.TextBox DefEffectiveHP;
        private System.Windows.Forms.TextBox FireEffectiveHP;
        private System.Windows.Forms.TextBox WaterEffectiveHP;
        private System.Windows.Forms.TextBox ThunderEffectiveHP;
        private System.Windows.Forms.TextBox IceEffectiveHP;
        private System.Windows.Forms.TextBox DragonEffectiveHP;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label labelEffectiveHP;
        private System.Windows.Forms.Label labelRaw;
        private System.Windows.Forms.Label labelFire2;
        private System.Windows.Forms.Label labelWater2;
        private System.Windows.Forms.Label labelThunder2;
        private System.Windows.Forms.Label labelIce2;
        private System.Windows.Forms.Label labelDragon2;
    }
}

