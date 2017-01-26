import {Injectable} from '@angular/core';
import {HEROES} from './mock-heroes';
import {Http} from '@angular/http';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class HeroService {

    private heroesUrl = 'api/Hero';

    constructor(private http: Http) { }



    getHeroes(): Promise<Models.Hero[]> {
        //return Promise.resolve(HEROES);
        return this.http.get(this.heroesUrl).toPromise()
            .then(response => {
                return response.json();
            })
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
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