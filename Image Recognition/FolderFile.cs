﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Recognition
{
    public class FolderFile
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileExtension { get; set; }
        public string PredictionLabel { get; set; }

        public FolderFile()
        {
            PredictionLabel = "Not yet analyzed";
        }
    }
}
