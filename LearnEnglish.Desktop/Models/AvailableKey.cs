namespace LearnEnglish.Desktop.Models
{
    public enum AvailableKey
    {
        None = Keys.None,
        Control = Keys.Control,
        Shift = Keys.Shift,
        Tab = Keys.Tab,
        CapsLock = Keys.CapsLock,
        Alt = Keys.Alt,
        Space = Keys.Space,
        Esc = Keys.Escape,
        Enter = Keys.Enter,
        F1 = Keys.F1,
        F2 = Keys.F2,
        F3 = Keys.F3,
        F4 = Keys.F4,
        F5 = Keys.F5,
        F6 = Keys.F6,
        F7 = Keys.F7,
        F8 = Keys.F8,
        F9 = Keys.F9,
        F10 = Keys.F10,
        F11 = Keys.F11,
        F12 = Keys.F12,
    }

    public static class KeysExteions
    {
        public static AvailableKey ToAvailableKey(this Keys key)
        {
            foreach (var item in new Keys[] { Keys.Control, Keys.ControlKey, Keys.LControlKey, Keys.RControlKey })
            {
                if (item == key) { return AvailableKey.Control; }
            }

            foreach (var item in new Keys[] { Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey })
            {
                if (item == key) { return AvailableKey.Shift; }
            }

            foreach (var item in new Keys[] { Keys.Alt, Keys.Menu, Keys.LMenu, Keys.RMenu })
            {
                if (item == key) { return AvailableKey.Alt; }
            }

            if (Enum.IsDefined(typeof(AvailableKey), (AvailableKey)key))
            {
                return (AvailableKey)key;
            }

            return AvailableKey.None;
        }
    }
}
