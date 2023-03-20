#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Windows.Markup;
using System.Windows.Media;
using adWin = Autodesk.Windows;

#endregion

namespace RAA2_Module_04_OfficeHours
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            // 1. Create ribbon tab
            try
            {
                app.CreateRibbonTab("Revit Add-in Academy");
            }
            catch (Exception)
            {
                Debug.Print("Tab already exists.");
            }

            // 2. Create ribbon panel 
            RibbonPanel panel = Utils.CreateRibbonPanel(app, "Revit Add-in Academy", "Revit Tools");

            // 3. Create button data instances
            ButtonDataClass myButtonData = new ButtonDataClass("btnRAA2_Module_04_OfficeHours", "My Button", Command.GetMethod(), Properties.Resources.Blue_32, Properties.Resources.Blue_16, "This is a tooltip");

            // 4. Create buttons
            PushButton myButton = panel.AddItem(myButtonData.Data) as PushButton;

            //adWin.RibbonControl ribbon = adWin.ComponentManager.Ribbon;

            //LinearGradientBrush gB = new LinearGradientBrush();
            //gB.StartPoint = new System.Windows.Point(0, 0);
            //gB.EndPoint = new System.Windows.Point(0, 1);
            //gB.GradientStops.Add(new GradientStop(Colors.Orange, 0.0));
            //gB.GradientStops.Add(new GradientStop(Colors.Orange, 1));

            //LinearGradientBrush gB2 = new LinearGradientBrush();
            //gB.StartPoint = new System.Windows.Point(0, 0);
            //gB.EndPoint = new System.Windows.Point(0, 1);
            //gB.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));
            //gB.GradientStops.Add(new GradientStop(Colors.Blue, 1));

            //LinearGradientBrush gB3 = new LinearGradientBrush();
            //gB.StartPoint = new System.Windows.Point(0, 0);
            //gB.EndPoint = new System.Windows.Point(0, 1);
            //gB.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
            //gB.GradientStops.Add(new GradientStop(Colors.Red, 1));

            //Autodesk.Internal.Windows.TabTheme myTheme = new Autodesk.Internal.Windows.TabTheme();
            //myTheme.PanelBackground = gB;
            //myTheme.TabHeaderBackground = gB;
            //myTheme.TabHeaderForeground = gB;

            //myTheme.PanelContentBackground = gB2;
            //ribbon.FindTab("Revit Add-in Academy").Theme = myTheme;

            //foreach (adWin.RibbonTab tab in ribbon.Tabs)
            //{
            //    foreach (adWin.RibbonPanel tpanel in tab.Panels)
            //    {
            //        if (tpanel != null)
            //        {
            //            tpanel.CustomPanelTitleBarBackground = gB3;
            //        }
            //    }
            //}

            adWin.RibbonControl ribbon = adWin.ComponentManager.Ribbon;

            LinearGradientBrush gradientBrush = new LinearGradientBrush();

            gradientBrush.StartPoint
              = new System.Windows.Point(0, 0);

            gradientBrush.EndPoint
              = new System.Windows.Point(0, 1);

            gradientBrush.GradientStops.Add(
              new GradientStop(Colors.White, 0.0));

            gradientBrush.GradientStops.Add(
              new GradientStop(Colors.Blue, 1));

            // change the tab header font

            ribbon.FontFamily = new System.Windows.Media
              .FontFamily("Arial");

            ribbon.FontSize = 10;
            foreach (adWin.RibbonTab tab in ribbon.Tabs)
            {
                if(tab.Name == "Add-Ins")
                {
                    foreach (adWin.RibbonPanel panel2 in tab.Panels)
                    {
                        panel2.CustomPanelTitleBarBackground
                          = gradientBrush;

                        //panel.CustomPanelBackground 
                        //  = gradientBrush; // use your gradient fill
                    }
                }
                
            }


            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }


    }
}
