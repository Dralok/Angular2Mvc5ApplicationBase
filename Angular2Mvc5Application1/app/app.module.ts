import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import {HttpModule} from '@angular/http';

import {routing} from './app.routing';
import {AppComponent} from './app.component';
import {HeroService} from './hero/hero.service';
import {HeroesComponent} from './hero/heroes.component';
import {HeroDashboardComponent} from './hero/hero-dashboard.component';
import {HeroDetailComponent} from './hero/hero-detail.component';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        routing,
        HttpModule
    ],
    declarations: [
        AppComponent,
        HeroesComponent,
        HeroDetailComponent,
        HeroDashboardComponent
    ],
    bootstrap: [AppComponent],
    providers: [HeroService]
})
export class AppModule { }
