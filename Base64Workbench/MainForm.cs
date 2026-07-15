using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Base64Workbench.Helpers;

namespace Base64Workbench;

public partial class MainForm : Form
{
    private string? selectedImage;


    public MainForm()
    {
        InitializeComponent();
    }


    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using OpenFileDialog dialog = new();

        dialog.Filter =
            "Images|*.png;*.jpg;*.jpeg;*.bmp;*.gif";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            selectedImage = dialog.FileName;

            pictureBox.Image = Image.FromFile(selectedImage);

            lblFile.Text = selectedImage;
        }
    }


    private void btnEncode_Click(object sender, EventArgs e)
    {
        if (selectedImage == null)
        {
            MessageBox.Show("Select an image first.");
            return;
        }

        txtBase64.Text =
            Base64Helper.EncodeImage(selectedImage);
    }


    private void btnCopy_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtBase64.Text))
        {
            Clipboard.SetText(txtBase64.Text);

            MessageBox.Show("Copied!");
        }
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
        using SaveFileDialog dialog = new();

        dialog.Filter = "Text files|*.txt";

        dialog.FileName = "image_base64.txt";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(
                dialog.FileName,
                txtBase64.Text);
        }
    }


    private void btnDecode_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtBase64.Text))
            {
                MessageBox.Show("Paste Base64 data first.");
                return;
            }

            pictureBox.Image =
                Base64Helper.DecodeImage(txtBase64.Text);

            lblFile.Text = "Image decoded successfully";
        }
        catch (Exception)
        {
            MessageBox.Show(
                "Invalid Base64 data. Please check your input.");
        }
    }
}