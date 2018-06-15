import { Component, OnInit, Input } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatSort, MatDialog, MatDialogConfig, MatDialogRef } from '@angular/material';
import { AdoxioLegalEntity } from '../models/adoxio-legalentities.model';
import { DynamicsAccount } from '../models/dynamics-account.model';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { AdoxioLegalEntityDataService } from "../services/adoxio-legal-entity-data.service";
import { UserDataService } from '../services/user-data.service';
import { User } from '../models/user.model';

@Component({
  selector: 'app-edit-shareholders',
  templateUrl: './edit-shareholders.component.html',
  styleUrls: ['./edit-shareholders.component.scss']
})

export class EditShareholdersComponent implements OnInit {

  @Input() accountId: string;

  shareholderForm: FormGroup;
  shareholderList: AdoxioLegalEntity[] = [];
  dataSource = new MatTableDataSource<AdoxioLegalEntity>();
  public dataLoaded;
  displayedColumns = ['position', 'name', 'email', 'commonvotingshares'];
  user: User;

  constructor(private legalEntityDataservice: AdoxioLegalEntityDataService, 
    public dialog: MatDialog, private userDataService: UserDataService) {
  }

  ngOnInit() {
    this.getShareholders();
    this.userDataService.getCurrentUser().then(user =>{
      this.user = user;
    })
  }

  getShareholders() {
    this.dataLoaded = false;
    this.legalEntityDataservice.getLegalEntitiesbyPosition("shareholder")
      .then((data) => {
        //console.log("getLegalEntitiesbyPosition("shareholder"): ", data);
        this.dataSource.data = data;
        this.dataLoaded = true;
      });
  }

  formDataToModelData(formData: any, shareholderType: string ): AdoxioLegalEntity {
    let adoxioLegalEntity: AdoxioLegalEntity = new AdoxioLegalEntity();
    if (shareholderType == "Person") {
      adoxioLegalEntity.isindividual = true;
      adoxioLegalEntity.firstname = formData.firstName;
      adoxioLegalEntity.lastname = formData.lastName;
      adoxioLegalEntity.name = formData.firstName + " " + formData.lastName;
      adoxioLegalEntity.legalentitytype = "PrivateCorporation";
      //adoxioLegalEntity.email = formData.email;
    } else {
      adoxioLegalEntity.isindividual = false;
      adoxioLegalEntity.name = formData.organizationName;
      adoxioLegalEntity.legalentitytype = formData.organizationType;
    }
    adoxioLegalEntity.commonnonvotingshares = formData.numberOfNonVotingShares;
    adoxioLegalEntity.commonvotingshares = formData.numberOfVotingShares;
    ////adoxioLegalEntity.dateIssued = formData.dateIssued;
    adoxioLegalEntity.position = "Shareholder";
    //adoxioLegalEntity.relatedentities = [];
    // the accountId is received as parameter from the business profile
    if (this.accountId) {
      adoxioLegalEntity.account = new DynamicsAccount();
      adoxioLegalEntity.account.id = this.accountId;
    }
    return adoxioLegalEntity;
  }

  // Open Person shareholder dialog
  openPersonDialog() {
    // set dialogConfig settings
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;

    // set dialogConfig data
    //dialogConfig.data = {
    //  id: 1,
    //  title: 'Angular For Beginners'
    //};

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(ShareholderPersonDialog, dialogConfig);
    dialogRef.afterClosed().subscribe(
      formData => {
        //console.log("ShareholderPersonDialog output:", data);
        if (formData) {
          let shareholderType = "Person";
          let adoxioLegalEntity = this.formDataToModelData(formData, shareholderType);
          //console.log("adoxioLegalEntity output:", adoxioLegalEntity);
          this.legalEntityDataservice.createLegalEntity(adoxioLegalEntity).subscribe(
            res => {
              this.getShareholders();
            },
            err => {
              //console.log("Error occured");
              this.handleError(err);
            }
          );
        }
      }
    );
  }

  // Open Organization shareholder dialog
  openOrganizationDialog() {
    // set dialogConfig settings
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;

    // set dialogConfig data
    //dialogConfig.data = {
    //  id: 1,
    //  title: 'Angular For Beginners'
    //};

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(ShareholderOrganizationDialog, dialogConfig);
    dialogRef.afterClosed().subscribe(
      formData => {
        //console.log("ShareholderOrganizationDialog output:", data)
        if (formData) {
          let shareholderType = "Organization";
          let adoxioLegalEntity = this.formDataToModelData(formData, shareholderType);
          //console.log("adoxioLegalEntity output:", adoxioLegalEntity);
          this.legalEntityDataservice.createLegalEntity(adoxioLegalEntity).subscribe(
            res => {
              this.getShareholders();
            },
            err => {
              //console.log("Error occured");
              this.handleError(err);
            }
          );
        }
      }
    );
  }

  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error.json() || "";
      const err = body || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ""} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
  }


}

/***************************************
 * Shareholder Person Dialog
 ***************************************/
@Component({
  selector: 'edit-shareholders-person-dialog',
  templateUrl: 'edit-shareholders-person-dialog.html',
})
export class ShareholderPersonDialog {
  shareholderForm: FormGroup;

  constructor(private frmbuilder: FormBuilder, private dialogRef: MatDialogRef<ShareholderPersonDialog>) {
    this.shareholderForm = frmbuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.email],
      numberOfVotingShares: ['', Validators.required],
      numberOfNonVotingShares: ['', Validators.required],
      dateIssued: ['']
    }, { validator: this.dateLessThanToday('dateIssued') });
  }

  dateLessThanToday(field1) {
    return form => {
      const d1 = form.controls[field1].value;
      if (!d1) {
        return {};
      }
      const d1Date = new Date(d1.year, d1.month, d1.day);
      if (d1Date < new Date()) {
        return { dateLessThanToday: true };
      }
      return {};
    }
  }

  save() {
    //console.log('shareholderForm', this.shareholderForm.value, this.shareholderForm.valid);
    if (this.shareholderForm.valid) {
      this.dialogRef.close(this.shareholderForm.value);
    } else {
      Object.keys(this.shareholderForm.controls).forEach(field => {
        const control = this.shareholderForm.get(field);
        control.markAsTouched({ onlySelf: true });
      });
    }
  }

  isFieldError(field: string) {
    const isError = !this.shareholderForm.get(field).valid && this.shareholderForm.get(field).touched;
    return isError;
  }

  close() {
    this.dialogRef.close();
  }

}

/***************************************
 * Shareholder Organization Dialog
 ***************************************/
@Component({
  selector: 'edit-shareholders-organization-dialog',
  templateUrl: 'edit-shareholders-organization-dialog.html',
})
export class ShareholderOrganizationDialog {
  shareholderForm: FormGroup;

  constructor(private frmbuilder: FormBuilder, private dialogRef: MatDialogRef<ShareholderOrganizationDialog>) {
    this.shareholderForm = frmbuilder.group({
      organizationType: ['', Validators.required],
      organizationName: ['', Validators.required],
      numberOfVotingShares: ['', Validators.required],
      numberOfNonVotingShares: ['', Validators.required],
      dateIssued: ['']
    });
  }

  save() {
    //console.log('shareholderForm', this.shareholderForm.value, this.shareholderForm.valid);
    if (this.shareholderForm.valid) {
      this.dialogRef.close(this.shareholderForm.value);
    } else {
      Object.keys(this.shareholderForm.controls).forEach(field => {
        const control = this.shareholderForm.get(field);
        control.markAsTouched({ onlySelf: true });
      });
    }
  }



  close() {
    this.dialogRef.close();
  }

}

