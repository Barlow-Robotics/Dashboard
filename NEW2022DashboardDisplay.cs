using FRC.NetworkTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using AForge.Video;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;


namespace Dash4572
{
    public partial class DashboardDisplay : Form
    {

        NetworkTableInstance inst;
        TargetData targetData;
        PowercellData powercellData;

        CameraSettings rsSettings;
        GripPipelineSettings gpSettings;

        NetworkTableEntry frameRateEntry;
        NetworkTableEntry loopTimeEntry;
        NetworkTableEntry frameTimeEntry;

        NetworkTableEntry shooterWheelkFEntry;
        NetworkTableEntry shooterWheelkPEntry;
        NetworkTableEntry shooterWheelkIEntry;
        NetworkTableEntry shooterWheelkDEntry;

        NetworkTableEntry indexWheelkFEntry;
        NetworkTableEntry indexWheelkPEntry;
        NetworkTableEntry indexWheelkIEntry;
        NetworkTableEntry indexWheelkDEntry;

        NetworkTableEntry autoAlignKpEntry;
        NetworkTableEntry autoAlignKiEntry;
        NetworkTableEntry autoAlignKdEntry;

        //Series frameTimeSeries;
        //Series loopTimeSeries;


        Bitmap staticBuffer = null;
        MJPEGStream videoStream;
        Bitmap latestFrame = null;
        Bitmap videoStaticBuffer = null;

        Series frameTimeSeries;
        Series loopTimeSeries;

        bool videoStreamStarted = false;


        public DashboardDisplay() {
            InitializeComponent();
            this.Load += Form1_Load;
            //this.drivePanel.Paint += DrivePanel_Paint;
        }

        private void VideoStream_NewFrame(object sender, NewFrameEventArgs eventArgs) {

            try {
                latestFrame = new Bitmap(eventArgs.Frame);
                this.videoPanel.Invalidate();
            } catch (Exception ex) {
                System.Console.WriteLine($"{ex.Message}");
            }

        }

        //private void DrivePanel_Paint(object sender, PaintEventArgs e) {

        //    Graphics g;

        //    if (staticBuffer == null) {
        //        staticBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        //    }

        //    g = Graphics.FromImage(staticBuffer);

        //    int panelWidth = drivePanel.Width;
        //    int panelHeight = drivePanel.Height;
        //    const int botSize = 50;
        //    const int fovMargin = 20;

        //    g.FillRectangle(new SolidBrush(Color.White), drivePanel.DisplayRectangle);


        //    Brush fovBrush = new SolidBrush(Color.LightYellow);
        //    List<Point> rsFOVPoints = new List<Point>();
        //    rsFOVPoints.Add(new Point(0, 0));
        //    rsFOVPoints.Add(new Point(panelWidth / 2, panelHeight - botSize / 2));
        //    rsFOVPoints.Add(new Point(panelWidth, 0));
        //    g.FillPolygon(fovBrush, rsFOVPoints.ToArray());

        //    const int goalHeight = 10;

        //    Pen centerPen = new Pen(Color.Gray, 2);
        //    List<Point> centerLine = new List<Point>();
        //    centerLine.Add(new Point(panelWidth / 2, 0));
        //    centerLine.Add(new Point(panelWidth / 2, panelHeight));

        //    g.DrawLines(centerPen, centerLine.ToArray());

        //    Brush botBrush = new SolidBrush(Color.Black);
        //    g.FillRectangle(botBrush, panelWidth / 2 - botSize / 2, panelHeight - botSize, botSize, botSize);

        //    if (targetData.CanSeeTarget) {
        //        double xval = panelWidth / 2 + (-(targetData.Angle) / 29.0) * panelWidth / 2;
        //        List<Point> goalPoints = new List<Point>();
        //        goalPoints.Add(new Point((int)xval - 20, goalHeight));
        //        goalPoints.Add(new Point((int)xval - 10, goalHeight + 30));
        //        goalPoints.Add(new Point((int)xval + 10, goalHeight + 30));
        //        goalPoints.Add(new Point((int)xval + 20, goalHeight));
        //        Pen goalPen = new Pen(Color.Lime, 10);
        //        g.DrawLines(goalPen, goalPoints.ToArray());

        //    }
        //    if (powercellData.CanSeePowercell) {
        //        Brush powerCell = new SolidBrush(Color.Red);
        //        int ellipseHW = 30;
        //        double ellipseX = panelWidth / 2 - ((powercellData.Angle) / 29.0) * panelWidth / 2;
        //        int ellipseY = 100;
        //        g.FillEllipse(powerCell, (float)ellipseX, ellipseY, ellipseHW, ellipseHW);

        //    }

        //    if (targetData.Angle > -1 && targetData.Angle < 1) {
        //        centerPen = new Pen(Color.Lime, 3);
        //    } else {
        //        centerPen = new Pen(Color.Gray, 2);
        //    }

