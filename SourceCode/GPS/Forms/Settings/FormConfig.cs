﻿//Please, if you use this, share the improvements

using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormConfig : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        //constructor
        public FormConfig(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            InitializeComponent();
            //Ajout-modification MEmprou et SPailleau
            //tSum
            chkSky.Text = gStr.gsSky;
            label27.Text = gStr.gsAutoDayNight;
            label31.Text = gStr.gsLightbar;
            label43.Text = gStr.gsPolygon;
            chkGrid.Text = gStr.gsGrid;
            label28.Text = gStr.gsStartFullscreen;
            label33.Text = gStr.gsKeyboard;
            label36.Text = gStr.gsLogNMEA;
            chkSpeedo.Text = gStr.gsSpeedo;
            chkExtraGuides.Text = gStr.gsExtraGuides;
            label101.Text = gStr.gsFloorTexture;
            label102.Text = gStr.gsSectionsButtons;
            label13.Text = gStr.gsLoad;
            label42.Text = gStr.gsSaveAs;
            label57.Text = gStr.gsDelete;
            label3.Text = gStr.gsSaveNewVehicle;
            lblCurrentVehicle.Text = gStr.gsCurrentVehicle;
            label22.Text = gStr.gsUnits;
            label52.Text = gStr.gsToolWidth;
            ArrowsRL.Text = gStr.gsArrowsRL;

            //tConfig
            groupBox1.Text = gStr.gsVehicleType;
            label44.Text = gStr.gsWheelbase;
            label53.Text = gStr.gsTrack;
            label60.Text = gStr.gsTurnRadius;

            //tHitch
            gboxAttachment.Text = gStr.gsAttachmentStyle;
            label49.Text = gStr.gsSectionWidth;
            label51.Text = gStr.gsNbOfSections; //#
            label50.Text = gStr.gsCoverage; //%

            //tSwit
            groupBox3.Text = gStr.gsWorkSwitch;
            chkEnableWorkSwitch.Text = gStr.gsEnableWorkSwitch;
            chkWorkSwActiveLow.Text = gStr.gsWorkSwActiveLow;
            checkWorkSwitchManual.Text = gStr.gsWorkSwitchControlsManual;

            //TSettings
            label16.Text = gStr.gsOnSecs; // On (secs)
            label14.Text = gStr.gsOffSecs;
            label10.Text = gStr.gsDelaySecs;
            label65.Text = gStr.gsOffset;
            label66.Text = gStr.gsOverlap_Gap;

            //dHead
            headingGroupBox.Text = gStr.gsAntennaType;
            label2.Text = gStr.gsAlarm;
            gboxSingle.Text = gStr.gsSingleAntennaSettings;
            label15.Text = gStr.gsFixTrigger;
            label8.Text = gStr.gsDistance; //(m)
            label9.Text = gStr.gsStartSpeed; //(kmh)

            //dRoll
            label76.Text = gStr.gsRemoveOffset;
            label77.Text = gStr.gsZeroRoll;
            label78.Text = gStr.gsInvertRoll;
            label18.Text = gStr.gsRollFilter;

            //aSteer
            label5.Text = gStr.gsInvertWAS;
            label70.Text = gStr.gsInvertMotorDir;
            label7.Text = gStr.gsInvertRelays;
            labelEncoder.Text = gStr.gsTurnSensor;
            labelPressureTurnSensor.Text = gStr.gsPressureTurnSensor;
            labelCurrentTurnSensor.Text = gStr.gsCurrentTurnSensor;
            label61.Text = gStr.gsTurnSensor;
            label68.Text = gStr.gsSendSave; //+

            //aMach
            label56.Text = gStr.gsMachineModule;
            groupBox4.Text = gStr.gsHydraulicLiftConfig;
            label25.Text = gStr.gsEnable;
            label74.Text = gStr.gsRaiseTime; //(secs)
            label69.Text = gStr.gsHydraulicLiftLookAhead; // (secs)
            label73.Text = gStr.gsLowerTime; //(secs)
            label72.Text = gStr.gsInvertRelays;
            label67.Text = gStr.gsSendSave; //+

            //tTram
            groupBox2.Text = gStr.gsTramType; //+
            label75.Text = gStr.gsTramWidth; //+

            //fin

            tab1.Appearance = TabAppearance.FlatButtons;
            tab1.ItemSize = new Size(0, 1);
            tab1.SizeMode = TabSizeMode.Fixed;

            HideSubMenu();

            nudTrailingHitchLength.Controls[0].Enabled = false;
            nudDrawbarLength.Controls[0].Enabled = false;
            nudTankHitch.Controls[0].Enabled = false;


            nudLookAhead.Controls[0].Enabled = false;
            nudLookAheadOff.Controls[0].Enabled = false;
            nudTurnOffDelay.Controls[0].Enabled = false;
            nudOffset.Controls[0].Enabled = false;
            nudOverlap.Controls[0].Enabled = false;
            nudCutoffSpeed.Controls[0].Enabled = false;


            nudMinTurnRadius.Controls[0].Enabled = false;
            nudAntennaHeight.Controls[0].Enabled = false;
            nudAntennaOffset.Controls[0].Enabled = false;
            nudAntennaPivot.Controls[0].Enabled = false;
            nudLightbarCmPerPixel.Controls[0].Enabled = false;
            nudVehicleTrack.Controls[0].Enabled = false;
            nudSnapDistance.Controls[0].Enabled = false;
            nudABLength.Controls[0].Enabled = false;
            nudWheelbase.Controls[0].Enabled = false;
            nudLineWidth.Controls[0].Enabled = false;

            nudMinCoverage.Controls[0].Enabled = false;
            nudDefaultSectionWidth.Controls[0].Enabled = false;

            nudSection1.Controls[0].Enabled = false;
            nudSection2.Controls[0].Enabled = false;
            nudSection3.Controls[0].Enabled = false;
            nudSection4.Controls[0].Enabled = false;
            nudSection5.Controls[0].Enabled = false;
            nudSection6.Controls[0].Enabled = false;
            nudSection7.Controls[0].Enabled = false;
            nudSection8.Controls[0].Enabled = false;
            nudSection9.Controls[0].Enabled = false;
            nudSection10.Controls[0].Enabled = false;
            nudSection11.Controls[0].Enabled = false;
            nudSection12.Controls[0].Enabled = false;
            nudSection13.Controls[0].Enabled = false;
            nudSection14.Controls[0].Enabled = false;
            nudSection15.Controls[0].Enabled = false;
            nudSection16.Controls[0].Enabled = false;

            nudMinFixStepDistance.Controls[0].Enabled = false;
            nudStartSpeed.Controls[0].Enabled = false;

            nudForwardComp.Controls[0].Enabled = false;
            nudReverseComp.Controls[0].Enabled = false;

            nudAgeAlarm.Controls[0].Enabled = false;

            nudMaxCounts.Controls[0].Enabled = false;
            nudRaiseTime.Controls[0].Enabled = false;
            nudLowerTime.Controls[0].Enabled = false;

            nudTramWidth.Controls[0].Enabled = false;
            nudMenusOnTime.Controls[0].Enabled = false;

            nudGuidanceLookAhead.Controls[0].Enabled = false;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            //Ajout-modification MEmprou et SPailleau
            if (mf.config_tool == true)
            {
                btnFeatureHides.Visible = false;
                btnTram.Visible = false;
                btnMachineModule.Visible = false;
                btnSteerModule.Visible = false;
                btnArduino.Visible = false;
                btnUTurn.Visible = false;
                btnDataSources.Visible = false;
                btnSubGuidance.Visible = false;
                btnSubAntenna.Visible = false;
                btnSubDimensions.Visible = false;
                btnSubVehicleConfig.Visible = false;
                btnVehicle.Visible = false;
                ShowSubMenu(panelToolSubMenu, btnTool);
                lvVehicles.Location = new Point(8, 11);
                lvVehicles.Height = 522;
                unitsGroupBox.Visible = false;
                label43.Visible = false;
                label36.Visible = false;
                label103.Visible = false;
                cbox_long_touch.Visible = false;
                cBox_sections_button.Visible = false;
                ArrowsRL.Visible = false;
                chkDisplayPolygons.Visible = false;
                chkDisplayLogNMEA.Visible = false;

            }
            else
            {
                btnFeatureHides.Visible = true;
                btnTram.Visible = true;
                btnMachineModule.Visible = true;
                btnSteerModule.Visible = true;
                btnArduino.Visible = true;
                btnUTurn.Visible = true;
                btnDataSources.Visible = true;
                btnSubGuidance.Visible = true;
                btnSubAntenna.Visible = true;
                btnSubDimensions.Visible = true;
                btnSubVehicleConfig.Visible = true;
                btnVehicle.Visible = true;
            }
            //fin
            //seince we rest, save current state
            mf.SaveFormGPSWindowSettings();

            if (mf.isMetric)
            {
                lblInchesCm.Text = gStr.gsCentimeters;
                lblFeetMeters.Text = gStr.gsMeters;
                lblSecTotalWidthFeet.Visible = false;
                lblSecTotalWidthInches.Visible = false;
                lblSecTotalWidthMeters.Visible = true;
            }
            else
            {
                lblInchesCm.Text = gStr.gsInches;
                lblFeetMeters.Text = "Feet";
                lblSecTotalWidthFeet.Visible = true;
                lblSecTotalWidthInches.Visible = true;
                lblSecTotalWidthMeters.Visible = false;
            }

            //update the first child form summary data items
            UpdateSummary();

            //metric or imp on spinners min/maxes
            FixMinMaxSpinners();

            //the pick a saved vehicle box
            UpdateVehicleListView();

            //the tool size in bottom panel
            if (mf.isMetric)
            {
                lblSecTotalWidthMeters.Text = (mf.tool.toolWidth * 100) + " cm";
            }
            else
            {
                double toFeet = mf.tool.toolWidth * 100 * 0.0328084;
                lblSecTotalWidthFeet.Text = Convert.ToString((int)toFeet) + "'";
                double temp = Math.Round((toFeet - Math.Truncate(toFeet)) * 12, 0);
                lblSecTotalWidthInches.Text = Convert.ToString(temp) + '"';
            }

            chkDisplaySky.Checked = mf.isSkyOn;
            chkDisplayFloor.Checked = mf.isTextureOn;
            chkDisplayGrid.Checked = mf.isGridOn;
            chkDisplaySpeedo.Checked = mf.isSpeedoOn;
            chkDisplayDayNight.Checked = mf.isAutoDayNight;
            chkDisplayStartFullScreen.Checked = Properties.Settings.Default.setDisplay_isStartFullScreen;
            chkDisplayExtraGuides.Checked = mf.isSideGuideLines;
            chkDisplayLogNMEA.Checked = mf.isLogNMEA;
            chkDisplayPolygons.Checked = mf.isDrawPolygons;
            chkDisplayLightbar.Checked = mf.isLightbarOn;
            chkDisplayKeyboard.Checked = mf.isKeyboardOn;

            //Ajout-modification MEmprou et SPailleau
            cBox_sections_button.Checked = mf.issections_buttonOn;
            cbox_long_touch.Checked = mf.islong_touchOn;
            cboxroll.Checked = Properties.Vehicle.Default.SetRollOFF;
            ArrowsRL.Checked = Properties.Vehicle.Default.SetArrowsRL;
            //fin

            if (mf.isMetric) rbtnDisplayMetric.Checked = true;
            else rbtnDisplayImperial.Checked = true;

            //nudMenusOnTime.Value = mf.timeToShowMenus;

            tab1.SelectedTab = tabSummary;
            tboxVehicleNameSave.Focus();

            mf.CloseTopMosts();

        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDisplaySettings();

            //reload all the settings from default and user.config
            mf.LoadSettings();

            //save current vehicle
            SettingsIO.ExportAll(mf.vehiclesDirectory + mf.vehicleFileName + ".XML");

        }

        private void FixMinMaxSpinners()
        {
            if (!mf.isMetric)
            {
                nudTankHitch.Maximum = (Math.Round(nudTankHitch.Maximum / 2.54M));
                nudTankHitch.Minimum = Math.Round(nudTankHitch.Minimum / 2.54M);

                nudDrawbarLength.Maximum = Math.Round(nudDrawbarLength.Maximum / 2.54M);
                nudDrawbarLength.Minimum = Math.Round(nudDrawbarLength.Minimum / 2.54M);

                nudTrailingHitchLength.Maximum = Math.Round(nudTrailingHitchLength.Maximum / 2.54M);
                nudTrailingHitchLength.Minimum = Math.Round(nudTrailingHitchLength.Minimum / 2.54M);

                nudSnapDistance.Maximum = Math.Round(nudSnapDistance.Maximum / 2.54M);
                nudSnapDistance.Minimum = Math.Round(nudSnapDistance.Minimum / 2.54M);

                nudLightbarCmPerPixel.Maximum = Math.Round(nudLightbarCmPerPixel.Maximum / 2.54M);
                nudLightbarCmPerPixel.Minimum = Math.Round(nudLightbarCmPerPixel.Minimum / 2.54M);

                nudVehicleTrack.Maximum = Math.Round(nudVehicleTrack.Maximum / 2.54M);
                nudVehicleTrack.Minimum = Math.Round(nudVehicleTrack.Minimum / 2.54M);

                nudWheelbase.Maximum = Math.Round(nudWheelbase.Maximum / 2.54M);
                nudWheelbase.Minimum = Math.Round(nudWheelbase.Minimum / 2.54M);

                nudMinTurnRadius.Maximum = Math.Round(nudMinTurnRadius.Maximum / 2.54M);
                nudMinTurnRadius.Minimum = Math.Round(nudMinTurnRadius.Minimum / 2.54M);

                //.Maximum = Math.Round(/2.54M);
                //.Minimum = Math.Round(/2.54M);

                nudOverlap.Maximum = Math.Round(nudOverlap.Maximum / 2.54M);
                nudOverlap.Minimum = Math.Round(nudOverlap.Minimum / 2.54M);

                nudOffset.Maximum = Math.Round(nudOffset.Maximum / 2.54M);
                nudOffset.Minimum = Math.Round(nudOffset.Minimum / 2.54M);

                nudCutoffSpeed.Maximum = Math.Round(nudCutoffSpeed.Maximum / 1.60934M);
                nudCutoffSpeed.Minimum = Math.Round(nudCutoffSpeed.Minimum / 1.60934M);

                nudDefaultSectionWidth.Maximum = Math.Round(nudDefaultSectionWidth.Maximum / 2.54M);
                nudDefaultSectionWidth.Minimum = Math.Round(nudDefaultSectionWidth.Minimum / 2.54M);

                nudSection1.Maximum = Math.Round(nudSection1.Maximum / 2.54M);
                nudSection1.Minimum = Math.Round(nudSection1.Minimum / 2.54M);
                nudSection2.Maximum = Math.Round(nudSection2.Maximum / 2.54M);
                nudSection2.Minimum = Math.Round(nudSection2.Minimum / 2.54M);
                nudSection3.Maximum = Math.Round(nudSection3.Maximum / 2.54M);
                nudSection3.Minimum = Math.Round(nudSection3.Minimum / 2.54M);
                nudSection4.Maximum = Math.Round(nudSection4.Maximum / 2.54M);
                nudSection4.Minimum = Math.Round(nudSection4.Minimum / 2.54M);
                nudSection5.Maximum = Math.Round(nudSection5.Maximum / 2.54M);
                nudSection5.Minimum = Math.Round(nudSection5.Minimum / 2.54M);
                nudSection6.Maximum = Math.Round(nudSection6.Maximum / 2.54M);
                nudSection6.Minimum = Math.Round(nudSection6.Minimum / 2.54M);
                nudSection7.Maximum = Math.Round(nudSection7.Maximum / 2.54M);
                nudSection7.Minimum = Math.Round(nudSection7.Minimum / 2.54M);
                nudSection8.Maximum = Math.Round(nudSection8.Maximum / 2.54M);
                nudSection8.Minimum = Math.Round(nudSection8.Minimum / 2.54M);
                nudSection9.Maximum = Math.Round(nudSection9.Maximum / 2.54M);
                nudSection9.Minimum = Math.Round(nudSection9.Minimum / 2.54M);
                nudSection10.Maximum = Math.Round(nudSection10.Maximum / 2.54M);
                nudSection10.Minimum = Math.Round(nudSection10.Minimum / 2.54M);
                nudSection11.Maximum = Math.Round(nudSection11.Maximum / 2.54M);
                nudSection11.Minimum = Math.Round(nudSection11.Minimum / 2.54M);
                nudSection12.Maximum = Math.Round(nudSection12.Maximum / 2.54M);
                nudSection12.Minimum = Math.Round(nudSection12.Minimum / 2.54M);
                nudSection13.Maximum = Math.Round(nudSection13.Maximum / 2.54M);
                nudSection13.Minimum = Math.Round(nudSection13.Minimum / 2.54M);
                nudSection14.Maximum = Math.Round(nudSection14.Maximum / 2.54M);
                nudSection14.Minimum = Math.Round(nudSection14.Minimum / 2.54M);
                nudSection15.Maximum = Math.Round(nudSection15.Maximum / 2.54M);
                nudSection15.Minimum = Math.Round(nudSection15.Minimum / 2.54M);
                nudSection16.Maximum = Math.Round(nudSection16.Maximum / 2.54M);
                nudSection16.Minimum = Math.Round(nudSection16.Minimum / 2.54M);

                nudTramWidth.Minimum = Math.Round(nudTramWidth.Minimum / 2.54M);
                nudTramWidth.Maximum = Math.Round(nudTramWidth.Maximum / 2.54M);

                nudSnapDistance.Minimum = Math.Round(nudSnapDistance.Minimum / 2.54M);
                nudSnapDistance.Maximum = Math.Round(nudSnapDistance.Maximum / 2.54M);

                nudLightbarCmPerPixel.Minimum = Math.Round(nudLightbarCmPerPixel.Minimum / 2.54M);
                nudLightbarCmPerPixel.Maximum = Math.Round(nudLightbarCmPerPixel.Maximum / 2.54M);

                //Meters to feet
                nudTurnDistanceFromBoundary.Minimum = Math.Round(nudTurnDistanceFromBoundary.Minimum * 3.28M);
                nudTurnDistanceFromBoundary.Maximum = Math.Round(nudTurnDistanceFromBoundary.Maximum * 3.28M);

                nudABLength.Minimum = Math.Round(nudABLength.Minimum * 3.28M);
                nudABLength.Maximum = Math.Round(nudABLength.Maximum * 3.28M);

                lblTurnOffBelowUnits.Text = gStr.gsMPH;
                //cutoffMetricImperial = 1.60934;

            }
            else
            {
                lblTurnOffBelowUnits.Text = gStr.gsKMH;
                //cutoffMetricImperial = 1;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabSummary_Enter(object sender, EventArgs e)
        {
            chkDisplaySky.Checked = mf.isSkyOn;
            chkDisplayFloor.Checked = mf.isTextureOn;
            chkDisplayGrid.Checked = mf.isGridOn;
            chkDisplaySpeedo.Checked = mf.isSpeedoOn;
            chkDisplayDayNight.Checked = mf.isAutoDayNight;
            chkDisplayStartFullScreen.Checked = Properties.Settings.Default.setDisplay_isStartFullScreen;
            chkDisplayExtraGuides.Checked = mf.isSideGuideLines;
            chkDisplayLogNMEA.Checked = mf.isLogNMEA;
            chkDisplayPolygons.Checked = mf.isDrawPolygons;
            chkDisplayLightbar.Checked = mf.isLightbarOn;
            chkDisplayKeyboard.Checked = mf.isKeyboardOn;
            //nudMenusOnTime.Value = mf.timeToShowMenus;
            //Ajout-modification MEmprou et SPailleau
            cBox_sections_button.Checked = mf.issections_buttonOn;
            cbox_long_touch.Checked = Properties.Settings.Default.setDisplay_islong_touchOn;
            cboxroll.Checked = Properties.Vehicle.Default.SetRollOFF;
            ArrowsRL.Checked = Properties.Vehicle.Default.SetArrowsRL;
            //fin

            if (mf.isMetric) rbtnDisplayMetric.Checked = true;
            else rbtnDisplayImperial.Checked = true;
        }

        private void tabSummary_Leave(object sender, EventArgs e)
        {
            SaveDisplaySettings();
        }

        private void cBox_sections_button_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Ajout-modification MEmprou et SPailleau
        private void cbox_long_touch_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_islong_touchOn = cbox_long_touch.Checked;
            mf.long_touch();
        }
        //fin
    }
}

