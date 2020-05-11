using System;
using System.Collections.Generic;
using System.Text;

namespace ClassConcepts
{
    public class Tree
    {
        private int height;

        public string Color { get; set; }
        public int Height
        {
            get => height;
            set => height = value;
        }

        #region Constructor

        public Tree(int height)
        {
            this.height = height;
        }
        #endregion
    }
}
