namespace Base64Workbench;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    private PictureBox pictureBox;
    private Button btnBrowse;
    private Button btnEncode;
    private Button btnCopy;
    private Button btnSave;
    private Button btnDecode;
    private RichTextBox txtBase64;
    private Label lblFile;


    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }


    private void InitializeComponent()
    {
        pictureBox = new PictureBox();
        btnBrowse = new Button();
        btnEncode = new Button();
        btnCopy = new Button();
        btnSave = new Button();
        btnDecode = new Button();
        txtBase64 = new RichTextBox();
        lblFile = new Label();


        SuspendLayout();


        //
        // pictureBox
        //
        pictureBox.Location = new Point(20, 20);
        pictureBox.Size = new Size(300, 250);
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox.BorderStyle = BorderStyle.FixedSingle;


        //
        // btnBrowse
        //
        btnBrowse.Text = "Open Image";
        btnBrowse.Location = new Point(20, 290);
        btnBrowse.Size = new Size(100, 30);
        btnBrowse.Click += btnBrowse_Click;


        //
        // btnEncode
        //
        btnEncode.Text = "Encode";
        btnEncode.Location = new Point(130, 290);
        btnEncode.Size = new Size(100, 30);
        btnEncode.Click += btnEncode_Click;


        //
        // btnCopy
        //
        btnCopy.Text = "Copy";
        btnCopy.Location = new Point(240, 290);
        btnCopy.Size = new Size(80, 30);
        btnCopy.Click += btnCopy_Click;


        //
        // btnSave
        //
        btnSave.Text = "Save TXT";
        btnSave.Location = new Point(330, 290);
        btnSave.Size = new Size(100, 30);
        btnSave.Click += btnSave_Click;


        //
        // btnDecode
        //
        btnDecode.Text = "Decode Image";
        btnDecode.Location = new Point(440, 290);
        btnDecode.Size = new Size(120, 30);
        btnDecode.Click += btnDecode_Click;


        //
        // lblFile
        //
        lblFile.Location = new Point(20, 330);
        lblFile.Size = new Size(800, 30);


        //
        // txtBase64
        //
        txtBase64.Location = new Point(350, 20);
        txtBase64.Size = new Size(500, 250);


        //
        // MainForm
        //
        Controls.Add(pictureBox);
        Controls.Add(btnBrowse);
        Controls.Add(btnEncode);
        Controls.Add(btnCopy);
        Controls.Add(btnSave);
        Controls.Add(btnDecode);
        Controls.Add(txtBase64);
        Controls.Add(lblFile);


        Text = "Base64-Workbench";
        ClientSize = new Size(900, 400);


        ResumeLayout(false);
    }
}