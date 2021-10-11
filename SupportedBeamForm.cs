using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Dialog;

namespace SupportedBeam
{
    public partial class SupportedBeamForm : PluginFormBase
    {
        public SupportedBeamForm()
        {
            InitializeComponent();
        }

        private void OkApplyModifyGetOnOffCancel1_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel1_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel1_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel1_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel1_OkClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel1_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }
        protected override string LoadValuesPath(string FileName)
        {
            // SetAttributeValue("TextBox", "String");
            SetAttributeValue(CbFROST, 8);
            SetAttributeValue(CbARMTYPE, 7);
            SetAttributeValue(CbEVENNES, 6);
            SetAttributeValue(CbHIDE, 2);
            SetAttributeValue(CbWATER, 10);
            SetAttributeValue(Tb_Move, 0.00);
            SetAttributeValue(Tb_Material, "C255");
            SetAttributeValue(Tb_Profile, "PK120X6.0_54157_2010");
            string Result = base.LoadValuesPath(FileName);
            Apply();
            return Result;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _ = new ProEngineering.FeedBackForm();
        }

        private void MaterialCatalog1_SelectClicked(object sender, EventArgs e)
        {
            materialCatalog1.SelectedMaterial = Tb_Material.Text;
        }

        private void MaterialCatalog1_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(Tb_Material, materialCatalog1.SelectedMaterial);
        }

        private void ProfileCatalog1_SelectClicked(object sender, EventArgs e)
        {
            profileCatalog1.SelectedProfile = Tb_Profile.Text;
        }

        private void ProfileCatalog1_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(Tb_Profile, profileCatalog1.SelectedProfile);
        }

        private void Tb_Move_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.') || (e.KeyChar == '-')))
                e.Handled = true;
        }
    }
}
