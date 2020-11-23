using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Classes
{
    public class Toast
    {
        private bool withButter;
        private bool withJam;

        public void ApplyButter()
        {
            this.withButter = true;
        }

        public void ApplyJam()
        {
            this.withJam = true;
        }

        public bool ButterApplied
        {
            get
            {
                return this.withButter;
            }
        }

        public bool JamApplied
        {
            get
            {
                return this.withJam;
            }
        }

    }
}