﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BioLink.Client.Extensibility;
using BioLink.Data;
using BioLink.Client.Utilities;
using System.Windows;

namespace BioLink.Client.Gazetteer {

    public class GazetterPlugin : BiolinkPluginBase {

        private ExplorerWorkspaceContribution<Gazetteer> _gazetter;

        public GazetterPlugin(User user, PluginManager pluginManager)
            : base(user, pluginManager) {
        }


        public override string Name {
            get { return "Gazetteer"; }
        }

        public override List<IWorkspaceContribution> Contributions {
            get {
                List<IWorkspaceContribution> contrib = new List<IWorkspaceContribution>();
                contrib.Add(new MenuWorkspaceContribution(this, "ShowGazetteer", (obj, e) => { PluginManager.EnsureVisible(this, "Gazetteer"); },
                    String.Format("{{'Name':'View', 'Header':'{0}','InsertAfter':'File'}}", _R("Gazetteer.Menu.View")),
                    String.Format("{{'Name':'ShowGazetteer', 'Header':'{0}'}}", _R("Gazetteer.Menu.ShowExplorer"))
                ));

                _gazetter = new ExplorerWorkspaceContribution<Gazetteer>(this, "Gazetteer", new Gazetteer(this), _R("Gazetteer.Title"), (explorer) => {});

                contrib.Add(_gazetter);

                return contrib;            

            }
        }

        public override void Dispose() {
            if (_gazetter != null) {
                (_gazetter.Content as Gazetteer).Dispose();
            }
        }
    }
}
