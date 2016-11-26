using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationTaskApp
{
    public class TranslationTask
    {
        public string Title { get; set; }

        public string SourceLanguage { get; set; }
        public string TargetLanguage { get; set; }

        public string WordCount { get; set; }

        private TimeSpan _elapsed = new TimeSpan(0);
        public string ElapsedTime
        {
            get { return this._elapsed.ToString("g"); }
            set { this._elapsed = TimeSpan.Parse(value); }
        }
    }
}
