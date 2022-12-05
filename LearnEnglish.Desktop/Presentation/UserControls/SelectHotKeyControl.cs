using LearnEnglish.Desktop.Models;
using System.Globalization;

namespace LearnEnglish.Desktop.Presentation.UserControls
{
    public partial class SelectHotKeyControl : UserControl
    {
        public HotKeyAttribute HotKey { get; private set; }
        public SelectHotKeyControl(HotKeyAttribute hotKeyAttribute)
        {
            HotKey = hotKeyAttribute;
            InitializeComponent();
            lbl_key.Text = HotKey.DescriptionKey;
        }

        private void SelectHotKeyControl_Load(object sender, EventArgs e)
        {
            LoadCombo(cb_1, HotKey?.Key1);
            LoadCombo(cb_2, HotKey?.Key2);
            LoadCombo(cb_3, HotKey?.Key3);
        }

        private void LoadCombo(ComboBox comboBox, Keys? keySelected)
        {
            List<ComboKeyModel> comboKeys = new List<ComboKeyModel>();
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                comboKeys.Add(new ComboKeyModel { KeyDescription = key.ToString(), Value = key });
            }

            comboBox.DataSource = comboKeys;
            comboBox.DisplayMember = "KeyDescription";
            comboBox.ValueMember = "Value";
            if (keySelected != null)
            {
                comboBox.SelectedItem = comboKeys.FirstOrDefault(x => x.Value == keySelected);
            }
            else
            {
                comboBox.SelectedIndex = 0;
            }
        }

        class ComboKeyModel
        {
            public string KeyDescription { get; set; }
            public Keys Value { get; set; }
        }

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotKey.Key1 = ConvertKey(cb_1.SelectedItem);
        }

        private Keys ConvertKey(object obj) => ((ComboKeyModel)obj).Value;

        private void cb_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HotKey.Key2 == ConvertKey(cb_2.SelectedItem))
            {
                return;
            }

            if (HotKey.Key1 == Keys.None)
            {
                cb_2.SelectedValue = Keys.None;
            }
            else
            {
                HotKey.Key2 = ConvertKey(cb_2.SelectedItem);
            }
        }

        private void cb_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HotKey.Key3 == ConvertKey(cb_3.SelectedItem))
            {
                return;
            }

            if (HotKey.Key1 == Keys.None || HotKey.Key2 == Keys.None)
            {
                cb_3.SelectedValue = Keys.None;
            }
            else
            {
                HotKey.Key3 = ConvertKey(cb_3.SelectedItem);
            }
        }
    }
}
