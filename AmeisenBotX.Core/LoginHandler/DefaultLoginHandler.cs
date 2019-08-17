﻿using AmeisenBotX.Core.OffsetLists;
using AmeisenBotX.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmeisenBotX.Core.LoginHandler
{
    public class DefaultLoginHandler : ILoginHandler
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private XMemory XMemory { get; }
        private IOffsetList OffsetList { get; }

        public DefaultLoginHandler(XMemory xMemory, IOffsetList offsetList)
        {
            XMemory = xMemory;
            OffsetList = offsetList;
        }

        public bool Login(Process wowProcess, string username, string password, int characterSlot)
        {
            int count = 0;

            if (XMemory.ReadInt(OffsetList.IsWorldLoaded, out int isWorldLoaded))
            {
                while (!XMemory.Process.HasExited && isWorldLoaded == 0)
                {
                    if (count == 7)
                        return false;

                    if (XMemory.ReadString(OffsetList.GameState, Encoding.ASCII, out string gameState, 10))
                    {
                        switch (gameState)
                        {
                            case "login":
                                HandleLogin(username, password);
                                count++;
                                break;

                            case "charselect":
                                HandleCharSelect(characterSlot);
                                break;

                            default:
                                count++;
                                break;
                        }
                    }
                    else
                        count++;

                    XMemory.ReadInt(OffsetList.IsWorldLoaded, out isWorldLoaded);
                    Thread.Sleep(2000);
                }

                return true;
            }

            return false;
        }

        private void HandleLogin(string username, string password)
        {
            foreach (char c in username)
            {
                SendKeyToProcess(c, char.IsUpper(c));
                Thread.Sleep(10);
            }

            Thread.Sleep(100);
            SendKeyToProcess(0x09);
            Thread.Sleep(100);

            bool firstTime = true;
            string gameState;
            bool result;

            do
            {
                if (!firstTime)
                {
                    SendKeyToProcess(0x0D);
                }

                foreach (char c in password)
                {
                    SendKeyToProcess(c, char.IsUpper(c));
                    Thread.Sleep(10);
                }

                Thread.Sleep(500);
                SendKeyToProcess(0x0D);
                Thread.Sleep(3000);

                firstTime = false;

                result = XMemory.ReadString(OffsetList.GameState, Encoding.ASCII, out gameState, 10);
            } while (result && gameState == "login");
            SendKeyToProcess(0x0D);
        }

        private void HandleCharSelect(int characterSlot)
        {
            if (XMemory.ReadInt(OffsetList.CharacterSlotSelected, out int currentSlot))
            {
                bool failed = false;
                while (!failed && currentSlot != characterSlot)
                {
                    SendKeyToProcess(0x28);
                    Thread.Sleep(200);
                    failed = XMemory.ReadInt(OffsetList.CharacterSlotSelected, out currentSlot);
                }

                SendKeyToProcess(0x0D);
            }
        }

        private void SendKeyToProcess(int c)
        {
            IntPtr windowHandle = XMemory.Process.MainWindowHandle;

            SendMessage(windowHandle, 0x0100, new IntPtr(c), new IntPtr(0));
            Thread.Sleep(new Random().Next(20, 40));
            SendMessage(windowHandle, 0x0101, new IntPtr(c), new IntPtr(0));
        }

        private void SendKeyToProcess(int c, bool shift)
        {
            IntPtr windowHandle = XMemory.Process.MainWindowHandle;

            if (shift)
            {
                PostMessage(windowHandle, 0x0100, new IntPtr(0x10), new IntPtr(0));
            }

            PostMessage(windowHandle, 0x0102, new IntPtr(c), new IntPtr(0));

            if (shift)
            {
                PostMessage(windowHandle, 0x0101, new IntPtr(0x10), new IntPtr(0));
            }
        }
    }
}
