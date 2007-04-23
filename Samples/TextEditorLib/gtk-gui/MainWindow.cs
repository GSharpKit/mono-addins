// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.VBox vbox2;
    
    private Gtk.MenuBar menubar;
    
    private Gtk.Toolbar toolbar;
    
    private Gtk.ScrolledWindow scrolledwindow1;
    
    private Gtk.TextView textview;
    
    private Gtk.VBox console;
    
    private Gtk.HBox hbox1;
    
    private Gtk.Label label1;
    
    private Gtk.Button button1;
    
    private Gtk.ScrolledWindow scrolledwindow2;
    
    private Gtk.TextView consoleView;
    
    private Gtk.Statusbar statusbar1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize();
        // Widget MainWindow
        Gtk.UIManager w1 = new Gtk.UIManager();
        Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
        w1.InsertActionGroup(w2, 0);
        this.AddAccelGroup(w1.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Text Editor");
        this.WindowPosition = ((Gtk.WindowPosition)(0));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox2 = new Gtk.VBox();
        this.vbox2.Name = "vbox2";
        // Container child vbox2.Gtk.Box+BoxChild
        w1.AddUiFromString("<ui><menubar name='menubar'/></ui>");
        this.menubar = ((Gtk.MenuBar)(w1.GetWidget("/menubar")));
        this.menubar.Name = "menubar";
        this.vbox2.Add(this.menubar);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.menubar]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        w1.AddUiFromString("<ui><toolbar name='toolbar'/></ui>");
        this.toolbar = ((Gtk.Toolbar)(w1.GetWidget("/toolbar")));
        this.toolbar.Name = "toolbar";
        this.toolbar.ShowArrow = false;
        this.toolbar.Tooltips = true;
        this.toolbar.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.toolbar.IconSize = ((Gtk.IconSize)(3));
        this.vbox2.Add(this.toolbar);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.toolbar]));
        w4.Position = 1;
        w4.Expand = false;
        w4.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        this.scrolledwindow1 = new Gtk.ScrolledWindow();
        this.scrolledwindow1.CanFocus = true;
        this.scrolledwindow1.Name = "scrolledwindow1";
        this.scrolledwindow1.VscrollbarPolicy = ((Gtk.PolicyType)(1));
        this.scrolledwindow1.HscrollbarPolicy = ((Gtk.PolicyType)(1));
        this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
        // Container child scrolledwindow1.Gtk.Container+ContainerChild
        this.textview = new Gtk.TextView();
        this.textview.CanFocus = true;
        this.textview.Name = "textview";
        this.scrolledwindow1.Add(this.textview);
        this.vbox2.Add(this.scrolledwindow1);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
        w6.Position = 2;
        // Container child vbox2.Gtk.Box+BoxChild
        this.console = new Gtk.VBox();
        this.console.Name = "console";
        this.console.Spacing = 6;
        this.console.BorderWidth = ((uint)(6));
        // Container child console.Gtk.Box+BoxChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        // Container child hbox1.Gtk.Box+BoxChild
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.Xalign = 0F;
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("Console");
        this.hbox1.Add(this.label1);
        Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
        w7.Position = 0;
        w7.Expand = false;
        w7.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.button1 = new Gtk.Button();
        this.button1.WidthRequest = 27;
        this.button1.HeightRequest = 20;
        this.button1.Name = "button1";
        this.button1.UseUnderline = true;
        this.button1.Relief = ((Gtk.ReliefStyle)(2));
        // Container child button1.Gtk.Container+ContainerChild
        Gtk.Alignment w8 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        w8.Name = "GtkAlignment";
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w9 = new Gtk.HBox();
        w9.Name = "GtkHBox";
        w9.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w10 = new Gtk.Image();
        w10.Name = "image24";
        w10.Pixbuf = Gtk.IconTheme.Default.LoadIcon("gtk-close", 16, 0);
        w9.Add(w10);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w12 = new Gtk.Label();
        w12.Name = "GtkLabel1";
        w12.LabelProp = "";
        w9.Add(w12);
        w8.Add(w9);
        this.button1.Add(w8);
        this.hbox1.Add(this.button1);
        Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox1[this.button1]));
        w16.PackType = ((Gtk.PackType)(1));
        w16.Position = 1;
        w16.Expand = false;
        w16.Fill = false;
        this.console.Add(this.hbox1);
        Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.console[this.hbox1]));
        w17.Position = 0;
        w17.Expand = false;
        w17.Fill = false;
        // Container child console.Gtk.Box+BoxChild
        this.scrolledwindow2 = new Gtk.ScrolledWindow();
        this.scrolledwindow2.CanFocus = true;
        this.scrolledwindow2.Name = "scrolledwindow2";
        this.scrolledwindow2.VscrollbarPolicy = ((Gtk.PolicyType)(1));
        this.scrolledwindow2.HscrollbarPolicy = ((Gtk.PolicyType)(1));
        this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
        // Container child scrolledwindow2.Gtk.Container+ContainerChild
        this.consoleView = new Gtk.TextView();
        this.consoleView.CanFocus = true;
        this.consoleView.Name = "consoleView";
        this.scrolledwindow2.Add(this.consoleView);
        this.console.Add(this.scrolledwindow2);
        Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.console[this.scrolledwindow2]));
        w19.Position = 1;
        this.vbox2.Add(this.console);
        Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox2[this.console]));
        w20.Position = 3;
        w20.Expand = false;
        w20.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        this.statusbar1 = new Gtk.Statusbar();
        this.statusbar1.Name = "statusbar1";
        this.statusbar1.Spacing = 2;
        this.vbox2.Add(this.statusbar1);
        Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox2[this.statusbar1]));
        w21.Position = 4;
        w21.Expand = false;
        w21.Fill = false;
        this.Add(this.vbox2);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 586;
        this.DefaultHeight = 356;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.button1.Clicked += new System.EventHandler(this.OnButton1Clicked);
    }
}
