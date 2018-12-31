using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoWay
{
    class VideoList
    {
        //declaring class atributes of the video list
        public string listname;
        public int listveiws;
        public string videopath;
        public string commentpath;
        public string category;

        // constrcutors pathern (empthy space)

        public VideoList()
        {

        }

        //entrance paramaters for the constructor
        public VideoList(string listname, int listveiws, string videopath, string commentpath, string category)
        {
            this.listname = listname;
            this.listveiws = listveiws;
            this.videopath = videopath;
            this.commentpath = commentpath;
            this.category = category;
        }


    }
}
