using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.Attributes;
using SharpShell.SharpDeskBand;

namespace DeskBandWidth
{
    /// <summary>
    /// Project skeleton copied from the sample of SharpShell library by Dave Kerr
    /// </summary>
    [ComVisible(true)]
    [DisplayName("DeskBandWidth")]
    public class DeskBandWidth : SharpDeskBand
    {
        protected override UserControl CreateDeskBand()
        {
            return new DeskBandWidthUI();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
            {
                HasVariableHeight = false,
                IsSunken = false,
                ShowTitle = true,
                Title = "DeskBandWidth",
                UseBackgroundColour = false,
                AlwaysShowGripper = true
            };
        }
    }
}
