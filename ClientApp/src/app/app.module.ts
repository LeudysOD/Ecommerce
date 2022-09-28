import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainMenuComponent } from './main-menu/main-menu.component';
import { AdmMenuComponent } from './adm-menu/adm-menu.component';
import { ModalsComponent } from './modals/modals.component';

@NgModule({
  declarations: [
    AppComponent,
    MainMenuComponent,
    AdmMenuComponent,
    ModalsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
