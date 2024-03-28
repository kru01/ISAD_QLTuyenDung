using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.HoTro
{
    internal class Helper
    {
        public static void Loadform(object Form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }
    }
}
