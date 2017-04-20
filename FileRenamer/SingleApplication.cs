using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Utilities
{
	public class SingleApplication
	{
        // from:
        // http://www.codeproject.com/KB/cs/singleinstance.aspx

        #region DLL Imports

            [DllImport("user32.dll")]
            private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

            [DllImport("user32.dll")]
            private static extern int SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            private static extern int IsIconic(IntPtr hWnd); 

        #endregion

        #region Fields

            private static Mutex _Mutex;
            private const int SW_RESTORE = 9; 

        #endregion

        #region Methods

            public SingleApplication() { }

            private static IntPtr GetCurrentInstanceWindowHandle()
            {
                IntPtr hWnd = IntPtr.Zero;
                Process current_process = Process.GetCurrentProcess();
                Process[] process_list = Process.GetProcessesByName(current_process.ProcessName);

                foreach (Process active_process in process_list)
                {
                    // Get the first instance that is not this instance, has the
                    // same process name and was started from the same file name
                    // and location. Also check that the process has a valid
                    // window handle in this session to filter out other user's
                    // processes.
                    if (active_process.Id != current_process.Id &&
                        active_process.MainModule.FileName == current_process.MainModule.FileName &&
                        active_process.MainWindowHandle != IntPtr.Zero)
                    {
                        hWnd = active_process.MainWindowHandle;
                        break;
                    }
                }
                return hWnd;
            }
            private static void CloseAllExistingProcessInstances()
            {
                IntPtr hWnd = IntPtr.Zero;
                Process current_process = Process.GetCurrentProcess();
                Process[] process_list = Process.GetProcessesByName(current_process.ProcessName);

                foreach (Process active_process in process_list)
                {
                    if (active_process.Id != current_process.Id &&
                        active_process.MainModule.FileName == current_process.MainModule.FileName &&
                        active_process.MainWindowHandle != IntPtr.Zero)
                    {
                        active_process.CloseMainWindow();
                    }
                }
            }

            /// <summary>
            /// SwitchToCurrentInstance
            /// </summary>
            private static void SwitchToCurrentInstance()
            {
                IntPtr hWnd = GetCurrentInstanceWindowHandle();

                if (hWnd != IntPtr.Zero)
                {
                    // Restore window if minimised. Do not restore if already in
                    // normal or maximised window state, since we don't want to
                    // change the current state of the window.
                    if (IsIconic(hWnd) != 0)
                    {
                        ShowWindow(hWnd, SW_RESTORE);
                    }

                    // Set foreground window.
                    SetForegroundWindow(hWnd);
                }
            }

            /// <summary>
            /// Execute a form base application if another instance already running on the system activate previous one
            /// </summary>
            /// <param name="frmMain">main form</param>
            /// <param name="keep_existing">Only one isntance is allowed to run. keep_existing 
            /// == true will switch to the existing process, keep_existing == false will end
            /// all prior processes.</param>
            /// <returns>true if no previous instance is running</returns>
            public static bool Run(Form frmMain, bool keep_existing)
            {
                if (IsAlreadyRunning())
                {
                    if (keep_existing)
                    {
                        //set focus to previously running app
                        SwitchToCurrentInstance();
                        return false;
                    }
                    else
                    {
                        CloseAllExistingProcessInstances();
                    }
                }

                Application.Run(frmMain);
                return true;
            }
            /// <summary>
            /// for console base application
            /// </summary>
            /// <returns></returns>
            public static bool Run()
            {
                if (IsAlreadyRunning())
                {
                    return false;
                }

                return true;
            }

            /// <summary>
            /// check if given exe alread running or not
            /// </summary>
            /// <returns>returns true if already running</returns>
            private static bool IsAlreadyRunning()
            {
                string assembly_location = Assembly.GetExecutingAssembly().Location;
                FileSystemInfo file_info = new FileInfo(assembly_location);
                string exe_name = file_info.Name;
                bool create_new;

                _Mutex = new Mutex(true, "Global\\" + exe_name, out create_new);

                if (create_new)
                    _Mutex.ReleaseMutex();

                return !create_new;
            } 

        #endregion
		

	}
}
