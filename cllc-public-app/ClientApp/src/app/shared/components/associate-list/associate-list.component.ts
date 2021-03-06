import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { LicenseeChangeLog } from '@models/licensee-change-log.model';
import { FormBuilder, Validators } from '@angular/forms';
import { FormBase } from '@shared/form-base';
import { Account } from '@models/account.model';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-associate-list',
  templateUrl: './associate-list.component.html',
  styleUrls: ['./associate-list.component.scss']
})
export class AssociateListComponent extends FormBase implements OnInit {
  @Input() personalHistoryItems: LicenseeChangeLog[] = [];
  @Input() rootNode: LicenseeChangeLog;
  @Input() account: Account;
  @Input() changeTypeSuffix: string;
  @Input() addLabel: string = 'Add Associate';
  businessType: string = 'Society';
  @Output() childAdded = new EventEmitter<LicenseeChangeLog>();

  LicenseeChangeLog = LicenseeChangeLog;
  busy: any;

  constructor(private fb: FormBuilder, 
    public snackBar: MatSnackBar,) {
    super();
  }

  ngOnInit() {
    this.form = this.fb.group({
      id: [''],
      contactPersonFirstName: ['', Validators.required],
      contactPersonLastName: ['', Validators.required],
      contactPersonRole: [''],
      amalgamationDone: [''],
      contactPersonEmail: ['', Validators.required],
      contactPersonPhone: ['', Validators.required],
      authorizedToSubmit: ['', [this.customRequiredCheckboxValidator()]],
      signatureAgreement: ['', [this.customRequiredCheckboxValidator()]],
    });
  }

  addAssociate() {
    const associate = new LicenseeChangeLog();
    associate.changeType = `add${this.changeTypeSuffix}`;
    associate.parentLinceseeChangeLog = this.rootNode;
    associate.edit = true;
    associate.collapse = true;
    this.childAdded.emit(associate);
  }

  saveLog(item: LicenseeChangeLog) {
    item.edit = false;
    if(!item.isAddChangeType()){
      item.changeType = `update${this.changeTypeSuffix}`;
    }
  }

  copyMessage(val: string){
    const selBox = document.createElement('textarea');
    selBox.style.position = 'fixed';
    selBox.style.left = '0';
    selBox.style.top = '0';
    selBox.style.opacity = '0';
    selBox.value = val;
    document.body.appendChild(selBox);
    selBox.focus();
    selBox.select();
    document.execCommand('copy');
    document.body.removeChild(selBox);
    this.snackBar.open('The link is copied to the clipboard', '', { duration: 2500, panelClass: ['green-snackbar'] });
  }

  deleteChange(node: LicenseeChangeLog) {
    node.businessNameNew = node.nameOld;
    node.isDirectorNew = node.isDirectorOld;
    node.isManagerNew = node.isManagerOld;
    node.isOfficerNew = node.isOfficerOld;
    node.isShareholderNew = node.isShareholderOld;
    node.isTrusteeNew = node.isTrusteeOld;
    node.numberofSharesNew = node.numberofSharesOld;
    node.totalSharesNew = node.totalSharesOld;
    node.emailNew = node.emailOld;
    node.firstNameNew = node.firstNameOld;
    node.lastNameNew = node.lastNameOld;
    node.businessNameNew = node.businessNameOld;
    node.dateofBirthNew = node.dateofBirthOld;
    node.titleNew = node.titleOld;

    if (!node.id && !node.legalEntityId) {
      const index = node.parentLinceseeChangeLog.children.indexOf(node);
      node.parentLinceseeChangeLog.children.splice(index, 1);
    } else if (node.id && !node.legalEntityId) {
      node.changeType = 'unchanged';
    } else if (!node.isRoot && node.legalEntityId) {
      node.changeType = 'deleted';
    }
  }

  showPosition(): boolean {
    return this.businessType === 'Society'
      || this.businessType === 'PublicCorporation';
  }

}
