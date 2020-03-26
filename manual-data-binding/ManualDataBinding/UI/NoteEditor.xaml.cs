using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        private Note note;
        public Note Note
        {
            get { return note; }
            set
            {
                if (note != null) note.NoteChanged -= OnNoteChanged;
                note = value;
                if(note!= null)
                {
                    Note.NoteChanged += OnNoteChanged;
                    OnNoteChanged(note, new EventArgs());
                }
            }
        
        }

        public NoteEditor()
        {
            InitializeComponent();
        }
        public void OnNoteChanged(object sender, EventArgs e)
        {
            if (Note == null) return;
            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }
    }
}
