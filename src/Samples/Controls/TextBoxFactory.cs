﻿using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

using XPTable.Models;

namespace Grouping
{
    public class TextBoxFactory : ControlFactory
    {
        public TextBoxFactory()
        {
        }

        public override System.Windows.Forms.Control GetControl(Cell cell)
        {
            var box = new TextBox
            {
                Text = cell.Text
            };
            return box;
        }
    }
}
