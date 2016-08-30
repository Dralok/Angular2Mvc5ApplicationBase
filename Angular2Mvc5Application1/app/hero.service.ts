import {Injectable} from '@angular/core';
import {HEROES} from './mock-heroes';

@Injectable()
export class HeroService {

    getHeroes(): Promise<Models.Hero[]> {
        return Promise.resolve(HEROES);
    }

    getHeroesSlowly(): Promise<Models.Hero[]>  {
        return new Promise<Models.Hero[]>(
            resolve => setTimeout(
                () => resolve(HEROES), 2000)
        );
    }

    getHero(id: number): Promise<Models.Hero> {
        return this.getHeroes()
            .then(heroes => heroes.find(hero => hero.id === id));
    }

}