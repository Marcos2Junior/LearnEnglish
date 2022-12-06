using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Helpers;
using LearnEnglish.Desktop.Models;
using LearnEnglish.Desktop.Presentation;
using System.Runtime.CompilerServices;

namespace LearnEnglish.Desktop.Services
{
    public class GlobalHotKeyService
    {
        private GlobalKeyboardHook _globalKeyboardHook;
        public List<HotKeyAttribute> HotKeys;
        private List<PressedKeys> LastPressedKeys = new();
        private Form _mainForm;
        private GlobalHotKeyService()
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
            HotKeys = new List<HotKeyAttribute>();
            foreach (HotKeyType hotkeyType in Enum.GetValues(typeof(HotKeyType)))
            {
                HotKeys.Add(LocalStorage.Instancia.LocalStorageInfo.HotKeys.FirstOrDefault(x => x.HotKeyType == hotkeyType) ?? hotkeyType.GetAttribute<HotKeyAttribute>());
            }
        }

        private static GlobalHotKeyService _instancia;
        public static GlobalHotKeyService Instancia
        {
            get
            {
                _instancia ??= new GlobalHotKeyService();

                return _instancia;
            }
        }

        private void OnKeyPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                if (_mainForm == null)
                {
                    _mainForm = Application.OpenForms[nameof(FrmMain)];
                }

                if (_mainForm?.Visible == false)
                {
                    if (HotKeyMatch(e.KeyboardData.Key) == HotKeyType.Show)
                    {
                        _mainForm.Show();
                    }
                }
            }
        }

        public HotKeyType? HotKeyMatch(Keys keyPressed, [CallerMemberName] string call = "")
        {
            if (!LocalStorage.Instancia.LocalStorageInfo.CustomKeys.Any(x => x.Key == keyPressed))
            {
                keyPressed = (Keys)keyPressed.ToAvailableKey();
            }

            if (keyPressed == Keys.None)
            {
                return null;
            }
            LastPressedKeys.Add(new PressedKeys(keyPressed, call));
            LastPressedKeys.RemoveAll(x => x.Date.AddSeconds(1) < DateTime.Now);
            HotKeyType? hotKeyMatch = null;

            var LastPressedKeysSameOrigin = LastPressedKeys.Where(x => x.Call == call);
            foreach (var hotKey in HotKeys)
            {
                //for hotkey with 1 key
                if (hotKey.Key2 == Keys.None && hotKey.Key3 == Keys.None && hotKey.Key1 == keyPressed)
                {
                    hotKeyMatch = hotKey.HotKeyType;
                    break;
                }
                //for hotkey with 2 key
                else if (hotKey.Key2 != Keys.None && hotKey.Key3 == Keys.None && LastPressedKeysSameOrigin.Count() > 1 && keyPressed == hotKey.Key2 && LastPressedKeysSameOrigin.SkipLast(1).Last().Key == hotKey.Key1)
                {
                    hotKeyMatch = hotKey.HotKeyType;
                    break;
                }
                //for hotkey with 3 key
                else if (hotKey.Key3 != Keys.None && LastPressedKeysSameOrigin.Count() > 2 && keyPressed == hotKey.Key3 && LastPressedKeysSameOrigin.SkipLast(1).Last().Key == hotKey.Key2 && LastPressedKeysSameOrigin.SkipLast(2).Last().Key == hotKey.Key1)
                {
                    hotKeyMatch = hotKey.HotKeyType;
                    break;
                }
            }

            return hotKeyMatch;
        }

        class PressedKeys
        {
            public string Call { get; private set; }
            public Keys Key { get; private set; }
            public DateTime Date { get; private set; }
            public PressedKeys(Keys key, string call)
            {
                Key = key;
                Date = DateTime.Now;
                Call = call;
            }

        }
    }
}
