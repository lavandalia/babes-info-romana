
// This file has been generated by the GUI designer. Do not modify.

public partial class ClerkOfficeWindow
{
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Button btnNext;
	
	private global::Gtk.Button btnArrived;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget ClerkOfficeWindow
		this.Name = "ClerkOfficeWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("ClerkOfficeWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child ClerkOfficeWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.btnNext = new global::Gtk.Button ();
		this.btnNext.CanFocus = true;
		this.btnNext.Name = "btnNext";
		this.btnNext.UseUnderline = true;
		this.btnNext.Label = global::Mono.Unix.Catalog.GetString ("Next");
		this.vbox3.Add (this.btnNext);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.btnNext]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.btnArrived = new global::Gtk.Button ();
		this.btnArrived.CanFocus = true;
		this.btnArrived.Name = "btnArrived";
		this.btnArrived.UseUnderline = true;
		this.btnArrived.Label = global::Mono.Unix.Catalog.GetString ("Arrived");
		this.vbox3.Add (this.btnArrived);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.btnArrived]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 60;
		this.Show ();
		this.btnNext.Clicked += new global::System.EventHandler (this.OnBtnNextClicked);
		this.btnArrived.Clicked += new global::System.EventHandler (this.OnBtnArrivedClicked);
	}
}
