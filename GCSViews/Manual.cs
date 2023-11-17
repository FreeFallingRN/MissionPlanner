using DirectShowLib;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;
using MissionPlanner.ArduPilot;
using MissionPlanner.Controls;
using MissionPlanner.GeoRef;
using MissionPlanner.Joystick;
using MissionPlanner.Log;
using MissionPlanner.Maps;
using MissionPlanner.Utilities;
using MissionPlanner.Warnings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dowding.Model;
using Microsoft.Scripting.Utils;
using WebCamService;
using ZedGraph;
using LogAnalyzer = MissionPlanner.Utilities.LogAnalyzer;
using TableLayoutPanelCellPosition = System.Windows.Forms.TableLayoutPanelCellPosition;
using UnauthorizedAccessException = System.UnauthorizedAccessException;
namespace MissionPlanner.GCSViews
{
    public partial class Manual : MyUserControl
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Check, test");
        }
    }
}
