using System.Windows.Forms;

namespace PMS.Models
{
    public class WindowController
    {
        private readonly Form _form;

        public WindowController(Form form)
        {
            _form = form;
        }

        // Close application window
        public void Close()
        {
            _form.Close();
        }

        // Back (same as close when previous form was hidden)
        public void Back()
        {
            _form.Close();
        }

        // Minimize window
        public void Minimize()
        {
            _form.WindowState = FormWindowState.Minimized;
        }

        // Maximize window
        public void Maximize()
        {
            _form.WindowState = FormWindowState.Maximized;
        }

        // Restore window
        public void Restore()
        {
            _form.WindowState = FormWindowState.Normal;
        }

        // Toggle maximize / restore
        public void ToggleMaximize()
        {
            _form.WindowState =
                _form.WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }
    }
}
