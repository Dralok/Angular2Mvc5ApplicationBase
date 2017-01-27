import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeroService } from './hero.service';

//export class Hero {
//    id: number;
//    name: string;
//}


@Component({
    selector: 'my-heroes',
//    template: `
//<h2>My Heroes</h2>
//<ul class="heroes">
//    <li *ngFor="let hero of heroes" (click)="onSelect(hero)" [class.selected]="hero === selectedHero">
//        <span class="badge">{{hero.id}}</span>
//        {{hero.name}}
//    </li>
//</ul>
//<div *ngIf="selectedHero">
//    <h2>{{selectedHero.name | uppercase}} is my hero</h2>
//    <button (click)="gotoDetail()">View Details</button>
//</div>

//`,
    templateUrl: './app/hero/heroes.component.html',
    styleUrls: ['./app/hero/heroes.component.css']
})
export class HeroesComponent implements OnInit {

    constructor(private heroService: HeroService, private router: Router) { }
  
    heroes: Models.Hero[];
    selectedHero: Models.Hero;

    onSelect(hero: Models.Hero) {
        this.selectedHero = hero;
    }

    getHeroes(): void {
        this.heroService.getHeroes()
            .then(heroes => this.heroes = heroes);
    }

    getHeroesSlowly(): void {
        this.heroService.getHeroesSlowly()
            .then(heroes => this.heroes = heroes);
    }

    ngOnInit(): void {
        this.getHeroes();
    }

    gotoDetail(): void {
        let link = ['/detail', this.selectedHero.id];
        this.router.navigate(link);
    }
}


