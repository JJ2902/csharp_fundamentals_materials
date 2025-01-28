using System;

namespace CSharp.Strings{
    class StoryBuilder{
        string Plot;

        public StoryBuilder(string Plot)
        {
            this.Plot = Plot;
        }

        internal string AddPlotline(string Plotline){
        return Plot + Plotline;
        }
        internal string GetPlot(){
        return Plot;
        }
    }
}