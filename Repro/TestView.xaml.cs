namespace Repro;


public partial class TestView : Label
{
    public TestView()
    {
        this.InitializeComponent();
    }
    
    public static readonly BindableProperty TheValueProperty = BindableProperty.Create(
        nameof(TheValueProperty),
        typeof(TestEnum?),
        typeof(TestView)
    );
    public TestEnum? TheValue
    {
        get => (TestEnum?)this.GetValue(TheValueProperty);
        set => this.SetValue(TheValueProperty, value);
    }
    
    
    public static readonly BindableProperty TheNonNullEnumProperty = BindableProperty.Create(
        nameof(TextProperty),
        typeof(string),
        typeof(TestView)
    );
    public string TheNonNullEnum
    {
        get => (string)this.GetValue(TheNonNullEnumProperty);
        set => this.SetValue(TheNonNullEnumProperty, value);
    }
    

    protected override void OnPropertyChanged(string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);
        switch (propertyName)
        {
            case nameof(this.TheValue):
                this.Text = this.TheValue?.ToString() ?? "I did bind, but it was null";
                break;
        }
    }
}