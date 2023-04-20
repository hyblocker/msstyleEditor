using Microsoft.Win32;
using System;
using System.Text;
using System.Windows.Forms;

namespace msstyleEditor
{
    class RegistrySettings
    {
        private readonly string m_EditorKeyPath = @"HKEY_CURRENT_USER\Software\msstyleEditor";

        public RegistrySettings()
        {
        }

        private object RegGetValueSafe(string key, string name, object defaultValue)
        {
            try
            {
                object r = Registry.GetValue(key, name, defaultValue);
                return r == null ? defaultValue : r;
            }
            catch(Exception)
            {
                return defaultValue;
            }
        }

        private void RegSetValueSafe(string key, string name, object value)
        {
            try
            {
                Registry.SetValue(key, name, value);
            }
            catch (Exception)
            { }
        }

        public bool HasConfirmedWarning
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "HasConfirmedWarning", "false");
                if (obj is string s)
                {
                    return s.ToLower() == "true";
                }
                else return false;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "HasConfirmedWarning", "true");
            }
        }

        public int MainWindowPosX
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "MainWindowPosX", int.MinValue);
                if (obj is int n)
                {
                    return n;
                }
                else return int.MinValue;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "MainWindowPosX", value);
            }
        }

        public int MainWindowPosY
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "MainWindowPosY", int.MinValue);
                if (obj is int n)
                {
                    return n;
                }
                else return int.MinValue;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "MainWindowPosY", value);
            }
        }

        public int MainWindowSizeX
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "MainWindowSizeX", int.MinValue);
                if (obj is int n)
                {
                    return n;
                }
                else return int.MinValue;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "MainWindowSizeX", value);
            }
        }

        public int MainWindowSizeY
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "MainWindowSizeY", int.MinValue);
                if (obj is int n)
                {
                    return n;
                }
                else return int.MinValue;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "MainWindowSizeY", value);
            }
        }

        public FormWindowState MainWindowState
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "MainWindowState", (int)FormWindowState.Normal);
                if (obj is int s)
                {
                    return (FormWindowState)s;
                }
                else return FormWindowState.Normal;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "MainWindowState", (int)value);
            }
        }

        public int ImageBackgroundId
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "ImageBackgroundId", 0);
                if (obj is int s)
                {
                    return s;
                }
                else return 0;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "ImageBackgroundId", value);
            }
        }

        public bool HideImageView
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "HideImageView", "false");
                if (obj is string s)
                {
                    return s.ToLower() == "true";
                }
                else return false;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "HideImageView", value);
            }
        }

        public bool HideRenderView
        {
            get
            {
                var obj = RegGetValueSafe(m_EditorKeyPath, "HideRenderView", "true");
                if (obj is string s)
                {
                    return s.ToLower() == "true";
                }
                else return true;
            }
            set
            {
                RegSetValueSafe(m_EditorKeyPath, "HideRenderView", value);
            }
        }
    }
}
