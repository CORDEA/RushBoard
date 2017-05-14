using Corale.Colore.Core;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RushBoard
{
    class Program
    {
        private const int WhKeyboardLl = 13;

        private const int KeyDown = 0x0100;

        private static Controller Controller { get; } = new Controller(Color.Red, Color.Blue);

        private static LowLevelKeyboardProc Proc { get; } = HookCallback;

        private static IntPtr HookId { get; set; } = IntPtr.Zero;

        static void Main(string[] args)
        {
            HookId = SetHook(Proc);

            Application.Run();

            UnhookWindowsHookEx(HookId);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process process = Process.GetCurrentProcess())
            using (ProcessModule module = process.MainModule)
            {
                return SetWindowsHookEx(WhKeyboardLl, proc, GetModuleHandle(module.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)KeyDown)
            {
                var code = Marshal.ReadInt32(lParam);
                new Task(async () =>
                {
                    await Controller.RequestAnimation(new KeyInfo((Keys)code));
                }).RunSynchronously();
            }
            return CallNextHookEx(HookId, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}

