using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using Threads = System.Threading;
using System.Net.Sockets;
using System.Collections;
using System.Diagnostics;
using System.Windows.Input;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using Huks;
using static Huks.Helper;

namespace Satrek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MainSAT();
        }


        public void InitSAT()
        {
        }

        static int
            tc = 1,
            sc = 1;

        static void nullstats()
        {
            rmc = lmc = tc = 1;
        }

        static CultureInfo ci = CultureInfo.GetCultureInfo("en-US");
        static Process gp;
        static IntPtr module_pointer;
        static Timer
            waitprocess = new Timer { Interval = 1000 },
            uiUpdater = new Timer { Interval = 16 };
        static MouseHook ms_listener;
        static KeyboardHook kb_listener;


        static float nmtd, omtd, totmtd;
        static float topspd, nspd, ospd, spd;
        static int jmp = 0;

        public void MainSAT()
        {

            waitprocess.Tick += delegate
            {
                //var x = Process.GetProcesses();
                var fetch = Process.GetProcessesByName("gta_sa");
                if (fetch.Count() > 0)
                {
                    Threads.Thread.Sleep(1000);
                    nullstats();
                    module_pointer = OpenProcess(PROCESS_WM_READ, false, (gp = fetch.First()).Id);
                    labelJumps.BackColor = labelDist.BackColor = Color.FromArgb(30, 30, 30);
                    totmtd = Properties.Settings.Default.MotoDistance;
                    topspd = Properties.Settings.Default.MotoSpeedBest;
                    labelBestSpeed.Text = $"{labelBestSpeed.Width = (int)topspd:0.0} c.u.";
                    waitprocess.Stop();
                    
                    //gameWindow = (Form)Form.FromHandle(gp.MainWindowHandle);

                }
            };
            labelJumps.BackColor = labelDist.BackColor = Color.FromArgb(80, 30, 30);
            waitprocess.Start();

            uiUpdater.Tick += (s, e) => UpdateSAT();
            uiUpdater.Start();

            kb_listener = new KeyboardHook();
            kb_listener.Install();
            kb_listener.KeyUp += Kb_listener_KeyUp;

        }

        ProcessStartInfo gtaStarter = new ProcessStartInfo(@"C:\Games\Grand Theft Auto San Andreas\gta_sa.exe")
        {
            WindowStyle = ProcessWindowStyle.Normal,
            //RedirectStandardOutput = true,
            //RedirectStandardError = true,
            //UseShellExecute = false,
            //CreateNoWindow = true,
            Verb = "runas",
        };

        void Relaunch()
        {
            if (gp != null)
            {
                gp.Kill();
            }
        }

        private void Kb_listener_KeyUp(KeyboardHook.VKeys key)
        {

            if (k_hooks.Count() == 2 && key == (KeyboardHook.VKeys.R))
            {
                Relaunch();
            }
        }

        IEnumerable<KeyboardHook.VKeys> k_hooks;

        public void UpdateSAT()
        {
            if ((k_hooks = kb_listener.PressedKeys.Where(n => (n == KeyboardHook.VKeys.LCONTROL || n == KeyboardHook.VKeys.LMENU))).Count() == 2)
            {
                //labelCmds.Text = "Waiting for a command...";
                //if (wheel != 0)
                //{

                //    vol += wheel * 5;
                //    vol = vol.Clamp(0, 100);
                //    vlcControl1.Audio.Volume = vol;
                //    labelCmds.Text = $"Volume {vlcControl1.Audio.Volume}";
                //}
            }

            nmtd = memReadFloat(moto_travelled, module_pointer);
            ospd = nspd;
            nspd = spd = memReadFloat(veh_speed, module_pointer) * 80;


            jmp = memReadInt(jumps_found, module_pointer);

            if (omtd > nmtd)
            {
                Properties.Settings.Default.MotoDistance = totmtd;
                Properties.Settings.Default.Save();
                totmtd += omtd;
                nullstats();
            }

            if (spd > topspd)
            {
                topspd = Properties.Settings.Default.MotoSpeedBest = spd;
                Properties.Settings.Default.Save();
                labelBestSpeed.Width = (int)spd;
                labelBestSpeed.Text = $"{spd:0.0} c.u.";
            }

            DrawSAT();
        }



        static int
            moto_travelled = 0x00B7BA14,
            veh_speed = 0x00B717CC,
            jumps_found = 0x0165C28C;

        public void DrawSAT()
        {

            labelLMC.Text = string.Format(ci, "L/SMC: {0}\nL/SMCPS: {1:0.00}", lmc, lmc / (float)tc);
            labelRMC.Text = string.Format(ci, "RMC: {0}\nRMCPS: {1:0.00}", rmc, rmc / (float)tc);

            if (module_pointer != null)
            {
                labelDist.Text = string.Format(ci, "{0:0.0}|{2:000.0}\n{1:0.0}", nmtd, totmtd, spd);
                labelJumps.Text = string.Format(ci, "JMP: {0}/70", jmp);
                labelSpeed.Width = (int)((ospd + nspd) / 2);
                labelSpeed.Text = $"{spd:0.0} c.u.";
                if (gp != null && gp.HasExited && !waitprocess.Enabled)
                {
                    labelJumps.BackColor = labelDist.BackColor = Color.FromArgb(80, 30, 30);
                    waitprocess.Start();
                }
            }

        }

        #region Procs

        static private bool
            rmh, lmh;

        static int
            rmc, lmc;

        private static void Ms_listener_RightButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            rmh = false;
        }

        private static void Ms_listener_LeftButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            lmh = false;
        }

        private static void Ms_listener_RightButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            rmc++;
            rmh = true;
        }

        private static void _listener_LeftButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            lmc++;
            lmh = true;
        }

        private static void Kb_listener_KeyDown(KeyboardHook.VKeys key)
        {
            if (key == KeyboardHook.VKeys.LSHIFT)
                lmc++;
        }

        #endregion

        #region u32

        const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        #endregion

        #region Memread


        public static float memReadFloat(int addr, IntPtr proc)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[4];

            ReadProcessMemory((int)proc, addr, buffer, buffer.Length, ref bytesRead);

            return BitConverter.ToSingle(buffer, 0);
        }

        public static int memReadInt(int addr, IntPtr proc)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[4];

            ReadProcessMemory((int)proc, addr, buffer, buffer.Length, ref bytesRead);

            return BitConverter.ToInt32(buffer, 0);
        }
        #endregion
    }
}
