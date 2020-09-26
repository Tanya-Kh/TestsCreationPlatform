using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreationPlatform.BLL.Models;

namespace TestCreationPlatform.BLL
{
    public static class Helpers
    {
        public static void ClearTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
            }
        }

        public static void ClearComboBoxes(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
            }
        }

        public static List<AnswerModel> Shuffle(List<AnswerModel> list)
        {
            Random rng = new Random();

            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                AnswerModel value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

        public static double GetPercent(double correct, double incorrect)
        {
            return correct / (correct + incorrect) * 100;
        }
    }
}
