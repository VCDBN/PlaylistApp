namespace PlaylistApp
{
    partial class frmPlaylist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstTracks = new ListBox();
            lblCurrent = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnAdd = new Button();
            txbAddTrack = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lstTracks
            // 
            lstTracks.FormattingEnabled = true;
            lstTracks.ItemHeight = 15;
            lstTracks.Location = new Point(418, 27);
            lstTracks.Name = "lstTracks";
            lstTracks.SelectionMode = SelectionMode.None;
            lstTracks.Size = new Size(194, 289);
            lstTracks.TabIndex = 0;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Location = new Point(172, 132);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(0, 15);
            lblCurrent.TabIndex = 1;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(51, 227);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(293, 227);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(356, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(42, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txbAddTrack
            // 
            txbAddTrack.Location = new Point(32, 27);
            txbAddTrack.Name = "txbAddTrack";
            txbAddTrack.Size = new Size(302, 23);
            txbAddTrack.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(148, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Current";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 336);
            Controls.Add(btnDelete);
            Controls.Add(txbAddTrack);
            Controls.Add(btnAdd);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblCurrent);
            Controls.Add(lstTracks);
            Name = "frmPlaylist";
            Text = "PlaylistApp";
            Load += frmPlaylist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTracks;
        private Label lblCurrent;
        private Button btnPrev;
        private Button btnNext;
        private Button btnAdd;
        private TextBox txbAddTrack;
        private Button btnDelete;
    }
}