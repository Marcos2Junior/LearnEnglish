using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Helpers;
using LearnEnglish.Desktop.Models;
using LearnEnglish.Desktop.Presentation;

namespace LearnEnglish.Desktop.Services
{
    public class GlobalHotKeyService
    {
        private GlobalKeyboardHook _globalKeyboardHook;
        public List<HotKeyAttribute> HotKeys;
        private List<Tuple<Keys, DateTime>> LastPressedKeys = new();
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
                HotKeyMatch(e.KeyboardData.Key);
            }
        }

        public HotKeyType? HotKeyMatch(Keys keyPressed)
        {
            LastPressedKeys.Add(new Tuple<Keys, DateTime>(keyPressed, DateTime.Now));
            LastPressedKeys.RemoveAll(x => x.Item2.AddSeconds(1) < DateTime.Now);

            HotKeyType? hotKeyMatch = null;
            foreach (var hotKey in HotKeys)
            {
                //for hotkey with 1 key
                if (hotKey.Key2 == Keys.None && hotKey.Key3 == Keys.None && hotKey.Key1 == LastPressedKeys.Last().Item1)
                {
                    hotKeyMatch = hotKey.HotKeyType;
                    break;
                }
                //for hotkey with 2 key
                else if (hotKey.Key2 != Keys.None && hotKey.Key3 == Keys.None && LastPressedKeys.Count() > 1 && LastPressedKeys.Last().Item1 == hotKey.Key2 && LastPressedKeys.SkipLast(1).Last().Item1 == hotKey.Key1)
                {
                    hotKeyMatch = hotKey.HotKeyType;
                    break;
                }
                //for hotkey with 3 key
                else if (hotKey.Key3 != Keys.None && LastPressedKeys.Count() > 2 && LastPressedKeys.Last().Item1 == hotKey.Key3 && LastPressedKeys.SkipLast(1).Last().Item1 == hotKey.Key2 && LastPressedKeys.SkipLast(2).Last().Item1 == hotKey.Key1)
                {
                    hotKeyMatch = hotKey.HotKeyType;
                    break;
                }
            }

            if (hotKeyMatch == HotKeyType.Show)
            {
                var frmMain = Application.OpenForms[nameof(FrmMain)];
                if (!frmMain.Visible)
                {
                    frmMain.Show();
                }
            }
            return hotKeyMatch;
        }
    }
}
