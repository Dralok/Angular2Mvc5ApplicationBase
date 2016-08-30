import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import {HeroService} from './hero.service';

@Component({
    selector: 'my-dashboard',
    //template: '<h3>My Dashboard</h3>'
    templateUrl: 'app/dashboard.component.html',
    styleUrls: ['app/dashboard.component.css']
})
export class DashboardComponent {

    heroes: Models.Hero[] = [];

    constructor(private heroService: HeroService, private router: Router) { }

    ngOnInit(): void {
        this.heroService.getHeroes()
            .then(heroes => this.heroes = heroes.slice(1,5));
    }

    gotoDetail(hero: Models.Hero): void {
        let link = ['/detail', hero.id];
        this.router.navigate(link);
    }

}
