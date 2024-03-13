namespace Lesson11WinForm;

public partial class Lesson11WinFormSimpleApp : Form
{
    public Lesson11WinFormSimpleApp()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var delegateClass = new DelegateClass();
        tbSimpleDelegate.Text = delegateClass.PrintMessage(1, message =>
            $"Calling delegate {nameof(DelegateMessage)} with parameter {1} ");
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        var multicastDelegateClass = new DelegateClass();
        tbMulticastDelegate.Text = multicastDelegateClass.PrintMessage(2, message =>
            $"Calling another delegate {nameof(DelegateMessage)} with parameter {2} ");

        tbMulticastDelegate.Text += multicastDelegateClass.PrintMessage(1, message =>
            $"Calling delegate {nameof(DelegateMessage)} with parameter {1} ");
        

    }
}