import { Routes, RouterModule} from '@angular/router';
import { HeroesComponent } from './hero/heroes.component';
import { HeroDashboardComponent } from './hero/hero-dashboard.component';
import { HeroDetailComponent } from './hero/hero-detail.component';

const appRoutes: Routes = [
    {
        path: '',
        redirectTo: '/herodashboard',
        pathMatch: 'full'
    },
    {
        path: 'heroes',
        component: HeroesComponent
    },
    {
        path: 'herodashboard',
        component: HeroDashboardComponent
    },
    {
        path: 'detail/:id',
        component: HeroDetailComponent
    }
]

export const routing = RouterModule.forRoot(appRoutes);
