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
        public int listviews;
        public string videopath;
        public string commentpath;
        public string category;
        public string date;

        // constrcutors pathern (empthy space)

        public VideoList()
        {

        }

        //entrance paramaters for the constructor
        public VideoList(string listname, int listviews, string videopath, string commentpath, string category, string date)
        {
            this.listname = listname;
            this.listviews = listviews;
            this.videopath = videopath;
            this.commentpath = commentpath;
            this.category = category;
            this.date = date;
        }


    }
}
