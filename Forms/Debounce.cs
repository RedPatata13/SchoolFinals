using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Finals.Forms
{
    public static class Debounce
    {
        private static readonly Dictionary<Control, System.Windows.Forms.Timer> debounceTimers = new();

        /// <summary>
        /// Adds a debounce mechanic to the Click event of the specified controls.
        /// </summary>
        /// <param name="debounceInterval">Debounce duration in milliseconds.</param>
        /// <param name="controls">The controls to apply debounce to.</param>
        public static void AddDebounceToControls(int debounceInterval = 300, params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control == null || debounceTimers.ContainsKey(control)) continue;

                var timer = new System.Windows.Forms.Timer
                {
                    Interval = debounceInterval,
                    Enabled = false
                };

                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    if (control.IsHandleCreated && !control.IsDisposed)
                        control.Enabled = true;
                };

                debounceTimers[control] = timer;

                control.Click += (sender, args) =>
                {
                    // Only debounce if the control was enabled at the time of click
                    if (!control.Enabled) return;

                    control.Enabled = false;
                    debounceTimers[control].Start();
                };
            }
        }
    }
}
