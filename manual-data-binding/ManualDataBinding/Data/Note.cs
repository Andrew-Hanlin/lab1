using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {

        public EventHandler NoteChanged;

        private string title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title {
            get { return title; }
            set {
                if (title == null) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

            
            
            
            //{ get; set; } = DateTime.Now.ToString();
            private string body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (body == null) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
