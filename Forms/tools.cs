using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Arena_Checker_ver._2.Forms
{
    public partial class tools : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("psapi.dll")]
        static extern bool EnumProcessModulesEx(IntPtr hProcess, [Out] IntPtr[] lphModule, int cb, out int lpcbNeeded, uint dwFilterFlag);

        [DllImport("psapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern uint GetModuleFileNameExW(IntPtr hProcess, IntPtr hModule, StringBuilder lpBaseName, int nSize);

        public tools()
        {
            InitializeComponent();
            TopTitle.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 141, 247);
            TopTitle.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 141, 247);
        }
        public class InjectedDll
        {
            public string FileName { get; set; }
            public int ProcessId { get; set; }
        }

        private void tools_Load(object sender, EventArgs e)
        {
            List<InjectedDll> injectedDlls = new List<InjectedDll>();
            Process[] processes = Process.GetProcessesByName("csgo");
            foreach (Process process in processes)
            {
                try
                {
                    IntPtr hProcess = OpenProcess(ProcessAccessFlags.QueryLimitedInformation | ProcessAccessFlags.VirtualMemoryRead, false, process.Id);
                    if (hProcess == IntPtr.Zero)
                    {
                        continue;
                    }

                    IntPtr[] moduleHandles = new IntPtr[1024];
                    int size = Marshal.SizeOf(typeof(IntPtr)) * moduleHandles.Length;
                    int needed;

                    if (!EnumProcessModulesEx(hProcess, moduleHandles, size, out needed, 0x03))
                    {
                        CloseHandle(hProcess);
                        continue;
                    }

                    int count = needed / Marshal.SizeOf(typeof(IntPtr));

                    for (int i = 0; i < count; i++)
                    {
                        StringBuilder modulePath = new StringBuilder(1024);
                        GetModuleFileNameExW(hProcess, moduleHandles[i], modulePath, modulePath.Capacity);

                        InjectedDll injectedDll = new InjectedDll()
                        {
                            FileName = modulePath.ToString(),
                            ProcessId = process.Id
                        };
                        injectedDlls.Add(injectedDll);
                    }

                    CloseHandle(hProcess);
                }
                catch (Exception)
                {
                    
                }
            }
            tablicaProcessId.BackColor = Color.FromArgb(234, 141, 247);
            tablicaProcessId.RowHeadersVisible = false;
            tablicaProcessId.DataSource = injectedDlls;
            tablicaProcessId.Columns[0].HeaderText = "Имя файла";
            tablicaProcessId.Columns[1].HeaderText = "ID процесса";
            tablicaProcessId.Columns[0].Width = 707;
            tablicaProcessId.Columns[1].Width = 173;
        }

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            QueryLimitedInformation = 0x1000,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            VirtualMemoryOperation = 0x00000008,
            CreateThread = 0x0002,
            SetInformation = 0x0020,
            Terminate = 0x0001,
        }
    }
}
