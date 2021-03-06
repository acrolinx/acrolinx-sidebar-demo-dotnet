﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acrolinx.Demo.Sidebar.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Topspin 360 Quick Start\r\n\r\nThis document will describe the basic steps required t" +
            "o install and configure the Topspin 360 system.\r\nRequirements\r\nTo install the To" +
            "pspin 360 into a rack, you require the following:\r\n\r\n - one #1 and one #2 Philli" +
            "ps-head screwdriver for fitting\r\n - one managment workstation, such as a PC runn" +
            "ing terminal-emulation software\r\n - the chasis cable kit (included)\r\n - two peop" +
            "le to safely lift the unit into the rack\r\n- TEST_CONTAINER\r\n\r\nTopspin 360 Packag" +
            "e Contents\r\n\r\nYou will find the following items in your Topspin package:\r\n\r\n - 1" +
            " Topspin 360 Server Switch\r\n - 1 or 2 12-port InfiniBand switch blades\r\n - 1 or " +
            "2 power supplies\r\n - 1 or 2 fan trays \r\n - 1 or 2 system controllers \r\n - 2 rack" +
            "-mount brackets and mounting screws\r\n - 1 power-supply blanking panel\r\n - 1 expa" +
            "nsion card blanking panel\r\n - 1 console-cable kit, which includes a DB-9 M/F ser" +
            "ial cable\r\n - 1 or 2 6-foot (1.8-meter) AC power cables\r\n - 1 CD-ROM containing " +
            "software and user documentation\r\n - 1 Quick Start Guide\r\n - 1 warranty card\r\n\r\nP" +
            "reparing the Site\r\n\r\nTo prepare the site for the Topspin 360, perform the follow" +
            "ing steps:\r\n\r\n1.\tRead the cautionary statements in \"Safety Information\" on page " +
            "5.\r\n2.\tFill the Topspin registration form out online. Go to http://www.topspin.c" +
            "om/support/prodreg.cfm.\r\n3.\tVerify that the rack environment provides sufficient" +
            " ventilation. \r\n4.\tUnpack the Topspin 360 package.\r\n5.\tVerify that you have all " +
            "of the items on the Requirements list. Refer to \"Requirements\" on page 1.\r\n\r\nIns" +
            "tall Topspin 360 FRUs\r\n\r\nInstall gateways and switch cards to increase the port " +
            "count of your switch.\r\nNote: whenever possible install all FRUs before you rack " +
            "your Topspin 360. You can continue to add or replace FRUs after you rack your de" +
            "vice.\r\n\r\nTo install field replaceable units (FRUs), perform the following steps:" +
            "\r\n\r\n1.\tInstall any expansion modules (Fibre Channel gateways or Ethernet gateway" +
            "s):\r\na.\tRemove any filler panels from slots that will have a card installed. Beg" +
            "in by filling the first gateway slot (slot 2).\r\nb.\tInstall Ethernet and/or Fibre" +
            " Channel gateways, as appropriate to your Topspin system. For more information, " +
            "see \"Install an Ethernet or Fibre Channel Gateway\" in the Topspin 360 Hardware G" +
            "uide.\r\n2.\tInstall a additional InfiniBand switch card:\r\n\ta.\tRemove the blanking " +
            "panel from the slot.\r\n\tb.\tSlide the IB switch card firmly into place. \r\n\tc.\tTigh" +
            "ten the screws to the on the left and right-hand sides of the IB switch card.\r\n\r" +
            "\nRack the Topspin 360\r\n\r\nTo mount the Topspin 360 in a rack, perform the followi" +
            "ng steps:\r\n\r\n1.\tOpen the Topspin box.\r\n2.\tRemove the chassis, rack brackets, CD-" +
            "ROM, parts bag, and documentation.\r\n\r\nCAUTION: Don\'t lift the 360 chassis by the" +
            " front (bezel end) and back (service end). Lift the unit by the sides to prevent" +
            " damage.\r\n\r\n1.\tPlace the chassis on a secure, clean surface.\r\n2.\tOpen the plasti" +
            "c bag that contains the mounting hardware.\r\n3.\tVerify that the rack will provide" +
            " sufficient clearance for the Topspin 360.\r\n4.\tLoosen the nuts on the sides of t" +
            "he rack brackets, then adjust the length of your brackets to fit your rack. Tigh" +
            "ten the bracket screws when the brackets fit the rack. Extend the brackets to 29" +
            " inches or contract them to 24 inches.\r\n5.\tAttach the side flanges to the sides " +
            "of the chassis with the screws provided, as shown in Figure 1-1 and Figure 1-2.\r" +
            "\n")]
        public string topspin {
            get {
                return ((string)(this["topspin"]));
            }
        }
    }
}
