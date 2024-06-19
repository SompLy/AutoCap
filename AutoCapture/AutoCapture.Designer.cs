namespace AutoCapture
{
    partial class AutoCapture
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AutoCapture ) );
            lbl_TimeAlive = new Label();
            lbl_Path = new Label();
            btn_Start = new Button();
            btn_Stop = new Button();
            btn_SetPath = new Button();
            dtp_Minutes = new DateTimePicker();
            timer_Total = new System.Windows.Forms.Timer( components );
            label2 = new Label();
            lbl_NextCapture = new Label();
            timer_NextCapture = new System.Windows.Forms.Timer( components );
            SuspendLayout();
            // 
            // lbl_TimeAlive
            // 
            lbl_TimeAlive.AutoSize = true;
            lbl_TimeAlive.Location = new Point( 93, 16 );
            lbl_TimeAlive.Name = "lbl_TimeAlive";
            lbl_TimeAlive.Size = new Size( 68, 15 );
            lbl_TimeAlive.TabIndex = 0;
            lbl_TimeAlive.Text = "Time Alive :";
            // 
            // lbl_Path
            // 
            lbl_Path.AutoSize = true;
            lbl_Path.Location = new Point( 12, 118 );
            lbl_Path.Name = "lbl_Path";
            lbl_Path.Size = new Size( 37, 15 );
            lbl_Path.TabIndex = 1;
            lbl_Path.Text = "Path :";
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point( 12, 12 );
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size( 75, 23 );
            btn_Start.TabIndex = 2;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Location = new Point( 12, 38 );
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size( 75, 23 );
            btn_Stop.TabIndex = 3;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // btn_SetPath
            // 
            btn_SetPath.Location = new Point( 55, 94 );
            btn_SetPath.Name = "btn_SetPath";
            btn_SetPath.Size = new Size( 75, 23 );
            btn_SetPath.TabIndex = 4;
            btn_SetPath.Text = "Set Path";
            btn_SetPath.UseVisualStyleBackColor = true;
            btn_SetPath.Click += btn_SetPath_Click;
            // 
            // dtp_Minutes
            // 
            dtp_Minutes.CalendarMonthBackground = Color.Yellow;
            dtp_Minutes.CustomFormat = "HH:mm:ss";
            dtp_Minutes.Format = DateTimePickerFormat.Custom;
            dtp_Minutes.Location = new Point( 186, 65 );
            dtp_Minutes.Name = "dtp_Minutes";
            dtp_Minutes.ShowUpDown = true;
            dtp_Minutes.Size = new Size( 66, 23 );
            dtp_Minutes.TabIndex = 24;
            dtp_Minutes.Value = new DateTime( 2024, 3, 2, 0, 0, 0, 0 );
            // 
            // timer_Total
            // 
            timer_Total.Interval = 1000;
            timer_Total.Tick += timer_Total_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point( 93, 69 );
            label2.Name = "label2";
            label2.Size = new Size( 87, 15 );
            label2.TabIndex = 25;
            label2.Text = "Interval ( min ):";
            // 
            // lbl_NextCapture
            // 
            lbl_NextCapture.AutoSize = true;
            lbl_NextCapture.Location = new Point( 93, 42 );
            lbl_NextCapture.Name = "lbl_NextCapture";
            lbl_NextCapture.Size = new Size( 93, 15 );
            lbl_NextCapture.TabIndex = 26;
            lbl_NextCapture.Text = "Next Capture In:";
            // 
            // timer_NextCapture
            // 
            timer_NextCapture.Interval = 1000;
            timer_NextCapture.Tick += timer_NextCapture_Tick;
            // 
            // AutoCapture
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 261, 141 );
            Controls.Add( lbl_NextCapture );
            Controls.Add( label2 );
            Controls.Add( dtp_Minutes );
            Controls.Add( btn_SetPath );
            Controls.Add( btn_Stop );
            Controls.Add( btn_Start );
            Controls.Add( lbl_Path );
            Controls.Add( lbl_TimeAlive );
            Icon = ( Icon ) resources.GetObject( "$this.Icon" ) ;
            Name = "AutoCapture";
            Text = "AutoCap";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label lbl_TimeAlive;
        private Label lbl_Path;
        private Button btn_Start;
        private Button btn_Stop;
        private Button btn_SetPath;
        private DateTimePicker dtp_Minutes;
        private System.Windows.Forms.Timer timer_Total;
        private Label label2;
        private Label lbl_NextCapture;
        private System.Windows.Forms.Timer timer_NextCapture;
    }
}