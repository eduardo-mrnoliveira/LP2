﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PContato0030482413057.Utils.ColorTables
{
    public class MenuStripColorTable : ProfessionalColorTable
    {
        // Colors

        private readonly Color BackgroundColor;

        private readonly Color ItemSelectionColor;

        private readonly Color ItemPressedColor;

        public MenuStripColorTable(
            Color backgroundColor, Color itemSelectionColor, Color itemPressedColor
        )
        {
            this.BackgroundColor = backgroundColor;
            this.ItemSelectionColor = itemSelectionColor;
            this.ItemPressedColor = itemPressedColor;
        } 

        // Background

        public override Color MenuStripGradientBegin => BackgroundColor;
        public override Color MenuStripGradientEnd => BackgroundColor;

        // Item selection

        public override Color MenuItemSelected => ItemSelectionColor;
        public override Color MenuItemSelectedGradientBegin => ItemSelectionColor;
        public override Color MenuItemSelectedGradientEnd => ItemSelectionColor;

        // Item pressed

        public override Color MenuItemPressedGradientBegin => ItemPressedColor;
        public override Color MenuItemPressedGradientMiddle => ItemPressedColor;
        public override Color MenuItemPressedGradientEnd => ItemPressedColor;

        // Borders

        public override Color MenuBorder => BackgroundColor;
        public override Color MenuItemBorder => BackgroundColor;

        // Dropdown menu

        public override Color ToolStripPanelGradientBegin => BackgroundColor;
        public override Color ToolStripPanelGradientEnd => BackgroundColor;
        public override Color ToolStripContentPanelGradientBegin => BackgroundColor;
        public override Color ToolStripContentPanelGradientEnd => BackgroundColor;
        public override Color ToolStripBorder => BackgroundColor;
        public override Color ToolStripGradientBegin => BackgroundColor;
        public override Color ToolStripGradientMiddle => BackgroundColor;
        public override Color ToolStripGradientEnd => BackgroundColor;
        public override Color ToolStripDropDownBackground => BackgroundColor;
        public override Color ImageMarginGradientBegin => BackgroundColor;
        public override Color ImageMarginGradientEnd => BackgroundColor;
        public override Color ImageMarginGradientMiddle => BackgroundColor;
        public override Color ImageMarginRevealedGradientBegin => BackgroundColor;
        public override Color ImageMarginRevealedGradientEnd => BackgroundColor;
        public override Color ImageMarginRevealedGradientMiddle => BackgroundColor;
    }
}
