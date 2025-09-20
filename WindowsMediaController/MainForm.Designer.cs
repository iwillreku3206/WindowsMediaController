namespace WindowsMediaController;

partial class MainForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonPlayPause = new System.Windows.Forms.Button();
        buttonPrevious = new System.Windows.Forms.Button();
        buttonNext = new System.Windows.Forms.Button();
        labelTitle = new System.Windows.Forms.Label();
        labelSubtitle = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // buttonPlayPause
        // 
        buttonPlayPause.Location = new System.Drawing.Point(150, 75);
        buttonPlayPause.Name = "buttonPlayPause";
        buttonPlayPause.Size = new System.Drawing.Size(100, 23);
        buttonPlayPause.TabIndex = 0;
        buttonPlayPause.Text = "Play/Pause";
        buttonPlayPause.UseVisualStyleBackColor = true;
        buttonPlayPause.Click += buttonPlayPause_Click;
        // 
        // buttonPrevious
        // 
        buttonPrevious.Location = new System.Drawing.Point(44, 75);
        buttonPrevious.Name = "buttonPrevious";
        buttonPrevious.Size = new System.Drawing.Size(100, 23);
        buttonPrevious.TabIndex = 1;
        buttonPrevious.Text = "Previous";
        buttonPrevious.UseVisualStyleBackColor = true;
        buttonPrevious.Click += buttonPrevious_Click;
        // 
        // buttonNext
        // 
        buttonNext.Location = new System.Drawing.Point(256, 75);
        buttonNext.Name = "buttonNext";
        buttonNext.Size = new System.Drawing.Size(100, 23);
        buttonNext.TabIndex = 2;
        buttonNext.Text = "Next";
        buttonNext.UseVisualStyleBackColor = true;
        buttonNext.Click += buttonNext_Click;
        // 
        // labelTitle
        // 
        labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelTitle.Location = new System.Drawing.Point(75, 20);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new System.Drawing.Size(250, 18);
        labelTitle.TabIndex = 3;
        labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // labelSubtitle
        // 
        labelSubtitle.Location = new System.Drawing.Point(75, 40);
        labelSubtitle.Name = "labelSubtitle";
        labelSubtitle.Size = new System.Drawing.Size(250, 18);
        labelSubtitle.TabIndex = 4;
        labelSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Window;
        ClientSize = new System.Drawing.Size(392, 114);
        ControlBox = false;
        Controls.Add(labelSubtitle);
        Controls.Add(labelTitle);
        Controls.Add(buttonNext);
        Controls.Add(buttonPrevious);
        Controls.Add(buttonPlayPause);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        ShowIcon = false;
        ShowInTaskbar = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        Text = "MainForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelSubtitle;

    private System.Windows.Forms.Label labelTitle;

    private System.Windows.Forms.Button buttonPrevious;
    private System.Windows.Forms.Button buttonNext;

    private System.Windows.Forms.Button buttonPlayPause;

    #endregion
}