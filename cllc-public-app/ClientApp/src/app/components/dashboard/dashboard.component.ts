import { Component, OnInit } from '@angular/core';
import { AppState } from '@app/app-state/models/app-state';
import { Store } from '@ngrx/store';
import { takeWhile } from 'rxjs/operators';
import { FormBase } from '@shared/form-base';
import { Account } from '@models/account.model';
import { Application } from '@models/application.model';
import { ApplicationType, ApplicationTypeNames } from '@models/application-type.model';
import { ApplicationDataService } from '@services/application-data.service';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material';
import { LicenseeChangeLog } from '@models/licensee-change-log.model';
import { LegalEntity } from '@models/legal-entity.model';
import { LegalEntityDataService } from '@services/legal-entity-data.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent extends FormBase implements OnInit {
  account: Account;
  indigenousNationModeActive: boolean;
  currentLegalEntities: LegalEntity;
  tree: LicenseeChangeLog;

  constructor(private store: Store<AppState>,
    private router: Router,
    private snackBar: MatSnackBar,
    private legalEntityDataService: LegalEntityDataService,
    private applicationDataService: ApplicationDataService) {
    super();
  }

  ngOnInit(): void {
    this.store.select((state) => state.currentAccountState.currentAccount)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((account) => {
        this.account = account;
      });

    this.store.select((state) => state.indigenousNationState.indigenousNationModeActive)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((active) => {
        this.indigenousNationModeActive = active;
      });

      this.legalEntityDataService.getCurrentHierachy()
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((data: LegalEntity) => {
        this.tree = LicenseeChangeLog.processLegalEntityTree(data);
        this.tree.isRoot = true;
      },
        () => {
          console.log('Error occured');
        }
      );
  }

  startLicenseeChangeApplication() {
    const newLicenceApplicationData: Application = <Application>{
      // licenseType: ApplicationTypeNames.LeaderhsipChange,
      applicantType: this.account.businessType,
      applicationType: <ApplicationType>{ name: ApplicationTypeNames.LicenseeChanges },
      account: this.account,
    };

    this.applicationDataService.createApplication(newLicenceApplicationData).subscribe(
      data => {
        this.router.navigateByUrl(`/licensee-changes/${data.id}`);
      },
      () => {
        this.snackBar.open('Error starting a New Licensee Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a New Licensee Application');
      }
    );
  }

}
