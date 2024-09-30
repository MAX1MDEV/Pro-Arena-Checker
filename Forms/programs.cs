using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Pro_Arena_Checker_ver._2.Forms
{
    public partial class programs : Form
    {
        public programs()
        {
            InitializeComponent();
            ShellBagCheck.Visible = false;
            EverythingCheck.Visible= false;
            USBDeviewCheck.Visible = false;
            iBeesoftCheck.Visible = false;
            BrowserDownloadsViewCheck.Visible = false;
            ExecutedProgramsListCheck.Visible = false;
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private void btnEverything_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/Everything/Everything.exe");
            EverythingCheck.Visible = true;
            string text = "R3D | Xone | Midnight | MUTINY | Yeahnot | LeagueMode | Unreal | VRedux | FURIOS | otcv | Avira | Neverlose | ESPdX | BoBerHook  | Legendware | EGHack | nixware.cc | HAUNTEDPROJECT| externalcrack | RAGER9 | RAGER8 | .ahk | WinX | PhoenixHack | OBR  | OneByteRadar | Skinchanger | NAIM | EZinjector | Reborn | OneByteWall*Hack | Keter | Annihilation | Sapphire | f0rg0tten  | Osiris | Multihack | Breakthrough | REKTWARE | D3m | ExtrimHack | EZfrags | Shark | RHcheats | FREEQN | Aqua | Boomwtf | Pphud  | INDIGO | FRUX0 | hack | cheat | чит | KlarWare | Aimware | Skeet | gamesense | Aurora | SpirtHack | Fatality | OneTap  | ev0lve | Eternity | Z0rhack | Stickrpg | Demonside.us | Bhop | BunnyHop | AviraSAMOWARE | ExLoader | .amc | R8 | freeqn | imgui.ini";
            Clipboard.SetText(text);
            Thread.Sleep(1000);
            SendKeys.Send("^v");
        }

        private void btnShellBag_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/Shellbag/ShellBag.exe");
            ShellBagCheck.Visible = true;
        }

        private void btnUSBDeview_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/USBDeview/USBDeview.exe");
            USBDeviewCheck.Visible = true;
        }

        private void btniBeesoft_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/iBeesoft/iBeeUI.exe");
            iBeesoftCheck.Visible = true;
        }

        private void btnBrowserDownloadsView_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/BrowserDownloadsView/BrowserDownloadsView.exe");
            BrowserDownloadsViewCheck.Visible = true;
        }

        private void btnExecutedProgramsList_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/ExecutedProgramsList/ExecutedProgramsList.exe");
            ExecutedProgramsListCheck.Visible = true;
        }
    }
}
