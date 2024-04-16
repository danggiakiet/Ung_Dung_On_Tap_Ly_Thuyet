using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_trắc_nghiệm
{
    public class CreateControls
    {
        public CreateControls() {}
        public Button CreateButton(int x, int y, int width, int height, string name)
        {
            Button btt = new Button();
            btt.Text = name;
            btt.Width = width;
            btt.Height = height;
            btt.Location = new Point(x, y);
            return btt;
        }
    }
}
