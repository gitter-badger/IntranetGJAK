﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntranetGJAK.Models.JSON.Blueimp_FileUpload
{
    using System.IO;

    public class FilesData
    {
        public IBlueimpResult[] files { get; set; }
    }

    public class DeletedData
    {
        public Dictionary<string, bool> files { get; set; }
    }

    public interface IBlueimpResult
    {

    }

    public class Uploadad : IBlueimpResult
    {
        public string name { get; set; }

        public int size { get; set; }

        public string url { get; set; }

        public string thumbnailurl { get; set; }

        public string deleteUrl { get; set; }

        public string deleteTyp { get; set; }
    }

    public class UploadFailed : IBlueimpResult
    {
        public string name { get; set; }

        public int size { get; set; }

        public string error { get; set; }
    }

}

////{"files": [
////  {
////    "picture1.jpg": true
////  },
////  {
////    "picture2.jpg": true
////  }
////]}

////{"files": [
////  {
////    "name": "picture1.jpg",
////    "size": 902604,
////    "error": "Filetype not allowed"
////  },
////  {
////    "name": "picture2.jpg",
////    "size": 841946,
////    "error": "Filetype not allowed"
////  }
////]}

////{"files": [
////  {
////    "name": "picture1.jpg",
////    "size": 902604,
////    "url": "http:\/\/example.org\/files\/picture1.jpg",
////    "thumbnailUrl": "http:\/\/example.org\/files\/thumbnail\/picture1.jpg",
////    "deleteUrl": "http:\/\/example.org\/files\/picture1.jpg",
////    "deleteType": "DELETE"
////  },
////  {
////    "name": "picture2.jpg",
////    "size": 841946,
////    "url": "http:\/\/example.org\/files\/picture2.jpg",
////    "thumbnailUrl": "http:\/\/example.org\/files\/thumbnail\/picture2.jpg",
////    "deleteUrl": "http:\/\/example.org\/files\/picture2.jpg",
////    "deleteType": "DELETE"
////  }
////]}