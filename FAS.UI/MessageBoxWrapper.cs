using System.Windows.Forms;

namespace FAS.UI
{
    public static class MessageBoxWrapper
    {
        public static void Info(string message) => MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static void Error(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
