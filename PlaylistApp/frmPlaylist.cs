namespace PlaylistApp
{
    public partial class frmPlaylist : Form
    {
        DoubleLinkedList<string> tracks = new DoubleLinkedList<string>();
        Node<string> current;

        public frmPlaylist()
        {
            InitializeComponent();
        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            tracks.Append("Track 1");
            tracks.Append("Track 2");
            tracks.Append("Track 3");
            tracks.Append("Track 4");

            lstTracks.DataSource = tracks.GetList();
            current = tracks.Head;
            lblCurrent.Text = current.Data;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current.Next != null)
            {
                current = current.Next;
                lblCurrent.Text = current.Data;
            }
            else
            {
                MessageBox.Show("Nothing more to show :-|");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (current.Previous != null)
            {
                current = current.Previous;
                lblCurrent.Text = current.Data;
            }
            else
            {
                MessageBox.Show("Nothing more to show :-|");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbAddTrack.Text.Length > 0)
            {
                tracks.Append(txbAddTrack.Text);
                lstTracks.DataSource = tracks.GetList();
                txbAddTrack.Text = "";
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tracks.Remove(current.Data);
            if (current.Next != null)
            {
                current = current.Next;
            }

            lblCurrent.Text = current.Data;
            lstTracks.DataSource = tracks.GetList();
        }
    }
}