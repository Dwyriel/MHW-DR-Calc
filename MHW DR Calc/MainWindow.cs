using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHW_DR_Calc
{
    public partial class MainWindow : Form
    {
        const int numOfItens = 6;
        private List<TextBox> textBoxes;
        private List<TextBox> textBoxesPercent;
        private List<TextBox> textBoxesEffective;
        private decimal[] defValues;
        private decimal[] rawDmgTaken;
        private decimal[] finalDefPercentage;
        private decimal[] effectiveHealth;
        private int HP = 200;
        bool isRanged;

        public MainWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
            InitializeListsAndArrays();
            IsMelee.Checked = true;
            Health.Text = HP.ToString();
        }

        private void InitializeListsAndArrays()
        {
            textBoxes = new List<TextBox>
            {
                Defense,
                Fire,
                Water,
                Thunder,
                Ice,
                Dragon
            };
            textBoxesPercent = new List<TextBox>
            {
                DefPercentage,
                FirePercentage,
                WaterPercentage,
                ThunderPercentage,
                IcePercentage,
                DragonPercentage
            };
            textBoxesEffective = new List<TextBox>
            {
                DefEffectiveHP,
                FireEffectiveHP,
                WaterEffectiveHP,
                ThunderEffectiveHP,
                IceEffectiveHP,
                DragonEffectiveHP
            };
            defValues = new decimal[numOfItens];
            rawDmgTaken = new decimal[numOfItens];
            finalDefPercentage = new decimal[numOfItens];
            effectiveHealth = new decimal[numOfItens];
        }

        private void IsMelee_CheckedChanged(object sender, EventArgs e)
        {
            isRanged = !IsMelee.Checked;
        }

        private void IsRanged_CheckedChanged(object sender, EventArgs e)
        {
            isRanged = IsRanged.Checked;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            bool shouldReturn = CheckIfValid();
            if (shouldReturn)
                return;
            AttributeWeaponSpecificValues();
            CalcDamageTaken();//Inverse of Damage Reduction
            CalcAndShowDefensePercentage();
            CalcEffectiveHealth();

        }

        private bool CheckIfValid()
        {
            bool shouldReturn = false;
            for (int i = 0; i < numOfItens; i++)
            {
                bool badInput = !int.TryParse(textBoxes[i].Text, out int parseValue);
                defValues[i] = parseValue;
                if (badInput)
                {
                    MessageBox.Show($"{textBoxes[i].Name} is not a number");
                }
                shouldReturn = badInput || shouldReturn;
            }
            if (shouldReturn = !int.TryParse(Health.Text, out HP))
                MessageBox.Show($"HP is not a number");
            if (!shouldReturn && (HP > 200 || HP < 50))
            {
                MessageBox.Show($"HP must be between 50 and 200");
                shouldReturn = true;
            }
            return shouldReturn;
        }

        private void AttributeWeaponSpecificValues()
        {
            defValues[0] = defValues[0] * (isRanged ? .7m : 1m);
            if (isRanged)
                for (int i = 1; i < numOfItens; i++)
                    defValues[i] = defValues[i] + 5m;
        }

        private void CalcDamageTaken()
        {
            rawDmgTaken[0] = 80m / (80m + defValues[0]);
            for (int i = 1; i < numOfItens; i++)
            {
                rawDmgTaken[i] = (1m - (defValues[i] / 100m)) * rawDmgTaken[0];
            }
            rawDmgTaken[0] = rawDmgTaken[0] * (isRanged ? 1m : .833333333m);
        }

        private void CalcAndShowDefensePercentage()
        {
            for (int i = 0; i < numOfItens; i++)
            {
                finalDefPercentage[i] = (1 - rawDmgTaken[i]) * 100;
                textBoxesPercent[i].Text = string.Format("{0:0.000}", finalDefPercentage[i]) + "%";
            }
        }

        private void CalcEffectiveHealth()
        {
            for (int i = 0; i < numOfItens; i++)
            {
                effectiveHealth[i] = HP / rawDmgTaken[i];
                textBoxesEffective[i].Text = string.Format("{0:0.000}", effectiveHealth[i]);
            }
        }
    }
}
