
// This file has been generated by the GUI designer. Do not modify.
namespace FamilyDoctor.UI.GTK
{
	public partial class MainWindow
	{
		private global::Gtk.Notebook nbMain;
		
		private global::Gtk.Notebook nbAppointments;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Table tblAppointmentsAdd;
		
		private global::Gtk.Calendar calAppointmentDate;
		
		private global::Gtk.CheckButton chkAppointmentEmergency;
		
		private global::Gtk.Entry entAppointmentAppointmentID;
		
		private global::Gtk.Entry entAppointmentDiagnostic;
		
		private global::Gtk.Entry entAppointmentPatientID;
		
		private global::Gtk.Label lblAppointmentAppointmentID;
		
		private global::Gtk.Label lblAppointmentDate;
		
		private global::Gtk.Label lblAppointmentDiagnostic;
		
		private global::Gtk.Label lblAppointmentEmergency;
		
		private global::Gtk.Label lblAppointmentPatientID;
		
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Button btnAppointmentAdd;
		
		private global::Gtk.Label lblAddAppointment;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Table tbAppointmentsList;
		
		private global::Gtk.ComboBox cmbAppointmentListCriteria;
		
		private global::Gtk.Entry entAppointmentListValue;
		
		private global::Gtk.Label lblAppointmentListValue;
		
		private global::Gtk.Label lblAppoitnemtListCriteria;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView txtAppointmentListResult;
		
		private global::Gtk.Button btnAppointmentsList;
		
		private global::Gtk.Label lblListAppointment;
		
		private global::Gtk.Label lblAppointments;
		
		private global::Gtk.Notebook nbPatients;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Table tblPatientsAdd;
		
		private global::Gtk.Entry entPatientID;
		
		private global::Gtk.Entry entPatientName;
		
		private global::Gtk.Label lblPatientAge;
		
		private global::Gtk.Label lblPatientID;
		
		private global::Gtk.Label lblPatientName;
		
		private global::Gtk.SpinButton spnPatientAge;
		
		private global::Gtk.Fixed fixed2;
		
		private global::Gtk.Button btnPatientAdd;
		
		private global::Gtk.Label lblAddPatient;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.Table tblPatientsList;
		
		private global::Gtk.ComboBox cmbPatientListCriteria;
		
		private global::Gtk.Entry entPatientListValue;
		
		private global::Gtk.Label lblPatientListCriteria;
		
		private global::Gtk.Label lblPatientListValue;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TextView txtPatientListResult;
		
		private global::Gtk.Button btnPatientList;
		
		private global::Gtk.Label lblListPatient1;
		
