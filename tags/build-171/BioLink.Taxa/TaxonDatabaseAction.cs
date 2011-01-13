﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BioLink.Data;
using BioLink.Data.Model;
using BioLink.Client.Extensibility;

namespace BioLink.Client.Taxa {

    public abstract class TaxonDatabaseAction : DatabaseAction {
    }

    public class MoveTaxonDatabaseAction : TaxonDatabaseAction {

        public MoveTaxonDatabaseAction(TaxonViewModel taxon, TaxonViewModel newParent) {
            this.Taxon = taxon;
            this.NewParent = newParent;
        }

        public TaxonViewModel Taxon { get; private set; }
        public TaxonViewModel NewParent { get; private set; }

        protected override void ProcessImpl(User user) {
            var service = new TaxaService(user);
            service.MoveTaxon(Taxon.TaxaID.Value, NewParent.TaxaID.Value);
        }

        public override string ToString() {
            return String.Format("Move: {0} to {1}", Taxon, NewParent);
        }
    }

    public class UpdateTaxonDatabaseAction : TaxonDatabaseAction {

        public UpdateTaxonDatabaseAction(Taxon taxon) {
            this.Taxon = taxon;
        }

        public Taxon Taxon { get; private set; }

        protected override void ProcessImpl(User user) {
            var service = new TaxaService(user);
            service.UpdateTaxon(Taxon);
        }

        public override string ToString() {
            return String.Format("Update: {0}", Taxon);
        }

        public override bool Equals(object obj) {
            UpdateTaxonDatabaseAction other = obj as UpdateTaxonDatabaseAction;
            if (other != null) {
                return other.Taxon.TaxaID == this.Taxon.TaxaID;
            }
            return false;
        }

        public override int GetHashCode() {
            return Taxon.GetHashCode();
        }

    }

    public class MergeTaxonDatabaseAction : TaxonDatabaseAction {

        public MergeTaxonDatabaseAction(TaxonViewModel source, TaxonViewModel target, bool createNewIDRecord) {
            this.Source = source;
            this.Target = target;
            this.CreateNewIDRecord = createNewIDRecord;
        }

        public TaxonViewModel Source { get; private set; }
        public TaxonViewModel Target { get; private set; }
        public bool CreateNewIDRecord { get; private set; }

        protected override void ProcessImpl(User user) {
            var service = new TaxaService(user);
            service.MergeTaxon(Source.TaxaID.Value, Target.TaxaID.Value, CreateNewIDRecord);
            service.DeleteTaxon(Source.TaxaID.Value);
        }

        public override string ToString() {
            return String.Format("Merging: {0} with {1}", Source, Target);
        }


    }

    public class DeleteTaxonDatabaseAction : TaxonDatabaseAction {
        
        public DeleteTaxonDatabaseAction(TaxonViewModel taxon) {
            this.Taxon = taxon;
        }

        public TaxonViewModel Taxon { get; private set; }

        protected override void ProcessImpl(User user) {
            var service = new TaxaService(user);
            service.DeleteTaxon(Taxon.TaxaID.Value);
        }

        public override string ToString() {
            return String.Format("Deleting: {0} ", Taxon);
        }

    }

    public class InsertTaxonDatabaseAction : TaxonDatabaseAction {

        public InsertTaxonDatabaseAction(TaxonViewModel taxon) {
            this.Taxon = taxon;
        }

        public TaxonViewModel Taxon { get; private set; }

        protected override void ProcessImpl(User user) {
            var service = new TaxaService(user);
            service.InsertTaxon(Taxon.Taxon);
            // The service will have updated the new taxon with its database identity.
            // If this taxon has any children we can update their identity too.
            foreach (HierarchicalViewModelBase child in Taxon.Children) {
                TaxonViewModel tvm = child as TaxonViewModel;
                tvm.TaxaParentID = Taxon.Taxon.TaxaID;
            }
        }

        public override string ToString() {
            return String.Format("Inserting: {0}", Taxon);
        }


    }

    
}
