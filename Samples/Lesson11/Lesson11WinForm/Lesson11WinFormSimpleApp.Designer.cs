namespace Lesson11WinForm;

partial class Lesson11WinFormSimpleApp
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
        btSimpleDelegate = new Button();
        lbSimpleDelegate = new Label();
        tbSimpleDelegate = new TextBox();
        btMulticastDelegate = new Button();
        tbMulticastDelegate = new TextBox();
        lbMulticastDelegate = new Label();
        SuspendLayout();
        // 
        // btSimpleDelegate
        // 
        btSimpleDelegate.Location = new Point(60, 352);
        btSimpleDelegate.Name = "btSimpleDelegate";
        btSimpleDelegate.Size = new Size(171, 34);
        btSimpleDelegate.TabIndex = 0;
        btSimpleDelegate.Text = "Simple delegate";
        btSimpleDelegate.UseVisualStyleBackColor = true;
        btSimpleDelegate.Click += button1_Click;
        // 
        // lbSimpleDelegate
        // 
        lbSimpleDelegate.AutoSize = true;
        lbSimpleDelegate.Location = new Point(31, 49);
        lbSimpleDelegate.Name = "lbSimpleDelegate";
        lbSimpleDelegate.Size = new Size(189, 25);
        lbSimpleDelegate.TabIndex = 1;
        lbSimpleDelegate.Text = "Result simple delegate";
        // 
        // tbSimpleDelegate
        // 
        tbSimpleDelegate.Location = new Point(230, 50);
        tbSimpleDelegate.Name = "tbSimpleDelegate";
        tbSimpleDelegate.Size = new Size(459, 31);
        tbSimpleDelegate.TabIndex = 2;
        // 
        // btMulticastDelegate
        // 
        btMulticastDelegate.Location = new Point(288, 352);
        btMulticastDelegate.Name = "btMulticastDelegate";
        btMulticastDelegate.Size = new Size(215, 34);
        btMulticastDelegate.TabIndex = 3;
        btMulticastDelegate.Text = "Multicast Delegate";
        btMulticastDelegate.UseVisualStyleBackColor = true;
        btMulticastDelegate.Click += button1_Click_1;
        // 
        // tbMulticastDelegate
        // 
        tbMulticastDelegate.Location = new Point(230, 141);
        tbMulticastDelegate.Name = "tbMulticastDelegate";
        tbMulticastDelegate.Size = new Size(459, 31);
        tbMulticastDelegate.TabIndex = 5;
        // 
        // lbMulticastDelegate
        // 
        lbMulticastDelegate.AutoSize = true;
        lbMulticastDelegate.Location = new Point(31, 144);
        lbMulticastDelegate.Name = "lbMulticastDelegate";
        lbMulticastDelegate.Size = new Size(202, 25);
        lbMulticastDelegate.TabIndex = 4;
        lbMulticastDelegate.Text = "Result milticast delegate";
        
        // 
        // Lesson11WinFormSimpleApp
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tbMulticastDelegate);
        Controls.Add(lbMulticastDelegate);
        Controls.Add(btMulticastDelegate);
        Controls.Add(tbSimpleDelegate);
        Controls.Add(lbSimpleDelegate);
        Controls.Add(btSimpleDelegate);
        Name = "Lesson11WinFormSimpleApp";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btSimpleDelegate;
    private Label lbSimpleDelegate;
    private TextBox tbSimpleDelegate;
    private Button btMulticastDelegate;
    private TextBox tbMulticastDelegate;
    private Label lbMulticastDelegate;
}