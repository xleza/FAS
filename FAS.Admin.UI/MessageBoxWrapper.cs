using System.Windows.Forms;

namespace FAS.Admin.UI
{
    public static class MessageBoxWrapper
    {
        public static void Info(string message) => MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static void Error(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public static DialogResult Confirmation(string message) => MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
}
