"use strict";
var router_1 = require('@angular/router');
var heroes_component_1 = require('./hero/heroes.component');
var hero_dashboard_component_1 = require('./hero/hero-dashboard.component');
var hero_detail_component_1 = require('./hero/hero-detail.component');
var appRoutes = [
    {
        path: '',
        redirectTo: '/herodashboard',
        pathMatch: 'full'
    },
    {
        path: 'heroes',
        component: heroes_component_1.HeroesComponent
    },
    {
        path: 'herodashboard',
        component: hero_dashboard_component_1.HeroDashboardComponent
    },
    {
        path: 'detail/:id',
        component: hero_detail_component_1.HeroDetailComponent
    }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map