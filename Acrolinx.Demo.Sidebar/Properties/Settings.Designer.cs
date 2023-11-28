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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Topspin 360 Quick Start\n\nThis document will describe the basic steps required to " +
            "install and configure the Topspin 360 system.\nRequirements\nTo install the Topspi" +
            "n 360 into a rack, you require the following:\n\n - one #1 and one #2 Phillips-hea" +
            "d screwdriver for fitting\n - one managment workstation, such as a PC running ter" +
            "minal-emulation software\n - the chasis cable kit (included)\n - two people to saf" +
            "ely lift the unit into the rack\n- TEST_CONTAINER\n\nTopspin 360 Package Contents\n\n" +
            "You will find the following items in your Topspin package:\n\n - 1 Topspin 360 Ser" +
            "ver Switch\n - 1 or 2 12-port InfiniBand switch blades\n - 1 or 2 power supplies\n " +
            "- 1 or 2 fan trays \n - 1 or 2 system controllers \n - 2 rack-mount brackets and m" +
            "ounting screws\n - 1 power-supply blanking panel\n - 1 expansion card blanking pan" +
            "el\n - 1 console-cable kit, which includes a DB-9 M/F serial cable\n - 1 or 2 6-fo" +
            "ot (1.8-meter) AC power cables\n - 1 CD-ROM containing software and user document" +
            "ation\n - 1 Quick Start Guide\n - 1 warranty card\n\nPreparing the Site\n\nTo prepare " +
            "the site for the Topspin 360, perform the following steps:\n\n1.\tRead the cautiona" +
            "ry statements in \"Safety Information\" on page 5.\n2.\tFill the Topspin registratio" +
            "n form out online. Go to http://www.topspin.com/support/prodreg.cfm.\n3.\tVerify t" +
            "hat the rack environment provides sufficient ventilation. \n4.\tUnpack the Topspin" +
            " 360 package.\n5.\tVerify that you have all of the items on the Requirements list." +
            " Refer to \"Requirements\" on page 1.\n\nInstall Topspin 360 FRUs\n\nInstall gateways " +
            "and switch cards to increase the port count of your switch.\nNote: whenever possi" +
            "ble install all FRUs before you rack your Topspin 360. You can continue to add o" +
            "r replace FRUs after you rack your device.\n\nTo install field replaceable units (" +
            "FRUs), perform the following steps:\n\n1.\tInstall any expansion modules (Fibre Cha" +
            "nnel gateways or Ethernet gateways):\na.\tRemove any filler panels from slots that" +
            " will have a card installed. Begin by filling the first gateway slot (slot 2).\nb" +
            ".\tInstall Ethernet and/or Fibre Channel gateways, as appropriate to your Topspin" +
            " system. For more information, see \"Install an Ethernet or Fibre Channel Gateway" +
            "\" in the Topspin 360 Hardware Guide.\n2.\tInstall a additional InfiniBand switch c" +
            "ard:\n\ta.\tRemove the blanking panel from the slot.\n\tb.\tSlide the IB switch card f" +
            "irmly into place. \n\tc.\tTighten the screws to the on the left and right-hand side" +
            "s of the IB switch card.\n\nRack the Topspin 360\n\nTo mount the Topspin 360 in a ra" +
            "ck, perform the following steps:\n\n1.\tOpen the Topspin box.\n2.\tRemove the chassis" +
            ", rack brackets, CD-ROM, parts bag, and documentation.\n\nCAUTION: Don\'t lift the " +
            "360 chassis by the front (bezel end) and back (service end). Lift the unit by th" +
            "e sides to prevent damage.\n\n1.\tPlace the chassis on a secure, clean surface.\n2.\t" +
            "Open the plastic bag that contains the mounting hardware.\n3.\tVerify that the rac" +
            "k will provide sufficient clearance for the Topspin 360.\n4.\tLoosen the nuts on t" +
            "he sides of the rack brackets, then adjust the length of your brackets to fit yo" +
            "ur rack. Tighten the bracket screws when the brackets fit the rack. Extend the b" +
            "rackets to 29 inches or contract them to 24 inches.\n5.\tAttach the side flanges t" +
            "o the sides of the chassis with the screws provided, as shown in Figure 1-1 and " +
            "Figure 1-2.\n")]
        public string topspin {
            get {
                return ((string)(this["topspin"]));
            }
        }
    }
}