        //    e.Graphics.DrawImageUnscaled(staticBuffer, 0, 0);

        //}

        private void Form1_Load(object sender, EventArgs e) {
            targetData = new TargetData(inst);
            powercellData = new PowercellData(inst);

            targetData = new TargetData(inst);
            powercellData = new PowercellData(inst);

            this.frameRateEntry = inst.GetTable("real_sense").GetEntry("frameRate");

            this.loopTimeEntry = inst.GetTable("performance").GetEntry("loopTime");
            this.frameTimeEntry = inst.GetTable("performance").GetEntry("frameTime");

            rsSettings = new CameraSettings(inst, "real_sense");
            gpSettings = new GripPipelineSettings(inst, "target_pipeline");

            shooterWheelkFEntry = inst.GetTable("shooter").GetEntry("kF_Shooter");
            shooterWheelkPEntry = inst.GetTable("shooter").GetEntry("kP_Shooter");
            shooterWheelkIEntry = inst.GetTable("shooter").GetEntry("kI_Shooter");
            shooterWheelkDEntry = inst.GetTable("shooter").GetEntry("kD_Shooter");

            indexWheelkFEntry = inst.GetTable("shooter").GetEntry("kF_Index");
            indexWheelkPEntry = inst.GetTable("shooter").GetEntry("kP_Index");
            indexWheelkIEntry = inst.GetTable("shooter").GetEntry("kI_Index");
            indexWheelkDEntry = inst.GetTable("shooter").GetEntry("kD_Index");

            autoAlignKpEntry = inst.GetTable("shooter").GetEntry("kF_Index");
            autoAlignKiEntry = inst.GetTable("shooter").GetEntry("kF_Index");
            autoAlignKdEntry = inst.GetTable("shooter").GetEntry("kF_Index");

            this.autoExposureCheckBox.CheckedChanged += AutoExposureCheckBox_CheckedChanged;
            this.brightnessUpDown.ValueChanged += BrightnessUpDown_ValueChanged;
            this.contrastUpDown.ValueChanged += ContrastUpDown_ValueChanged;
            this.exposureUpDown.ValueChanged += ExposureUpDown_ValueChanged;
            this.gammaUpDown.ValueChanged += GammaUpDown_ValueChanged;
            this.saturationUpDown.ValueChanged += SaturationUpDown_ValueChanged;

            this.hueLowerUpDown.ValueChanged += HueLowerUpDown_ValueChanged;
            this.hueUpperUpDown.ValueChanged += HueUpperUpDown_ValueChanged;
            this.saturationLowerUpDown.ValueChanged += SaturationLowerUpDown_ValueChanged;
            this.saturationUpperUpDown.ValueChanged += SaturationUpperUpDown_ValueChanged;
            this.luminocityLowerUpDown.ValueChanged += LuminocityLowerUpDown_ValueChanged;
            this.luminocityUpperUpDown.ValueChanged += LuminocityUpperUpDown_ValueChanged;


            bool valuesReceived = false;
            while (!valuesReceived) {
                try {
                    this.autoExposureCheckBox.Checked = rsSettings.AutoExposure;
                    this.brightnessUpDown.Value = (int)rsSettings.Brightness;
                    this.contrastUpDown.Value = (int)rsSettings.Contrast;
                    this.exposureUpDown.Value = (int)rsSettings.Exposure;
                    this.gammaUpDown.Value = (int)rsSettings.Gamma;
                    this.saturationUpDown.Value = (int)rsSettings.Saturation;

                    this.hueLowerUpDown.Value = (int)gpSettings.HueLower;
                    this.hueUpperUpDown.Value = (int)gpSettings.HueUpper;
                    this.saturationLowerUpDown.Value = (int)gpSettings.SaturationLower;
                    this.saturationUpperUpDown.Value = (int)gpSettings.SaturationUpper;
                    this.luminocityLowerUpDown.Value = (int)gpSettings.LuminocityLower;
                    this.luminocityUpperUpDown.Value = (int)gpSettings.LuminocityUpper;

                    valuesReceived = true;
                } catch (Exception ex) {
                    int wpk = 1;
                }
            }

            frameTimeSeries = this.roboRioProcessingChart.Series["Frame Time"];
            loopTimeSeries = this.roboRioProcessingChart.Series["Loop Time"];
            for (int i = 0; i < 500; i++) {
                frameTimeSeries.Points.AddXY(i + 1, 0);
                loopTimeSeries.Points.AddXY(i + 1, 0);
            }


            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces()) {
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses) {
                    if (addr.Address.ToString().Contains("10.45.72")) {
                        inst.GetTable("performance").GetEntry("IP_Address").SetString(addr.Address.ToString());
                    }
                }
            }
            Timer timer = new Timer();
            timer.Interval = (33); // mSecs
            timer.Tick += Timer_Tick;
            ;
            timer.Start();
        }





        private void LuminocityUpperUpDown_ValueChanged(object sender, EventArgs e) {
            gpSettings.LuminocityUpper = (double)luminocityUpperUpDown.Value;
        }

        private void LuminocityLowerUpDown_ValueChanged(object sender, EventArgs e) {
            gpSettings.LuminocityLower = (double)luminocityLowerUpDown.Value;
        }

        private void SaturationUpperUpDown_ValueChanged(object sender, EventArgs e) {
            gpSettings.SaturationUpper = (double)saturationUpperUpDown.Value;
        }

        private void SaturationLowerUpDown_ValueChanged(object sender, EventArgs e) {
            gpSettings.SaturationLower = (double)saturationLowerUpDown.Value;
        }

        private void HueUpperUpDown_ValueChanged(object sender, EventArgs e) {
            gpSettings.HueUpper = (double)hueUpperUpDown.Value;
        }

        private void HueLowerUpDown_ValueChanged(object sender, EventArgs e) {
            gpSettings.HueLower = (double)hueLowerUpDown.Value;
        }



        private void AutoExposureCheckBox_CheckedChanged(object sender, EventArgs e) {
            rsSettings.AutoExposure = this.autoExposureCheckBox.Checked;
        }

        private void SaturationUpDown_ValueChanged(object sender, EventArgs e) {
            rsSettings.Saturation = (double)saturationUpDown.Value;
        }

        private void GammaUpDown_ValueChanged(object sender, EventArgs e) {
            rsSettings.Gamma = (double)gammaUpDown.Value;
        }

        private void ExposureUpDown_ValueChanged(object sender, EventArgs e) {
            rsSettings.Exposure = (double)exposureUpDown.Value;
        }

        private void ContrastUpDown_ValueChanged(object sender, EventArgs e) {
            rsSettings.Contrast = (double)contrastUpDown.Value;
        }

        private void BrightnessUpDown_ValueChanged(object sender, EventArgs e) {
            rsSettings.Brightness = (double)brightnessUpDown.Value;
        }




        private void Timer_Tick(object sender, EventArgs e) {
            try {
                string distanceInFeet = String.Format("{0:F2}", (targetData.Distance / 1000) * 3.281);
                distanceToTargetTextBox.Text = distanceInFeet;

                string angleInDegrees = String.Format("{0:F3}", targetData.Angle);
                angleToTargetTextBox.Text = angleInDegrees;

                frameRateTextBox.Text = frameRateEntry.GetDouble(0.0).ToString();
                this.brightnessUpDown.Value = (decimal)rsSettings.Brightness;
                this.contrastUpDown.Value = (decimal)rsSettings.Contrast;
                this.exposureUpDown.Value = (decimal)rsSettings.Exposure;
                this.gammaUpDown.Value = (decimal)rsSettings.Gamma;
                this.saturationUpDown.Value = (decimal)rsSettings.Saturation;

                DataPoint lastPoint = frameTimeSeries.Points.Last();
                frameTimeSeries.Points.AddXY(lastPoint.XValue + 1, frameTimeEntry.GetDouble(0.0));
                frameTimeSeries.Points.RemoveAt(0);

                DataPoint lastLoopTimePoint = loopTimeSeries.Points.Last();
                loopTimeSeries.Points.AddXY(lastPoint.XValue + 1, loopTimeEntry.GetDouble(0.0));
                loopTimeSeries.Points.RemoveAt(0);

                this.roboRioProcessingChart.ChartAreas[0].RecalculateAxesScale();

                if (!videoStreamStarted) {
                    string ip = this.inst.GetEntry("real_sense/server_ip").GetString("none");
                    if (ip != "none") {
                        videoStream = new MJPEGStream($"http://{ip}:1180");
                        videoStream.NewFrame += VideoStream_NewFrame;
                        videoStream.Start();
                        videoStreamStarted = true;
                    }
                }

                //this.drivePanel.Invalidate();
                this.Invalidate();

            } catch {

            }
        }

        public NetworkTableInstance NTINstance {
            get { return inst; }
            set { inst = value; }
        }

        private void videoPanel_Paint(object sender, PaintEventArgs e) {
            Graphics g;
            if (videoStaticBuffer == null) {
                //staticBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
                videoStaticBuffer = new Bitmap(this.videoPanel.Width, this.videoPanel.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            g = Graphics.FromImage(videoStaticBuffer);
            if (latestFrame != null) {
                g.DrawImage(latestFrame, 0, 0);
            }
            e.Graphics.DrawImageUnscaled(videoStaticBuffer, 0, 0);

        }

        private void DashboardDisplay_FormClosing(object sender, FormClosingEventArgs e) {
            this.videoStream.Stop();
        }
    }
}

