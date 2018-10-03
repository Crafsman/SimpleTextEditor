using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{

    // Treat every selected string as an object
    public class SelectedFontStatus
    {
        public bool Regular { set; get; }
        public bool Bold { set; get; }
        public bool Italic { set; get; }
        public bool Underline { set; get; }
        public int Size { set; get; }

        public int StartPosition { set; get; }
        public int EndPosition { set; get; }
        public int StringLenth { set; get; }

        //defualt is null
        public string SelectedString { set; get; }

    }

}
