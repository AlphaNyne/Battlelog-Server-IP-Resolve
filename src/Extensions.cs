﻿/*
 * Copyright (c) 2018 AlphaNyne
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Windows.Forms;

namespace EA.Battlelog.IPResolve
{
  public static class Extensions
  {
    public static void Text(this TextBox gadget, string value)
    {
      if (gadget == null) {
        throw new NullReferenceException(nameof(gadget));
      }
      if (string.IsNullOrEmpty(value)) {
        throw new ArgumentNullException(nameof(value));
      }

      if (gadget.InvokeRequired) {
        gadget.Invoke((Action)delegate {
          gadget.Text = value;
        });
      }
      else {
        gadget.Text = value;
      }
    }

    public static void WriteLine(this TextBox gadget, string value)
    {
      if (gadget == null) {
        throw new NullReferenceException(nameof(gadget));
      }
      if (string.IsNullOrEmpty(value)) {
        throw new ArgumentNullException(nameof(value));
      }

      if (gadget.InvokeRequired) {
        gadget.Invoke((Action)delegate {
          gadget.Text += value;
        });
      }
      else {
        gadget.Text += value;
      }
    }
  }
}