		private global::Gtk.Label lblPatients;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FamilyDoctor.UI.GTK.MainWindow
			this.Name = "FamilyDoctor.UI.GTK.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child FamilyDoctor.UI.GTK.MainWindow.Gtk.Container+ContainerChild
			this.nbMain = new global::Gtk.Notebook ();
			this.nbMain.CanFocus = true;
			this.nbMain.Name = "nbMain";
			this.nbMain.CurrentPage = 0;
			// Container child nbMain.Gtk.Notebook+NotebookChild
			this.nbAppointments = new global::Gtk.Notebook ();
			this.nbAppointments.CanFocus = true;
			this.nbAppointments.Name = "nbAppointments";
			this.nbAppointments.CurrentPage = 0;
			// Container child nbAppointments.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.tblAppointmentsAdd = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.tblAppointmentsAdd.Name = "tblAppointmentsAdd";
			this.tblAppointmentsAdd.RowSpacing = ((uint)(6));
			this.tblAppointmentsAdd.ColumnSpacing = ((uint)(6));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.calAppointmentDate = new global::Gtk.Calendar ();
			this.calAppointmentDate.CanFocus = true;
			this.calAppointmentDate.Name = "calAppointmentDate";
			this.calAppointmentDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.tblAppointmentsAdd.Add (this.calAppointmentDate);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.calAppointmentDate]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.chkAppointmentEmergency = new global::Gtk.CheckButton ();
			this.chkAppointmentEmergency.CanFocus = true;
			this.chkAppointmentEmergency.Name = "chkAppointmentEmergency";
			this.chkAppointmentEmergency.Label = "";
			this.chkAppointmentEmergency.DrawIndicator = true;
			this.chkAppointmentEmergency.UseUnderline = true;
			this.tblAppointmentsAdd.Add (this.chkAppointmentEmergency);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.chkAppointmentEmergency]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.entAppointmentAppointmentID = new global::Gtk.Entry ();
			this.entAppointmentAppointmentID.CanFocus = true;
			this.entAppointmentAppointmentID.Name = "entAppointmentAppointmentID";
			this.entAppointmentAppointmentID.IsEditable = true;
			this.entAppointmentAppointmentID.InvisibleChar = '●';
			this.tblAppointmentsAdd.Add (this.entAppointmentAppointmentID);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.entAppointmentAppointmentID]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.entAppointmentDiagnostic = new global::Gtk.Entry ();
			this.entAppointmentDiagnostic.CanFocus = true;
			this.entAppointmentDiagnostic.Name = "entAppointmentDiagnostic";
			this.entAppointmentDiagnostic.IsEditable = true;
			this.entAppointmentDiagnostic.InvisibleChar = '●';
			this.tblAppointmentsAdd.Add (this.entAppointmentDiagnostic);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.entAppointmentDiagnostic]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.entAppointmentPatientID = new global::Gtk.Entry ();
			this.entAppointmentPatientID.CanFocus = true;
			this.entAppointmentPatientID.Name = "entAppointmentPatientID";
			this.entAppointmentPatientID.IsEditable = true;
			this.entAppointmentPatientID.InvisibleChar = '●';
			this.tblAppointmentsAdd.Add (this.entAppointmentPatientID);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.entAppointmentPatientID]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.lblAppointmentAppointmentID = new global::Gtk.Label ();
			this.lblAppointmentAppointmentID.Name = "lblAppointmentAppointmentID";
			this.lblAppointmentAppointmentID.Xalign = 0F;
			this.lblAppointmentAppointmentID.Yalign = 0F;
			this.lblAppointmentAppointmentID.LabelProp = global::Mono.Unix.Catalog.GetString ("Appointment ID");
			this.tblAppointmentsAdd.Add (this.lblAppointmentAppointmentID);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.lblAppointmentAppointmentID]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.lblAppointmentDate = new global::Gtk.Label ();
			this.lblAppointmentDate.Name = "lblAppointmentDate";
			this.lblAppointmentDate.Xalign = 0F;
			this.lblAppointmentDate.Yalign = 0F;
			this.lblAppointmentDate.LabelProp = global::Mono.Unix.Catalog.GetString ("Date");
			this.tblAppointmentsAdd.Add (this.lblAppointmentDate);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.lblAppointmentDate]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.lblAppointmentDiagnostic = new global::Gtk.Label ();
			this.lblAppointmentDiagnostic.Name = "lblAppointmentDiagnostic";
			this.lblAppointmentDiagnostic.Xalign = 0F;
			this.lblAppointmentDiagnostic.Yalign = 0F;
			this.lblAppointmentDiagnostic.LabelProp = global::Mono.Unix.Catalog.GetString ("Diagnostic");
			this.tblAppointmentsAdd.Add (this.lblAppointmentDiagnostic);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.lblAppointmentDiagnostic]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.lblAppointmentEmergency = new global::Gtk.Label ();
			this.lblAppointmentEmergency.Name = "lblAppointmentEmergency";
			this.lblAppointmentEmergency.Xalign = 0F;
			this.lblAppointmentEmergency.Yalign = 0F;
			this.lblAppointmentEmergency.LabelProp = global::Mono.Unix.Catalog.GetString ("Emergency");
			this.tblAppointmentsAdd.Add (this.lblAppointmentEmergency);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.lblAppointmentEmergency]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblAppointmentsAdd.Gtk.Table+TableChild
			this.lblAppointmentPatientID = new global::Gtk.Label ();
			this.lblAppointmentPatientID.Name = "lblAppointmentPatientID";
			this.lblAppointmentPatientID.Xalign = 0F;
			this.lblAppointmentPatientID.Yalign = 0F;
			this.lblAppointmentPatientID.LabelProp = global::Mono.Unix.Catalog.GetString ("Patient ID");
			this.tblAppointmentsAdd.Add (this.lblAppointmentPatientID);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tblAppointmentsAdd [this.lblAppointmentPatientID]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.tblAppointmentsAdd);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.tblAppointmentsAdd]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox2.Add (this.fixed1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fixed1]));
			w12.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.btnAppointmentAdd = new global::Gtk.Button ();
			this.btnAppointmentAdd.CanFocus = true;
			this.btnAppointmentAdd.Name = "btnAppointmentAdd";
			this.btnAppointmentAdd.UseUnderline = true;
			this.btnAppointmentAdd.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbox2.Add (this.btnAppointmentAdd);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnAppointmentAdd]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.nbAppointments.Add (this.vbox2);
			// Notebook tab
			this.lblAddAppointment = new global::Gtk.Label ();
			this.lblAddAppointment.Name = "lblAddAppointment";
			this.lblAddAppointment.LabelProp = global::Mono.Unix.Catalog.GetString ("Add");
			this.nbAppointments.SetTabLabel (this.vbox2, this.lblAddAppointment);
			this.lblAddAppointment.ShowAll ();
			// Container child nbAppointments.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.tbAppointmentsList = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.tbAppointmentsList.Name = "tbAppointmentsList";
			this.tbAppointmentsList.RowSpacing = ((uint)(6));
			this.tbAppointmentsList.ColumnSpacing = ((uint)(6));
			// Container child tbAppointmentsList.Gtk.Table+TableChild
			this.cmbAppointmentListCriteria = global::Gtk.ComboBox.NewText ();
			this.cmbAppointmentListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("All"));
			this.cmbAppointmentListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("Patient"));
			this.cmbAppointmentListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("Diagnostic"));
			this.cmbAppointmentListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("Emergency"));
			this.cmbAppointmentListCriteria.Name = "cmbAppointmentListCriteria";
			this.cmbAppointmentListCriteria.Active = 0;
			this.tbAppointmentsList.Add (this.cmbAppointmentListCriteria);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tbAppointmentsList [this.cmbAppointmentListCriteria]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tbAppointmentsList.Gtk.Table+TableChild
			this.entAppointmentListValue = new global::Gtk.Entry ();
			this.entAppointmentListValue.CanFocus = true;
			this.entAppointmentListValue.Name = "entAppointmentListValue";
			this.entAppointmentListValue.IsEditable = true;
			this.entAppointmentListValue.InvisibleChar = '●';
			this.tbAppointmentsList.Add (this.entAppointmentListValue);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tbAppointmentsList [this.entAppointmentListValue]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tbAppointmentsList.Gtk.Table+TableChild
			this.lblAppointmentListValue = new global::Gtk.Label ();
			this.lblAppointmentListValue.Name = "lblAppointmentListValue";
			this.lblAppointmentListValue.Xalign = 0F;
			this.lblAppointmentListValue.Yalign = 0F;
			this.lblAppointmentListValue.LabelProp = global::Mono.Unix.Catalog.GetString ("Value");
			this.tbAppointmentsList.Add (this.lblAppointmentListValue);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.tbAppointmentsList [this.lblAppointmentListValue]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tbAppointmentsList.Gtk.Table+TableChild
			this.lblAppoitnemtListCriteria = new global::Gtk.Label ();
			this.lblAppoitnemtListCriteria.Name = "lblAppoitnemtListCriteria";
			this.lblAppoitnemtListCriteria.Xalign = 0F;
			this.lblAppoitnemtListCriteria.Yalign = 0F;
			this.lblAppoitnemtListCriteria.LabelProp = global::Mono.Unix.Catalog.GetString ("Criteria");
			this.tbAppointmentsList.Add (this.lblAppoitnemtListCriteria);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tbAppointmentsList [this.lblAppoitnemtListCriteria]));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.tbAppointmentsList);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.tbAppointmentsList]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtAppointmentListResult = new global::Gtk.TextView ();
			this.txtAppointmentListResult.CanFocus = true;
			this.txtAppointmentListResult.Name = "txtAppointmentListResult";
			this.GtkScrolledWindow.Add (this.txtAppointmentListResult);
			this.vbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
			w21.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.btnAppointmentsList = new global::Gtk.Button ();
			this.btnAppointmentsList.CanFocus = true;
			this.btnAppointmentsList.Name = "btnAppointmentsList";
			this.btnAppointmentsList.UseUnderline = true;
			this.btnAppointmentsList.Label = global::Mono.Unix.Catalog.GetString ("List");
			this.vbox3.Add (this.btnAppointmentsList);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.btnAppointmentsList]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.nbAppointments.Add (this.vbox3);
			global::Gtk.Notebook.NotebookChild w23 = ((global::Gtk.Notebook.NotebookChild)(this.nbAppointments [this.vbox3]));
			w23.Position = 1;
			// Notebook tab
			this.lblListAppointment = new global::Gtk.Label ();
			this.lblListAppointment.Name = "lblListAppointment";
			this.lblListAppointment.LabelProp = global::Mono.Unix.Catalog.GetString ("List");
			this.nbAppointments.SetTabLabel (this.vbox3, this.lblListAppointment);
			this.lblListAppointment.ShowAll ();
			this.nbMain.Add (this.nbAppointments);
			// Notebook tab
			this.lblAppointments = new global::Gtk.Label ();
			this.lblAppointments.Name = "lblAppointments";
			this.lblAppointments.LabelProp = global::Mono.Unix.Catalog.GetString ("Appointments");
			this.nbMain.SetTabLabel (this.nbAppointments, this.lblAppointments);
			this.lblAppointments.ShowAll ();
			// Container child nbMain.Gtk.Notebook+NotebookChild
			this.nbPatients = new global::Gtk.Notebook ();
			this.nbPatients.CanFocus = true;
			this.nbPatients.Name = "nbPatients";
			this.nbPatients.CurrentPage = 0;
			// Container child nbPatients.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.tblPatientsAdd = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.tblPatientsAdd.Name = "tblPatientsAdd";
			this.tblPatientsAdd.RowSpacing = ((uint)(6));
			this.tblPatientsAdd.ColumnSpacing = ((uint)(6));
			// Container child tblPatientsAdd.Gtk.Table+TableChild
			this.entPatientID = new global::Gtk.Entry ();
			this.entPatientID.CanFocus = true;
			this.entPatientID.Name = "entPatientID";
			this.entPatientID.IsEditable = true;
			this.entPatientID.InvisibleChar = '●';
			this.tblPatientsAdd.Add (this.entPatientID);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.tblPatientsAdd [this.entPatientID]));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsAdd.Gtk.Table+TableChild
			this.entPatientName = new global::Gtk.Entry ();
			this.entPatientName.CanFocus = true;
			this.entPatientName.Name = "entPatientName";
			this.entPatientName.IsEditable = true;
			this.entPatientName.InvisibleChar = '●';
			this.tblPatientsAdd.Add (this.entPatientName);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.tblPatientsAdd [this.entPatientName]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsAdd.Gtk.Table+TableChild
			this.lblPatientAge = new global::Gtk.Label ();
			this.lblPatientAge.Name = "lblPatientAge";
			this.lblPatientAge.Xalign = 0F;
			this.lblPatientAge.Yalign = 0F;
			this.lblPatientAge.LabelProp = global::Mono.Unix.Catalog.GetString ("Age");
			this.tblPatientsAdd.Add (this.lblPatientAge);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.tblPatientsAdd [this.lblPatientAge]));
			w27.TopAttach = ((uint)(2));
			w27.BottomAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsAdd.Gtk.Table+TableChild
			this.lblPatientID = new global::Gtk.Label ();
			this.lblPatientID.Name = "lblPatientID";
			this.lblPatientID.Xalign = 0F;
			this.lblPatientID.Yalign = 0F;
			this.lblPatientID.LabelProp = global::Mono.Unix.Catalog.GetString ("Patient ID");
			this.tblPatientsAdd.Add (this.lblPatientID);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.tblPatientsAdd [this.lblPatientID]));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsAdd.Gtk.Table+TableChild
			this.lblPatientName = new global::Gtk.Label ();
			this.lblPatientName.Name = "lblPatientName";
			this.lblPatientName.Xalign = 0F;
			this.lblPatientName.Yalign = 0F;
			this.lblPatientName.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.tblPatientsAdd.Add (this.lblPatientName);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.tblPatientsAdd [this.lblPatientName]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsAdd.Gtk.Table+TableChild
			this.spnPatientAge = new global::Gtk.SpinButton (0, 100, 1);
			this.spnPatientAge.CanFocus = true;
			this.spnPatientAge.Name = "spnPatientAge";
			this.spnPatientAge.Adjustment.PageIncrement = 10;
			this.spnPatientAge.ClimbRate = 1;
			this.spnPatientAge.Numeric = true;
			this.tblPatientsAdd.Add (this.spnPatientAge);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.tblPatientsAdd [this.spnPatientAge]));
			w30.TopAttach = ((uint)(2));
			w30.BottomAttach = ((uint)(3));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.tblPatientsAdd);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.tblPatientsAdd]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.vbox4.Add (this.fixed2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.fixed2]));
			w32.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.btnPatientAdd = new global::Gtk.Button ();
			this.btnPatientAdd.CanFocus = true;
			this.btnPatientAdd.Name = "btnPatientAdd";
			this.btnPatientAdd.UseUnderline = true;
			this.btnPatientAdd.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbox4.Add (this.btnPatientAdd);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.btnPatientAdd]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			this.nbPatients.Add (this.vbox4);
			// Notebook tab
			this.lblAddPatient = new global::Gtk.Label ();
			this.lblAddPatient.Name = "lblAddPatient";
			this.lblAddPatient.LabelProp = global::Mono.Unix.Catalog.GetString ("Add");
			this.nbPatients.SetTabLabel (this.vbox4, this.lblAddPatient);
			this.lblAddPatient.ShowAll ();
			// Container child nbPatients.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.tblPatientsList = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.tblPatientsList.Name = "tblPatientsList";
			this.tblPatientsList.RowSpacing = ((uint)(6));
			this.tblPatientsList.ColumnSpacing = ((uint)(6));
			// Container child tblPatientsList.Gtk.Table+TableChild
			this.cmbPatientListCriteria = global::Gtk.ComboBox.NewText ();
			this.cmbPatientListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("All"));
			this.cmbPatientListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("ID"));
			this.cmbPatientListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("Over Age X"));
			this.cmbPatientListCriteria.AppendText (global::Mono.Unix.Catalog.GetString ("Under Age X"));
			this.cmbPatientListCriteria.Name = "cmbPatientListCriteria";
			this.cmbPatientListCriteria.Active = 0;
			this.tblPatientsList.Add (this.cmbPatientListCriteria);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.tblPatientsList [this.cmbPatientListCriteria]));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsList.Gtk.Table+TableChild
			this.entPatientListValue = new global::Gtk.Entry ();
			this.entPatientListValue.CanFocus = true;
			this.entPatientListValue.Name = "entPatientListValue";
			this.entPatientListValue.IsEditable = true;
			this.entPatientListValue.InvisibleChar = '●';
			this.tblPatientsList.Add (this.entPatientListValue);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.tblPatientsList [this.entPatientListValue]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.LeftAttach = ((uint)(1));
			w36.RightAttach = ((uint)(2));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsList.Gtk.Table+TableChild
			this.lblPatientListCriteria = new global::Gtk.Label ();
			this.lblPatientListCriteria.Name = "lblPatientListCriteria";
			this.lblPatientListCriteria.Xalign = 0F;
			this.lblPatientListCriteria.Yalign = 0F;
			this.lblPatientListCriteria.LabelProp = global::Mono.Unix.Catalog.GetString ("Criteria");
			this.tblPatientsList.Add (this.lblPatientListCriteria);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.tblPatientsList [this.lblPatientListCriteria]));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblPatientsList.Gtk.Table+TableChild
			this.lblPatientListValue = new global::Gtk.Label ();
			this.lblPatientListValue.Name = "lblPatientListValue";
			this.lblPatientListValue.Xalign = 0F;
			this.lblPatientListValue.Yalign = 0F;
			this.lblPatientListValue.LabelProp = global::Mono.Unix.Catalog.GetString ("Value");
			this.tblPatientsList.Add (this.lblPatientListValue);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.tblPatientsList [this.lblPatientListValue]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add (this.tblPatientsList);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.tblPatientsList]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.txtPatientListResult = new global::Gtk.TextView ();
			this.txtPatientListResult.CanFocus = true;
			this.txtPatientListResult.Name = "txtPatientListResult";
			this.GtkScrolledWindow1.Add (this.txtPatientListResult);
			this.vbox5.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow1]));
			w41.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.btnPatientList = new global::Gtk.Button ();
			this.btnPatientList.CanFocus = true;
			this.btnPatientList.Name = "btnPatientList";
			this.btnPatientList.UseUnderline = true;
			this.btnPatientList.Label = global::Mono.Unix.Catalog.GetString ("List");
			this.vbox5.Add (this.btnPatientList);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.btnPatientList]));
			w42.Position = 2;
			w42.Expand = false;
			w42.Fill = false;
			this.nbPatients.Add (this.vbox5);
			global::Gtk.Notebook.NotebookChild w43 = ((global::Gtk.Notebook.NotebookChild)(this.nbPatients [this.vbox5]));
			w43.Position = 1;
			// Notebook tab
			this.lblListPatient1 = new global::Gtk.Label ();
			this.lblListPatient1.Name = "lblListPatient1";
			this.lblListPatient1.LabelProp = global::Mono.Unix.Catalog.GetString ("List");
			this.nbPatients.SetTabLabel (this.vbox5, this.lblListPatient1);
			this.lblListPatient1.ShowAll ();
			this.nbMain.Add (this.nbPatients);
			global::Gtk.Notebook.NotebookChild w44 = ((global::Gtk.Notebook.NotebookChild)(this.nbMain [this.nbPatients]));
			w44.Position = 1;
			// Notebook tab
			this.lblPatients = new global::Gtk.Label ();
			this.lblPatients.Name = "lblPatients";
			this.lblPatients.LabelProp = global::Mono.Unix.Catalog.GetString ("Patients");
			this.nbMain.SetTabLabel (this.nbPatients, this.lblPatients);
			this.lblPatients.ShowAll ();
			this.Add (this.nbMain);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 519;
			this.DefaultHeight = 481;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnAppointmentAdd.Clicked += new global::System.EventHandler (this.OnBtnAppointmentAddClicked);
			this.btnAppointmentsList.Clicked += new global::System.EventHandler (this.OnBtnAppointmentsListClicked);
			this.btnPatientAdd.Clicked += new global::System.EventHandler (this.OnBtnPatientAddClicked);
			this.btnPatientList.Clicked += new global::System.EventHandler (this.OnBtnPatientListClicked);
		}
	}
}
